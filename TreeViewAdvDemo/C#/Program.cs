using System;
using System.Windows.Forms;

namespace TreeViewCustomControl
{
    internal sealed class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		private Program()
		{
		}
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}