using System;
using System.Windows.Forms;

namespace KFC_FASTFOOD
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Debug.WriteLine(lib.cls_EnCrypt.DecryptMD5("ynmBNWanNb/lHyVvA35l7A=="));
			Application.Run(new Forms.frm_Splash());

		}
	}
}
