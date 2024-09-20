/*
 * Date: 20/09/2024
 * Time: 11:38
 */
using System;
using System.Windows.Forms;

namespace NOC_EmbratelPortalLoginAssistant
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
