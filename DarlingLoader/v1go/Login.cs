using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using KeyAuth;

namespace v1go
{
	// Token: 0x0200000A RID: 10
	public partial class Login : Form
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00002252 File Offset: 0x00000452
		public Login()
		{
			base.FormBorderStyle = FormBorderStyle.None;
			base.WindowState = FormWindowState.Maximized;
			this.InitializeComponent();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000226E File Offset: 0x0000046E
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
			base.CenterToScreen();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002280 File Offset: 0x00000480
		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (Login.KeyAuthApp.license(this.txtUsername.Text))
			{
				base.Hide();
				new AuthLoad(this.txtUsername.Text.Trim()).ShowDialog();
				base.Close();
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000022C0 File Offset: 0x000004C0
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000022C7 File Offset: 0x000004C7
		private void txtUsername_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000022C7 File Offset: 0x000004C7
		private void chkRemember_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000044 RID: 68
		private static string name = "Cipher-loader";

		// Token: 0x04000045 RID: 69
		private static string ownerid = "BjaTGmTq5p";

		// Token: 0x04000046 RID: 70
		private static string secret = "66266ea65cd193378684105d8ff284baea98b87280e17dcb7d78fb77a2c6c58e";

		// Token: 0x04000047 RID: 71
		private static string version = "1.0";

		// Token: 0x04000048 RID: 72
		public static api KeyAuthApp = new api(Login.name, Login.ownerid, Login.secret, Login.version);
	}
}
