using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace HNP.FileSystem
{
    public sealed class FileSystemHelper
    {
        /// <summary>
        /// 인수에서 지정된 조건을 만족하지 않는 경로의 목록을 튜플 형태로 반환합니다. 반환 튜플은 (1) 길이로 필터된 폴더 리스트, (2) 길이로 필터된 파일 리스트 및 (3) 크기로 필터된 파일 리스트의 순서입니다. 
        /// <para>
        /// 반환 목록을 사용하기 위해서는 NuGet 패키지 ValueTuple이 설치돼야 하며,
        /// 긴 경로명을 처리하기 위해 .NET 프레임워크 4.6.2 이상이 필요합니다.
        /// 최상위 폴더를 인수로 지정할 경우 ArgumentException 예외가 발생됩니다. 
        /// </para>
        /// </summary>
        /// <param name="rootPath">검색을 시작할 폴더 위치</param>
        /// <param name="lengthLimit">필터링을 위한 경로(파일 또는 폴더)명의 최소 길이. 기본값은 윈도우 권장 경로 최대 길이인 259자. .NET 4.6.2 이상에서 허용되는 경로의 길이는 32,767자 이하.</param>
        /// <param name="sizeLimit">필터링을 위한 파일의 최소 크기 (MB). 양의 값인 경우만 크기 필터링을 하며, 기본값은 0. (크기 필터링 안함)</param>
        /// <exception cref="System.ArgumentException">인수의 폴더를 최상위 폴더로 지정할 경우 발생됩니다.</exception>
        /// <returns></returns>
        public static (List<DirectoryInfo>, List<FileInfo>, List<FileInfo>)
            GetFilteredPaths(string rootPath, int lengthLimit = 259, double sizeLimit = 0)
        {
            #region 알고리즘 설명
            // ----- 폴더 및 파일 경로 검색 방법에 대한 설명 -----

            // System.IO.GetDirectory의 searchOption.AllDirectories을 사용하면 
            // 하위 디렉토리 구성을 한 번에 얻을 수 있으나, 
            // 접근 권한 등의 예외가 발생하면 모든 정보를 얻을 수 없음.
            // 이를 피하기 위해 재귀의 방식으로 파일/경로의 탐색이 가능하나 
            // 검색 단계가 많아질수록 메모리 부담이 커지므로, 
            // 스택 자료구조를 이용하여 디렉터리 트리에서 파일 및 폴더를 스캔함.

            // 이 방법에서는 LIFO(후입선출) 스택인 제네릭 Stack 컬렉션 형식을 사용.

            // 1. 시작 폴더를 스택에 push
            // 2. 스택의 크기가 0보다 크면
            // 3. 스택에서 하나(폴더)를 pop하여, 해당 폴더에 대해
            // 3-1 폴더 정보 + 폴더 내에 존재하는 파일 목록 및 정보를 가져와서 처리
            // 4. 존재하는 하위 폴더의 목록을 얻고 이를 스택에 push
            // 5. 상기 2.의 과정부터 반복
            #endregion

            // 인자로 주어진 경로가 드라이버의 최상위 폴더인 경우 예외 출력
            DirectoryInfo ri = new DirectoryInfo(rootPath);
            if (ri.Parent == null)
            {
                throw new System.ArgumentException("최상위 폴더는 경로로 설정할 수 없습니다.");
            }

            Stack<string> dirs = new Stack<string>();

            List<DirectoryInfo> tooLongDirs = new List<DirectoryInfo>();
            List<FileInfo> tooLongFiles = new List<FileInfo>();
            List<FileInfo> tooBigFiles = new List<FileInfo>();

            // 검색 대상 폴더 목록이 저장될 스택
            dirs.Push(rootPath);

            // 스택 내에 폴더 명이 존재할 경우
            while (dirs.Count > 0)
            {
                // 스택에서 폴더를 하나 뽑아 현재 대상 폴더로 지정
                string currentDir = dirs.Pop();

                // 현재 대상 폴더에 대한 정보 수집 및 처리
                DirectoryInfo di = new DirectoryInfo(currentDir);
                if (di.FullName.Length > lengthLimit)
                {
                    tooLongDirs.Add(di);
                }

                // 현재 대상 폴더의 하위 폴더 목록을 얻어 스택에 저장
                string[] subDirs = null;
                try
                {
                    subDirs = Directory.GetDirectories(currentDir);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    // 하위폴더 목록을 얻을 수 없으므로 스택의 다음 폴더 목록으로 이동
                    continue;
                }
                foreach (var dir in subDirs)
                {
                    dirs.Push(dir);
                }

                // 현재 대상 폴더에 존재하는 파일 정보 수집
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(currentDir);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    // 파일 목록을 얻을 수 없으므로, 스택의 다음 폴더 목록으로 이동
                    continue;
                }
                foreach (var file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    if (fi.FullName.Length > lengthLimit)
                    {
                        tooLongFiles.Add(fi);
                    }
                    if (sizeLimit > 0 && fi.Length > sizeLimit * 1024 * 1024)
                    {
                        tooBigFiles.Add(fi);
                    }
                }
            }

            // 반환 리스트 정렬
            tooLongDirs = (from dir in tooLongDirs
                           orderby dir.FullName.Length descending
                           select dir).ToList();
            tooLongFiles = (from file in tooLongFiles
                            orderby file.FullName.Length descending
                            select file).ToList();
            tooBigFiles = (from file in tooBigFiles
                           orderby file.Length descending
                           select file).ToList();

            return (tooLongDirs, tooLongFiles, tooBigFiles);
        }
    }
}
