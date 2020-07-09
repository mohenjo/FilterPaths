using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterPaths
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        #region 사용자 정의 메소드
        private void InitializeUI()
        {
            this.Text = Globals.AppTitle + " 정보";
            lblTitleInfo.Text = Globals.AppTitle;
            lblVersionInfo.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lblAuthorInfo.Text = "Haennim Park";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Microsoft Windows™ 시스템에서는 경로명의 최대 길이를 260자 미만으로 권장(내부적으로는 32,767자 이하의 길이까지 처리 가능하지만)하고 있습니다. 이보다 긴 길이의 경로명에 대해 처리 가능한 경우도 있지만, 보통의 경우 경로의 생성 자체가 안되거나 경로의 복사, 이동, 특히 클라우드 동기화 작업 등의 수행 시 오류가 발생할 가능성이 높습니다. ");
            sb.AppendLine();
            sb.AppendLine("이 프로그램은 경로명의 길이, 단일 파일의 크기 필터를 통해 기준을 초과하는 경로 및 파일의 목록을 가져옵니다.");
            txtDescription.Text = sb.ToString();

            sb.Clear();
            sb.AppendLine("THE BEERWARE LICENSE (Revision 42): ");
            sb.AppendLine("Haennim Park wrote this software. As long as you retain this notice you can do whatever you want with this stuff. If we meet some day, and you think this stuff is worth it, you can buy me a beer in return.");
            sb.AppendLine();
            sb.AppendLine("*BEERWARE LICENSE");
            sb.AppendLine("This license is extremely permissive, and falls under the \"Copyright only\" category of licenses, where it is effectively in the Public Domain, but Copyright is still retained. The license contains an optional clause where, if the recipient feels that the licensed work is \"worth it\", they have the option to purchase the copyright holder a beer. If this were mandatory, it would make this license non-free, but since it is optional, it does not consist of a use restriction. As written, this license is Free and GPL compatible. The original license was found here: http://people.freebsd.org/~phk/");
            txtLicense.Text = sb.ToString();


        }

        #endregion

        private void frmAbout_Load(object sender, EventArgs e)
        {
            InitializeUI();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
