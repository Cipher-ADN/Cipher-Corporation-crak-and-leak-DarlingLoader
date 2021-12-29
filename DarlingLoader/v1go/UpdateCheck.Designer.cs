namespace v1go
{
	// Token: 0x02000008 RID: 8
	public partial class UpdateCheck : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00006EFC File Offset: 0x000050FC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006F34 File Offset: 0x00005134
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::v1go.UpdateCheck));
			this.tmrLoad = new global::System.Windows.Forms.Timer(this.components);
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.lblPleaseWait = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.tmrLoad.Interval = 1000;
			this.tmrLoad.Tick += new global::System.EventHandler(this.tmrLoad_Tick);
			this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.pictureBox2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage");
			this.pictureBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new global::System.Drawing.Point(831, 457);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(191, 149);
			this.pictureBox2.TabIndex = 17;
			this.pictureBox2.TabStop = false;
			this.lblPleaseWait.AutoSize = true;
			this.lblPleaseWait.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.lblPleaseWait.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPleaseWait.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.lblPleaseWait.Location = new global::System.Drawing.Point(-29, 1052);
			this.lblPleaseWait.Name = "lblPleaseWait";
			this.lblPleaseWait.Size = new global::System.Drawing.Size(376, 22);
			this.lblPleaseWait.TabIndex = 15;
			this.lblPleaseWait.Text = "Connexion au serveur de DarlingCh33ts.xyz...";
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(-30, -4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(1980, 1089);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1920, 1080);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.lblPleaseWait);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UpdateCheck";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Startup_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000039 RID: 57
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Timer tmrLoad;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label lblPleaseWait;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
