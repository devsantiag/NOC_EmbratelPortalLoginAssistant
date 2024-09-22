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
		private string login = "EOL6442376";
		private string password = "Telcom#123!@#c";
		public MainForm()
		{
			InitializeComponent();
			// Adiciona o manipulador de eventos HandleMouseDown para permitir que o formulário,
			// o painel e o título sejam arrastados com o mouse
			this.MouseDown += new MouseEventHandler(HandleMouseDown);
			this.panel1.MouseDown += new MouseEventHandler(HandleMouseDown);
			this.title.MouseDown += new MouseEventHandler(HandleMouseDown);
		}

		// Manipulador de eventos para permitir que o formulário seja movido ao clicar e arrastar com o mouse
		private void HandleMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;
		
		private void JslClick(object sender, EventArgs e)
		{
			PortalWeb portalWeb = new PortalWeb();
			portalWeb.Show();
		}
		
		private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			WebBrowser webBrowser = sender as WebBrowser;
			if(webBrowser != null)
			{
				HtmlElement loginElement = webBrowser.Document.GetElementById("login");
				HtmlElement passWordElement = webBrowser.Document.GetElementById("password");
				
				if(loginElement != null && passWordElement != null)
				{
					loginElement.SetAttribute("value", login);
					passWordElement.SetAttribute("value", password);
				}
			}
		}
	}
}
