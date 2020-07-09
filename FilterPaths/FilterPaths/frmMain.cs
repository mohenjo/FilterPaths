using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using HNP.FileSystem;
using System.Threading;


namespace FilterPaths
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region 사용자 메소드
        /// <summary>
        /// 폼 초기화를 위한 사용자 메소드
        /// </summary>
        private void InitializeUI()
        {
            this.Text = Globals.AppTitle;
            txtRootPath.Text = Directory.GetCurrentDirectory();
            nudPathLengthLimit.Value = 259;
            nudFileSizeLimit.Value = 0;
#if DEBUG
            txtRootPath.Text = @"D:\Dev";
            nudPathLengthLimit.Value = 150;
            nudFileSizeLimit.Value = 4;
#endif

            toolTip.SetToolTip(nudPathLengthLimit, "윈도우 권장은 259자 이하입니다.");
            toolTip.SetToolTip(nudFileSizeLimit, "양의 값인 경우만 파일 크기 필터링을 수행합니다.");
        }

        /// <summary>
        /// 리스트 뷰 내용 업데이트
        /// </summary>
        private void UpdateListViews()
        {

            lstvMain.BeginUpdate();

            // 리스트 뷰 내용 초기화 
            lstvMain.Items.Clear();

            // 업데이트 - 긴 폴더 명
            foreach (var dir in Globals.LongDirs)
            {
                ListViewItem lv = new ListViewItem("긴 폴더"); // 분류
                lv.SubItems.Add(dir.FullName.Length.ToString()); // 길이
                lv.SubItems.Add(""); // 크기
                lv.SubItems.Add(dir.Name); // 경로
                lv.SubItems.Add(dir.FullName); // 절대 경로

                lstvMain.Items.Add(lv);
            }

            // 업데이트 - 긴 파일 명
            foreach (var file in Globals.LongFiles)
            {
                ListViewItem lv = new ListViewItem("긴 파일"); // 분류
                lv.SubItems.Add(file.FullName.Length.ToString()); // 길이
                lv.SubItems.Add($"{(double)file.Length / 1024:#,##0.0}"); // 크기
                lv.SubItems.Add(file.Name); // 경로
                lv.SubItems.Add(file.FullName); // 절대 경로

                lstvMain.Items.Add(lv);
            }

            // 업데이트 - 큰 파일 명
            foreach (var file in Globals.BigFiles)
            {
                ListViewItem lv = new ListViewItem("큰 파일"); // 분류
                lv.SubItems.Add(file.FullName.Length.ToString()); // 길이
                lv.SubItems.Add($"{(double)file.Length / 1024:#,##0.0}"); // 크기
                lv.SubItems.Add(file.Name); // 경로
                lv.SubItems.Add(file.FullName); // 절대 경로

                lstvMain.Items.Add(lv);
            }

            // autosize columns
            clmName.Width = -1;
            clmFullName.Width = -1;
            clmLength.Width = -1;
            if (clmLength.Width < 90) { clmLength.Width = 90; }
            clmSize.Width = -1;
            if (clmSize.Width < 90) { clmSize.Width = 90; }

            lstvMain.EndUpdate();

            if (lstvMain.Items.Count ==0 )
            {
                MessageBox.Show("필터링된 항목이 존재하지 않습니다.", "필터링 결과", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 필터링 값을 기준으로 파일/폴더 정보 갱신
        /// </summary>
        private void GetFilteredResult()
        {
            string rootPath = txtRootPath.Text;
            int pathLengthLimit = (int)nudPathLengthLimit.Value;
            double fileSizeLimit = (double)nudFileSizeLimit.Value;

            (Globals.LongDirs, Globals.LongFiles, Globals.BigFiles) =
            FileSystemHelper.GetFilteredPaths(rootPath, pathLengthLimit, fileSizeLimit);
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeUI();

        }

        private void toolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void txtRootPath_TextChanged(object sender, EventArgs e)
        {
            toolTip.SetToolTip(txtRootPath, txtRootPath.Text);
        }

        private void btnBrowseRootPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = txtRootPath.Text;
            string selectedPath = string.Empty;
            var dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog.SelectedPath;
                // 선택 경로가 드라이버의 최상위 경로인지 검사
                DirectoryInfo spdi = new DirectoryInfo(selectedPath);
                if (spdi.Parent == null)
                {
                    MessageBox.Show("드라이브의 최상위 경로는 선택할 수 없습니다.", Globals.AppTitle + " - 경고", MessageBoxButtons.OK);
                }
                else
                {
                    txtRootPath.Text = selectedPath;
                }

            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            frmWait fw = new frmWait();

            fw.Show();
            Application.DoEvents();


            Thread threadGetResult = new Thread(new ThreadStart(GetFilteredResult));
            threadGetResult.IsBackground = true;
            threadGetResult.Start();
            threadGetResult.Join(); // 쓰레드가 종료될 때까지 대기

            this.Enabled = true;

            fw.Close();

            // 리스트 뷰 업데이트
            UpdateListViews();
        }

        // 리스트 뷰 항목 더블클릭 시 해당 경로를 탐색에서 오픈
        private void lstvMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 멀티 셀렉션의 경우 선택된 Item들의 컬렉션을 가져옴
            var selectedItems = lstvMain.SelectedItems;
            // 단일 셀렉션이므로, 첫번째 Item 선택
            ListViewItem selectedItem = selectedItems[0];
            // 절대 경로
            string absolutePath = selectedItem.SubItems[4].Text;
            // 부모 경로
            DirectoryInfo parentPath = Directory.GetParent(absolutePath);
            // 부모 경로에 대해 파일 탐색기 열기
            Process.Start(parentPath.ToString());
        }
    }
}
