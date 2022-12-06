namespace ShutdownTimer
{
	// Token: 0x02000002 RID: 2
	public partial class Fmain : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002344 File Offset: 0x00000544
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000237C File Offset: 0x0000057C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ShutdownTimer.Fmain));
			this.MSmenu = new global::System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.timerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cancelToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.startToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.daysToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.hoursToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.secondsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new global::System.Windows.Forms.Label();
			this.maskedTextBox1 = new global::System.Windows.Forms.MaskedTextBox();
			this.MSmenu.SuspendLayout();
			base.SuspendLayout();
			this.MSmenu.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.MSmenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.menuToolStripMenuItem,
				this.timerToolStripMenuItem
			});
			this.MSmenu.Location = new global::System.Drawing.Point(0, 117);
			this.MSmenu.Name = "MSmenu";
			this.MSmenu.Size = new global::System.Drawing.Size(284, 24);
			this.MSmenu.TabIndex = 0;
			this.MSmenu.Text = "menuStrip1";
			this.menuToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.aboutToolStripMenuItem,
				this.toolStripMenuItem1,
				this.closeToolStripMenuItem,
				this.toolStripMenuItem2
			});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new global::System.Drawing.Size(41, 20);
			this.menuToolStripMenuItem.Text = "App";
			this.menuToolStripMenuItem.Click += new global::System.EventHandler(this.menuToolStripMenuItem_Click);
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new global::System.Drawing.Size(165, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new global::System.EventHandler(this.aboutToolStripMenuItem_Click);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(162, 6);
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new global::System.Drawing.Size(165, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new global::System.EventHandler(this.closeToolStripMenuItem_Click);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new global::System.Drawing.Size(165, 22);
			this.toolStripMenuItem2.Text = "Close and Cancel";
			this.toolStripMenuItem2.Click += new global::System.EventHandler(this.toolStripMenuItem2_Click);
			this.timerToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cancelToolStripMenuItem,
				this.startToolStripMenuItem,
				this.toolStripMenuItem3,
				this.toolStripMenuItem4
			});
			this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
			this.timerToolStripMenuItem.Size = new global::System.Drawing.Size(50, 20);
			this.timerToolStripMenuItem.Text = "Timer";
			this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
			this.cancelToolStripMenuItem.Size = new global::System.Drawing.Size(129, 22);
			this.cancelToolStripMenuItem.Text = "Cancel";
			this.cancelToolStripMenuItem.Click += new global::System.EventHandler(this.cancelToolStripMenuItem_Click);
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.Size = new global::System.Drawing.Size(129, 22);
			this.startToolStripMenuItem.Text = "Start";
			this.startToolStripMenuItem.Click += new global::System.EventHandler(this.startToolStripMenuItem_Click);
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new global::System.Drawing.Size(126, 6);
			this.toolStripMenuItem4.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.daysToolStripMenuItem,
				this.hoursToolStripMenuItem,
				this.minutesToolStripMenuItem,
				this.secondsToolStripMenuItem
			});
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new global::System.Drawing.Size(129, 22);
			this.toolStripMenuItem4.Text = "Change to";
			this.daysToolStripMenuItem.Name = "daysToolStripMenuItem";
			this.daysToolStripMenuItem.Size = new global::System.Drawing.Size(118, 22);
			this.daysToolStripMenuItem.Text = "Days";
			this.daysToolStripMenuItem.Click += new global::System.EventHandler(this.daysToolStripMenuItem_Click);
			this.hoursToolStripMenuItem.Name = "hoursToolStripMenuItem";
			this.hoursToolStripMenuItem.Size = new global::System.Drawing.Size(118, 22);
			this.hoursToolStripMenuItem.Text = "Hours";
			this.hoursToolStripMenuItem.Click += new global::System.EventHandler(this.hoursToolStripMenuItem_Click);
			this.minutesToolStripMenuItem.Name = "minutesToolStripMenuItem";
			this.minutesToolStripMenuItem.Size = new global::System.Drawing.Size(118, 22);
			this.minutesToolStripMenuItem.Text = "Minutes";
			this.minutesToolStripMenuItem.Click += new global::System.EventHandler(this.minutesToolStripMenuItem_Click);
			this.secondsToolStripMenuItem.Name = "secondsToolStripMenuItem";
			this.secondsToolStripMenuItem.Size = new global::System.Drawing.Size(118, 22);
			this.secondsToolStripMenuItem.Text = "Seconds";
			this.secondsToolStripMenuItem.Click += new global::System.EventHandler(this.secondsToolStripMenuItem_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(102, 22);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(81, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Time";
			this.maskedTextBox1.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.maskedTextBox1.Location = new global::System.Drawing.Point(16, 62);
			this.maskedTextBox1.Mask = "00000000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new global::System.Drawing.Size(253, 35);
			this.maskedTextBox1.TabIndex = 2;
			this.maskedTextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 141);
			base.Controls.Add(this.maskedTextBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.MSmenu);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.MSmenu;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Fmain";
			this.Text = "ShutdownTimer - Seconds";
			base.Load += new global::System.EventHandler(this.Fmain_Load);
			this.MSmenu.ResumeLayout(false);
			this.MSmenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.MenuStrip MSmenu;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.ToolStripMenuItem daysToolStripMenuItem;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ToolStripMenuItem hoursToolStripMenuItem;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.MaskedTextBox maskedTextBox1;
	}
}
