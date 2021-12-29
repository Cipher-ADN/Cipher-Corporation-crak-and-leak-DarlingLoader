using System;
using System.Windows.Forms;

namespace v1go
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x06000062 RID: 98 RVA: 0x000022EE File Offset: 0x000004EE
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new PleaseWait());
		}
	}
}
