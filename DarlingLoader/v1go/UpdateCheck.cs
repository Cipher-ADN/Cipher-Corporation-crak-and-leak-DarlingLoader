using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace v1go
{
	// Token: 0x02000008 RID: 8
	public partial class UpdateCheck : Form
	{
		// Token: 0x06000046 RID: 70 RVA: 0x000021DD File Offset: 0x000003DD
		public UpdateCheck()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006DF0 File Offset: 0x00004FF0
		private void Startup_Load(object sender, EventArgs e)
		{
			this.tmrLoad.Start();
			WebClient webClient = new WebClient();
			try
			{
				bool flag = !webClient.DownloadString("https://pastebin.com/raw/XE9WiAEm").Contains("2.4");
				if (flag)
				{
					string text = "Veux tu update ton loader ?";
					string caption = "Nouvelle update disponible !";
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					DialogResult dialogResult = MessageBox.Show(text, caption, buttons);
					bool flag2 = dialogResult == DialogResult.Yes;
					if (flag2)
					{
						using (WebClient webClient2 = new WebClient())
						{
							webClient2.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/917547356042440704/DarlingUpdater.exe", "DarlingUpdater.exe");
						}
						Process.Start("DarlingUpdater.exe");
					}
					else
					{
						bool flag3 = dialogResult == DialogResult.No;
						if (flag3)
						{
							Application.Exit();
						}
					}
				}
				else
				{
					this.tmrLoad.Stop();
					base.Hide();
					PleaseWait2 pleaseWait = new PleaseWait2();
					pleaseWait.ShowDialog();
					base.Close();
				}
			}
			catch
			{
			}
			Application.Exit();
			base.CenterToScreen();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002126 File Offset: 0x00000326
		private void tmrLoad_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000211D File Offset: 0x0000031D
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002126 File Offset: 0x00000326
		private void lblPleaseWait_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x04000038 RID: 56
		private bool stop = false;
	}
}
