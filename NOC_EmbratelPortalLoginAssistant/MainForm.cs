using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NOC_EmbratelPortalLoginAssistant
{
	public partial class MainForm : Form
	{
		private WebBrowser showWebBrowserPortal;
		
		private enum Empresa
		{
			JSL,
			Movida,
			Intermedica,
			Centauro
		}
		
		private readonly Dictionary<Empresa, Tuple<string, string>> _credenciais = new Dictionary<Empresa, Tuple<string, string>>
		{
			{ Empresa.JSL, Tuple.Create("EOL6442376", "Telcom#123!@#c") },
			{ Empresa.Movida, Tuple.Create("EOL1534997", "Telcom#123!@#") },
			{ Empresa.Intermedica, Tuple.Create("EOL799371", "Telcom#123!@#") },
			{ Empresa.Centauro, Tuple.Create("EOL4421197", "Telcom#123!@#") }
		};
		
		private string currentLogin;
		private string currentPassword;

		public MainForm()
		{
			InitializeComponent();
			showWebBrowserPortal = new WebBrowser
			{
				Dock = DockStyle.None, // Usar None para permitir ajuste manual da posição
				Top = 26, // Ajusta o controle 50 pixels para baixo
				Width = this.ClientSize.Width, // Tamanho da largura do formulário
				Height = this.ClientSize.Height - 0, // Tamanho ajustado, descontando 50px do Top
				ScriptErrorsSuppressed = true
			};
			this.Controls.Add(showWebBrowserPortal);
			showWebBrowserPortal.DocumentCompleted += WebBrowser1DocumentCompleted;
			
			showWebBrowserPortal.Navigate("https://webebt01.embratel.com.br/embratelonline/index.asp");
		}

		// Evento para preencher os campos de login e senha e submeter o formulário, se autoLogin for verdadeiro
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			WebBrowser webBrowser = sender as WebBrowser;
			
			if (e.Url.ToString() == "https://webebt01.embratel.com.br/embratelonline/index.asp")
			{
				HtmlElement loginElement = webBrowser.Document.GetElementById("login");
				HtmlElement passWordElement = webBrowser.Document.GetElementById("password");

				if (loginElement != null && passWordElement != null)
				{
					// Preenche os campos de login e senha
					loginElement.SetAttribute("value", currentLogin);
					passWordElement.SetAttribute("value", currentPassword);
					
					
					HtmlElement loginButton = showWebBrowserPortal.Document.GetElementById("loginButton");
					
					if (loginButton != null)
					{
						loginButton.InvokeMember("click");
					}
				}
			}
		}
		
		private void HandleButtonClick(Empresa empresa)
		{
			var credencials = _credenciais[empresa];
			currentLogin = credencials.Item1;
			currentPassword = credencials.Item2;
			
			showWebBrowserPortal.Navigate("https://webebt01.embratel.com.br/embratelonline/index.asp");
		}
		
		void TripJslClick(object sender, EventArgs e)
		{
			HandleButtonClick(Empresa.JSL);
		}
		void TripMovidaClick(object sender, EventArgs e)
		{
			HandleButtonClick(Empresa.Movida);
		}
		void TripCentauroClick(object sender, EventArgs e)
		{
			HandleButtonClick(Empresa.Centauro);
		}
		void TripIntermedicaClick(object sender, EventArgs e)
		{
			HandleButtonClick(Empresa.Intermedica);
		}
		
//		Página responsável por editar login
		void AdminToolStripMenuItemClick(object sender, EventArgs e)
		{
			Admin admin = new Admin();
			admin.Show();
		}
	}
}