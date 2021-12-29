using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace v1go
{
	// Token: 0x02000009 RID: 9
	public partial class PleaseWait2 : Form
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000021FC File Offset: 0x000003FC
		public PleaseWait2()
		{
			base.FormBorderStyle = FormBorderStyle.None;
			base.WindowState = FormWindowState.Maximized;
			this.InitializeComponent();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000222B File Offset: 0x0000042B
		private void Startup_Load(object sender, EventArgs e)
		{
			this.tmrLoad.Interval = 2000;
			this.tmrLoad.Start();
			base.CenterToScreen();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000072B0 File Offset: 0x000054B0
		private void tmrLoad_Tick(object sender, EventArgs e)
		{
			bool flag = this.stop;
			if (flag)
			{
				this.tmrLoad.Stop();
				base.Hide();
				Login login = new Login();
				login.ShowDialog();
				base.Close();
			}
			this.stop = true;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000211D File Offset: 0x0000031D
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002126 File Offset: 0x00000326
		private void lblPleaseWait_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400003E RID: 62
		private bool stop = false;
	}
}
