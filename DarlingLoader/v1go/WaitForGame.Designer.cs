namespace v1go
{
	// Token: 0x02000004 RID: 4
	public partial class WaitForGame : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000027D0 File Offset: 0x000009D0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002808 File Offset: 0x00000A08
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::v1go.WaitForGame));
			this.tmrLoad = new global::System.Windows.Forms.Timer(this.components);
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.lblPleaseWait = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnCancel = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.tmrLoad.Interval = 1000;
			this.tmrLoad.Tick += new global::System.EventHandler(this.tmrLoad_Tick);
			this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.pictureBox2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage");
			this.pictureBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new global::System.Drawing.Point(860, 456);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(194, 162);
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			this.lblPleaseWait.AutoSize = true;
			this.lblPleaseWait.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.lblPleaseWait.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPleaseWait.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.lblPleaseWait.Location = new global::System.Drawing.Point(0, 1051);
			this.lblPleaseWait.Name = "lblPleaseWait";
			this.lblPleaseWait.Size = new global::System.Drawing.Size(165, 22);
			this.lblPleaseWait.TabIndex = 12;
			this.lblPleaseWait.Text = "Injection en cours...";
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(-1, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(1980, 1089);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.btnCancel.BackColor = global::System.Drawing.Color.DarkRed;
			this.btnCancel.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnCancel.Location = new global::System.Drawing.Point(1782, 1040);
			this.btnCancel.Margin = new global::System.Windows.Forms.Padding(1);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(128, 30);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Stopper l'injection";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1920, 1080);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.lblPleaseWait);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "WaitForGame";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Startup_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000006 RID: 6
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Timer tmrLoad;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label lblPleaseWait;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button btnCancel;
	}
}
