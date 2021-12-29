namespace v1go
{
	// Token: 0x0200000A RID: 10
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000022C9 File Offset: 0x000004C9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000076DC File Offset: 0x000058DC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::v1go.Login));
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.lblUsername = new global::System.Windows.Forms.Label();
			this.btnLogin = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.txtUsername.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.35f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtUsername.Location = new global::System.Drawing.Point(872, 574);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '*';
			this.txtUsername.Size = new global::System.Drawing.Size(321, 38);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.TextChanged += new global::System.EventHandler(this.txtUsername_TextChanged);
			this.lblUsername.AutoSize = true;
			this.lblUsername.BackColor = global::System.Drawing.Color.Black;
			this.lblUsername.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblUsername.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.lblUsername.Location = new global::System.Drawing.Point(686, 574);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new global::System.Drawing.Size(180, 31);
			this.lblUsername.TabIndex = 2;
			this.lblUsername.Text = "Darling User :";
			this.btnLogin.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.btnLogin.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnLogin.Location = new global::System.Drawing.Point(684, 629);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new global::System.Drawing.Size(253, 44);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Let's go !";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
			this.btnCancel.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCancel.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnCancel.Location = new global::System.Drawing.Point(940, 629);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(253, 44);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Annuler";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.pictureBox2.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage");
			this.pictureBox2.Location = new global::System.Drawing.Point(684, 301);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(509, 239);
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			base.AcceptButton = this.btnLogin;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.ClientSize = new global::System.Drawing.Size(1904, 1041);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnLogin);
			base.Controls.Add(this.lblUsername);
			base.Controls.Add(this.txtUsername);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Login";
			this.Text = ".";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Login_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000049 RID: 73
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.TextBox txtUsername;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label lblUsername;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Button btnLogin;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
