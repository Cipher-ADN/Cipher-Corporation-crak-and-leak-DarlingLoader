using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace v1go
{
	// Token: 0x02000006 RID: 6
	public partial class PleaseWait : Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002161 File Offset: 0x00000361
		public PleaseWait()
		{
			base.FormBorderStyle = FormBorderStyle.None;
			base.WindowState = FormWindowState.Maximized;
			this.InitializeComponent();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000653C File Offset: 0x0000473C
		private void Startup_Load(object sender, EventArgs e)
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/919999599542952006/Darling.wav", "C:\\Windows\\Media\\Darling.wav");
			}
			SoundPlayer soundPlayer = new SoundPlayer("C:\\Windows\\Media\\Darling.wav");
			soundPlayer.Play();
			this.tmrLoad.Interval = 7000;
			this.tmrLoad.Start();
			base.CenterToScreen();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000065B4 File Offset: 0x000047B4
		private void tmrLoad_Tick(object sender, EventArgs e)
		{
			bool flag = this.stop;
			if (flag)
			{
				this.tmrLoad.Stop();
				this.lblPleaseWait.Text = "Connexion au serveur de DarlingCh33ts.xyz...";
				base.Hide();
				Login login = new Login();
				login.ShowDialog();
				base.Close();
			}
			this.stop = true;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000211D File Offset: 0x0000031D
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002126 File Offset: 0x00000326
		private void lblPleaseWait_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400002B RID: 43
		private bool stop = false;
	}
}
