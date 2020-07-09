using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HNP.FileSystem;
using System.IO;
using System.Diagnostics;

namespace TestWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\Dev";
            int lengthLimit = 150;
            double sizeLimit = 4.0; // in MB

            List<DirectoryInfo> longDirs = new List<DirectoryInfo>();
            List<FileInfo> longFiles = new List<FileInfo>();
            List<FileInfo> bigFiles = new List<FileInfo>();

            (longDirs, longFiles, bigFiles) =
                FileSystemHelper.GetFilteredPaths(rootPath, lengthLimit: lengthLimit, sizeLimit: sizeLimit);

#if DEBUG
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{lengthLimit}자를 초과하는 디렉토리 리스트:");
            foreach (var dir in longDirs)
            {
                sb.AppendLine($"\t[{dir.FullName.Length}자] {dir.FullName}");
            }

            sb.AppendLine($"{lengthLimit}자를 초과하는 파일 리스트:");
            foreach (var file in longFiles)
            {
                sb.AppendLine($"\t[{file.FullName.Length}자] {file.FullName}");
            }
            sb.AppendLine($"{sizeLimit:#,##0.00}MB를 초과하는 파일 리스트:");
            foreach (var file in bigFiles)
            {
                sb.AppendLine($"\t[{(double)file.Length / (1024 * 1024):#,##0.00}MB] {file.FullName}");
            }
            Debug.WriteLine(sb.ToString());
#endif

            //Console.ReadKey();
        }
    }
}
