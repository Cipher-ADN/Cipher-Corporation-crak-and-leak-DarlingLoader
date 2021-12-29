namespace v1go
{
	// Token: 0x02000006 RID: 6
	public partial class PleaseWait : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00006610 File Offset: 0x00004810
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006648 File Offset: 0x00004848
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::v1go.PleaseWait));
			this.lblPleaseWait = new global::System.Windows.Forms.Label();
			this.tmrLoad = new global::System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.lblPleaseWait.AutoSize = true;
			this.lblPleaseWait.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.lblPleaseWait.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPleaseWait.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.lblPleaseWait.Location = new global::System.Drawing.Point(0, 1051);
			this.lblPleaseWait.Name = "lblPleaseWait";
			this.lblPleaseWait.Size = new global::System.Drawing.Size(330, 22);
			this.lblPleaseWait.TabIndex = 2;
			this.lblPleaseWait.Text = "Verifications de la dernière mise à jour...";
			this.lblPleaseWait.Click += new global::System.EventHandler(this.lblPleaseWait_Click);
			this.tmrLoad.Interval = 1000;
			this.tmrLoad.Tick += new global::System.EventHandler(this.tmrLoad_Tick);
			this.pictureBox1.Location = new global::System.Drawing.Point(-1, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(1980, 1089);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);			this.pictureBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new global::System.Drawing.Point(860, 456);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(191, 149);
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 21, 26);
			base.ClientSize = new global::System.Drawing.Size(1920, 1080);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.lblPleaseWait);
			base.Controls.Add(this.pictureBox1);
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PleaseWait";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Startup_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002C RID: 44
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label lblPleaseWait;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Timer tmrLoad;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
