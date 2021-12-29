using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace v1go
{
	// Token: 0x02000007 RID: 7
	public partial class AuthLoad : Form
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002190 File Offset: 0x00000390
		public AuthLoad(string loginName)
		{
			this.loginName = loginName;
			this.InitializeComponent();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000021B6 File Offset: 0x000003B6
		private void Startup_Load(object sender, EventArgs e)
		{
			base.CenterToScreen();
			this.tmrLoad.Interval = 1500;
			this.tmrLoad.Start();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006A04 File Offset: 0x00004C04
		private void tmrLoad_Tick(object sender, EventArgs e)
		{
			bool flag = this.stop;
			if (flag)
			{
				this.tmrLoad.Stop();
				base.Hide();
				Loader loader = new Loader(this.loginName);
				loader.ShowDialog();
				base.Close();
			}
			this.stop = true;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000211D File Offset: 0x0000031D
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x04000031 RID: 49
		private string loginName;

		// Token: 0x04000032 RID: 50
		private bool stop = false;
	}
}
