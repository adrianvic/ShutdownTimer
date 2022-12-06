using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ShutdownTimer
{
	// Token: 0x02000002 RID: 2
	public partial class Fmain : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Fmain()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000207F File Offset: 0x0000027F
		private void menuToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002082 File Offset: 0x00000282
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000208B File Offset: 0x0000028B
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Application.Exit();
			Process.Start("CMD.exe", "/C shutdown -a");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020A4 File Offset: 0x000002A4
		private void Fmain_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020A8 File Offset: 0x000002A8
		private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.type == "seconds")
			{
				Process.Start("CMD.exe", "/C shutdown -s -t " + this.maskedTextBox1.Text);
			}
			if (this.type == "minutes")
			{
				if (int.Parse(this.maskedTextBox1.Text) >= 1666667)
				{
					MessageBox.Show("Max. value on minutes are 1666666", "Error", MessageBoxButtons.OK);
					return;
				}
				int num = int.Parse(this.maskedTextBox1.Text) * 60;
				Process.Start("CMD.exe", "/C shutdown -s -t " + num);
			}
			if (this.type == "hours")
			{
				if (int.Parse(this.maskedTextBox1.Text) >= 27778)
				{
					MessageBox.Show("Max. value on hours are 27777", "Error", MessageBoxButtons.OK);
					return;
				}
				int num2 = int.Parse(this.maskedTextBox1.Text) * 3600;
				Process.Start("CMD.exe", "/C shutdown -s -t " + num2);
			}
			if (this.type == "days")
			{
				if (int.Parse(this.maskedTextBox1.Text) >= 1158)
				{
					MessageBox.Show("Max. value on days are 1157", "Error", MessageBoxButtons.OK);
				}
				else
				{
					int num3 = int.Parse(this.maskedTextBox1.Text) * 86400;
					Process.Start("CMD.exe", "/C shutdown -s -t " + num3);
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002260 File Offset: 0x00000460
		private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("CMD.exe", "/C shutdown -a");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002273 File Offset: 0x00000473
		private void secondsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.type = "seconds";
			Form.ActiveForm.Text = "ShutdownTimer - Seconds";
			this.maskedTextBox1.Mask = "00000000";
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022A2 File Offset: 0x000004A2
		private void minutesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.type = "minutes";
			Form.ActiveForm.Text = "ShutdownTimer - Minutes";
			this.maskedTextBox1.Mask = "0000000";
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022D1 File Offset: 0x000004D1
		private void hoursToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.type = "hours";
			Form.ActiveForm.Text = "ShutdownTimer - Hours";
			this.maskedTextBox1.Mask = "00000";
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002300 File Offset: 0x00000500
		private void daysToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.type = "days";
			Form.ActiveForm.Text = "ShutdownTimer - Days";
			this.maskedTextBox1.Mask = "0000";
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000232F File Offset: 0x0000052F
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("By Adrien. Follow TheCoolCat! on YouTube", "About", MessageBoxButtons.OK);
		}

		// Token: 0x04000001 RID: 1
		private string type = "seconds";

		// Token: 0x04000002 RID: 2
		private string shutdownCommand = "/C shutdown -s -t ";
	}
}
