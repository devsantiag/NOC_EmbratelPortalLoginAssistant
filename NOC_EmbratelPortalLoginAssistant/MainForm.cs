/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 20/09/2024
 * Time: 11:38
 */
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NOC_EmbratelPortalLoginAssistant
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
		}
		
		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;
	}
}
