namespace v1go
{
	// Token: 0x02000005 RID: 5
	public partial class Loader : global::System.Windows.Forms.Form
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00005208 File Offset: 0x00003408
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005240 File Offset: 0x00003440
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::v1go.Loader));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lstCheats = new global::System.Windows.Forms.ListBox();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.grpGameInfo = new global::System.Windows.Forms.GroupBox();
			this.lblVersion = new global::System.Windows.Forms.Label();
			this.lblGameName = new global::System.Windows.Forms.Label();
			this.grpCheatInfo = new global::System.Windows.Forms.GroupBox();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.lblStatusLabel = new global::System.Windows.Forms.Label();
			this.lblExpirationDate = new global::System.Windows.Forms.Label();
			this.lblDaysLeft = new global::System.Windows.Forms.Label();
			this.chkRememberCheat = new global::System.Windows.Forms.CheckBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox5 = new global::System.Windows.Forms.PictureBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.grpGameInfo.SuspendLayout();
			this.grpCheatInfo.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage");
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new global::System.Drawing.Point(1, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(1904, 55);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.lstCheats.AccessibleName = "";
			this.lstCheats.BackColor = global::System.Drawing.Color.Black;
			this.lstCheats.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.lstCheats.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.lstCheats.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lstCheats.ForeColor = global::System.Drawing.Color.White;
			this.lstCheats.FormattingEnabled = true;
			this.lstCheats.ItemHeight = 17;
			this.lstCheats.Items.AddRange(new object[]
			{
				"Fortnite - Chapitre 3",
				"Valorant",
				"Rainbow Six: Siege",
				"Apex Legends",
				"FiveM",
				"Paladin",
				"Propnight",
				"Rust",
				"Sea of Thieves",
				"-",
				"Forcer EAC/BE",
				"Windows Activation",
				"Defender Control",
				"Cleaner Fortnite",
				"HWID Spoofer"
			});
			this.lstCheats.Location = new global::System.Drawing.Point(6, 19);
			this.lstCheats.Name = "lstCheats";
			this.lstCheats.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.lstCheats.Size = new global::System.Drawing.Size(246, 918);
			this.lstCheats.TabIndex = 6;
			this.lstCheats.SelectedIndexChanged += new global::System.EventHandler(this.lstCheats_SelectedIndexChanged);
			this.btnCancel.BackColor = global::System.Drawing.Color.DarkRed;
			this.btnCancel.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnCancel.Location = new global::System.Drawing.Point(1785, 1014);
			this.btnCancel.Margin = new global::System.Windows.Forms.Padding(1);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(108, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Fermer";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.grpGameInfo.BackColor = global::System.Drawing.Color.Black;
			this.grpGameInfo.Controls.Add(this.lblVersion);
			this.grpGameInfo.Controls.Add(this.lblGameName);
			this.grpGameInfo.Controls.Add(this.grpCheatInfo);
			this.grpGameInfo.ForeColor = global::System.Drawing.Color.Cyan;
			this.grpGameInfo.Location = new global::System.Drawing.Point(282, 51);
			this.grpGameInfo.Name = "grpGameInfo";
			this.grpGameInfo.Size = new global::System.Drawing.Size(305, 251);
			this.grpGameInfo.TabIndex = 9;
			this.grpGameInfo.TabStop = false;
			this.grpGameInfo.Text = "Game Information";
			this.lblVersion.AutoSize = true;
			this.lblVersion.Location = new global::System.Drawing.Point(15, 54);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new global::System.Drawing.Size(51, 13);
			this.lblVersion.TabIndex = 1;
			this.lblVersion.Text = "Version: -";
			this.lblVersion.Click += new global::System.EventHandler(this.lblVersion_Click);
			this.lblGameName.AutoSize = true;
			this.lblGameName.Location = new global::System.Drawing.Point(15, 34);
			this.lblGameName.Name = "lblGameName";
			this.lblGameName.Size = new global::System.Drawing.Size(47, 13);
			this.lblGameName.TabIndex = 0;
			this.lblGameName.Text = "Game : -";
			this.grpCheatInfo.BackColor = global::System.Drawing.Color.Black;
			this.grpCheatInfo.Controls.Add(this.lblStatus);
			this.grpCheatInfo.Controls.Add(this.lblStatusLabel);
			this.grpCheatInfo.Controls.Add(this.lblExpirationDate);
			this.grpCheatInfo.Controls.Add(this.lblDaysLeft);
			this.grpCheatInfo.ForeColor = global::System.Drawing.Color.Cyan;
			this.grpCheatInfo.Location = new global::System.Drawing.Point(6, 138);
			this.grpCheatInfo.Name = "grpCheatInfo";
			this.grpCheatInfo.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.grpCheatInfo.Size = new global::System.Drawing.Size(293, 108);
			this.grpCheatInfo.TabIndex = 10;
			this.grpCheatInfo.TabStop = false;
			this.grpCheatInfo.Text = "Cheat Information";
			this.grpCheatInfo.Enter += new global::System.EventHandler(this.grpCheatInfo_Enter);
			this.lblStatus.AutoSize = true;
			this.lblStatus.ForeColor = global::System.Drawing.Color.White;
			this.lblStatus.Location = new global::System.Drawing.Point(51, 79);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(10, 13);
			this.lblStatus.TabIndex = 3;
			this.lblStatus.Text = "-";
			this.lblStatusLabel.AutoSize = true;
			this.lblStatusLabel.ForeColor = global::System.Drawing.Color.Cyan;
			this.lblStatusLabel.Location = new global::System.Drawing.Point(15, 79);
			this.lblStatusLabel.Name = "lblStatusLabel";
			this.lblStatusLabel.Size = new global::System.Drawing.Size(40, 13);
			this.lblStatusLabel.TabIndex = 2;
			this.lblStatusLabel.Text = "Status:";
			this.lblExpirationDate.AutoSize = true;
			this.lblExpirationDate.ForeColor = global::System.Drawing.Color.Cyan;
			this.lblExpirationDate.Location = new global::System.Drawing.Point(15, 29);
			this.lblExpirationDate.Name = "lblExpirationDate";
			this.lblExpirationDate.Size = new global::System.Drawing.Size(108, 13);
			this.lblExpirationDate.TabIndex = 1;
			this.lblExpirationDate.Text = "Dernière Detection : -";
			this.lblDaysLeft.AutoSize = true;
			this.lblDaysLeft.ForeColor = global::System.Drawing.Color.Cyan;
			this.lblDaysLeft.Location = new global::System.Drawing.Point(15, 56);
			this.lblDaysLeft.Name = "lblDaysLeft";
			this.lblDaysLeft.Size = new global::System.Drawing.Size(92, 13);
			this.lblDaysLeft.TabIndex = 0;
			this.lblDaysLeft.Text = "Information Key : -";
			this.chkRememberCheat.AutoSize = true;
			this.chkRememberCheat.ForeColor = global::System.Drawing.Color.White;
			this.chkRememberCheat.Location = new global::System.Drawing.Point(109, 941);
			this.chkRememberCheat.Name = "chkRememberCheat";
			this.chkRememberCheat.Size = new global::System.Drawing.Size(143, 17);
			this.chkRememberCheat.TabIndex = 11;
			this.chkRememberCheat.Text = "Toujours utiliser se cheat";
			this.chkRememberCheat.UseVisualStyleBackColor = true;
			this.button1.BackColor = global::System.Drawing.Color.Black;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(28, 40);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(252, 82);
			this.button1.TabIndex = 12;
			this.button1.Text = "Activer <3";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.Black;
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(28, 138);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(252, 82);
			this.button2.TabIndex = 13;
			this.button2.Text = "Acheter";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.pictureBox3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.pictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new global::System.Drawing.Point(10, 33);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(85, 82);
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new global::System.EventHandler(this.pictureBox3_Click);
			this.pictureBox4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.pictureBox4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new global::System.Drawing.Point(212, 33);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(85, 82);
			this.pictureBox4.TabIndex = 16;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new global::System.EventHandler(this.pictureBox4_Click);
			this.pictureBox5.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox5.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.pictureBox5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox5.Image");
			this.pictureBox5.Location = new global::System.Drawing.Point(113, 33);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new global::System.Drawing.Size(85, 82);
			this.pictureBox5.TabIndex = 17;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new global::System.EventHandler(this.pictureBox5_Click);
			this.groupBox1.BackColor = global::System.Drawing.Color.Black;
			this.groupBox1.Controls.Add(this.pictureBox5);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.pictureBox4);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Cyan;
			this.groupBox1.Location = new global::System.Drawing.Point(282, 576);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(305, 138);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chaîne Youtube";
			this.groupBox2.BackColor = global::System.Drawing.Color.Black;
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.ForeColor = global::System.Drawing.Color.Cyan;
			this.groupBox2.Location = new global::System.Drawing.Point(282, 321);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(305, 249);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Options";
			this.groupBox3.BackColor = global::System.Drawing.Color.Black;
			this.groupBox3.Controls.Add(this.lstCheats);
			this.groupBox3.Controls.Add(this.chkRememberCheat);
			this.groupBox3.ForeColor = global::System.Drawing.Color.Cyan;
			this.groupBox3.Location = new global::System.Drawing.Point(12, 51);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(258, 964);
			this.groupBox3.TabIndex = 21;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "https://darlingch33ts.xyz";
			this.webBrowser1.AllowNavigation = false;
			this.webBrowser1.Location = new global::System.Drawing.Point(599, 61);
			this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.Size = new global::System.Drawing.Size(1293, 948);
			this.webBrowser1.TabIndex = 22;
			this.webBrowser1.TabStop = false;
			this.webBrowser1.Url = new global::System.Uri("https://darlingch33ts.xyz/live-status.html", global::System.UriKind.Absolute);
			this.webBrowser1.DocumentCompleted += new global::System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			this.pictureBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(292, 725);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(290, 290);
			this.pictureBox2.TabIndex = 23;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1904, 1041);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.webBrowser1);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.grpGameInfo);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Loader";
			this.Text = "DarlingCookies";
			base.Load += new global::System.EventHandler(this.Loader_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.grpGameInfo.ResumeLayout(false);
			this.grpGameInfo.PerformLayout();
			this.grpCheatInfo.ResumeLayout(false);
			this.grpCheatInfo.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000014 RID: 20
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ListBox lstCheats;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.GroupBox grpGameInfo;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.GroupBox grpCheatInfo;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.CheckBox chkRememberCheat;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label lblGameName;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label lblVersion;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label lblDaysLeft;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label lblExpirationDate;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label lblStatusLabel;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.PictureBox pictureBox5;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.WebBrowser webBrowser1;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
