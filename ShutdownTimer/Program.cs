using System;
using System.Windows.Forms;

namespace ShutdownTimer
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002B99 File Offset: 0x00000D99
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Fmain());
		}
	}
}
