/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 22/09/2024
 * Time: 14:13
 */

using System.Windows.Forms;

namespace NOC_EmbratelPortalLoginAssistant
{
	public partial class PortalWeb : Form
	{
		private WebBrowser webBrowser;

		public PortalWeb()
		{
			InitializeComponent();
			// Cria uma nova instância de WebBrowser
			webBrowser = new WebBrowser
			{
				Dock = DockStyle.Fill,
				ScriptErrorsSuppressed = true
			};
			
			this.Controls.Add(webBrowser);
			
			// Navegar para a URL desejada
			webBrowser.Navigate("https://webebt01.embratel.com.br/embratelonline/index.asp");
		}
//		Responsável por permitir o acesso ao WebBrowser
		public WebBrowser WebBrowser
		{
			get { return webBrowser; }
		}
	}
}