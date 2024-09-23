using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace NOC_EmbratelPortalLoginAssistant
{
	public partial class MainForm : Form
	{
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
		}

		// Método genérico para abrir o PortalWeb e preencher login e senha
		private void OpenPortalAndFillCredentials(string url, string login, string password, bool autoLogin = false)
		{
			currentLogin = login;
			currentPassword = password;

			PortalWeb portalWeb = new PortalWeb();
			portalWeb.WebBrowser.DocumentCompleted += (sender, e) => WebBrowser_DocumentCompleted(sender, e, autoLogin);
			portalWeb.WebBrowser.Navigate(url);
			portalWeb.Show();
		}

		// Evento para preencher os campos de login e senha e submeter o formulário, se autoLogin for verdadeiro
		private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e, bool autoLogin)
		{
			WebBrowser webBrowser = sender as WebBrowser;
			if (webBrowser != null)
			{
				HtmlElement loginElement = webBrowser.Document.GetElementById("login");
				HtmlElement passWordElement = webBrowser.Document.GetElementById("password");

				if (loginElement != null && passWordElement != null)
				{
					// Preenche os campos de login e senha
					loginElement.SetAttribute("value", currentLogin);
					passWordElement.SetAttribute("value", currentPassword);

					if (autoLogin)
					{
						// Simula o clique no botão de login se autoLogin for verdadeiro
						HtmlElement loginButton = webBrowser.Document.GetElementById("loginButton"); // Substitua pelo ID correto
						if (loginButton != null)
						{
							loginButton.InvokeMember("click");
						}
					}
				}
			}
		}
		
		private void HandleButtonClick(Empresa empresa)
		{
			var credentials = _credenciais[empresa];
			OpenPortalAndFillCredentials("https://webebt01.embratel.com.br/embratelonline/index.asp", credentials.Item1, credentials.Item2, true);
		}

		// Eventos dos botões
		void ButtonJSLClick(object sender, EventArgs e)
		{
			HandleButtonClick(Empresa.JSL);
		}

		void ButtonIntermedicaClick(object sender, EventArgs e)
		{
			HandleButtonClick(Empresa.Intermedica);
		}

		void ButtonMovidaClick(object sender, EventArgs e)
		{
			HandleButtonClick(Empresa.Movida);
		}

		void ButtonCentauroClick(object sender, EventArgs e)
		{
			HandleButtonClick(Empresa.Centauro);
		}
	}
}
