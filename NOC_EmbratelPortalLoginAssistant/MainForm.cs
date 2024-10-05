using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace NOC_EmbratelPortalLoginAssistant
{
	public partial class MainForm : Form
	{
		private WebBrowser showWebBrowserPortal;
		private readonly string credentialsFilePath = @"C:\NOC_EmbratelPortalLoginAssistant\NOC_EmbratelPortalLoginAssistant\credentials.txt";
		private Dictionary<Empresa, Tuple<string, string>> _credenciais; // Remover readonly

		private enum Empresa
		{
			JSL,
			Movida,
			Intermedica,
			Centauro
		}

		private readonly Dictionary<Empresa, Tuple<string, string>> _defaultCredenciais = new Dictionary<Empresa, Tuple<string, string>>
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
				Dock = DockStyle.None,
				Top = 26,
				Width = this.ClientSize.Width,
				Height = this.ClientSize.Height - 0,
				ScriptErrorsSuppressed = true
			};
			this.Controls.Add(showWebBrowserPortal);
			showWebBrowserPortal.DocumentCompleted += WebBrowser1DocumentCompleted;

			LoadCredentialsFromFile();
			showWebBrowserPortal.Navigate("https://webebt01.embratel.com.br/embratelonline/index.asp");
		}

		private void LoadCredentialsFromFile()
		{
			_credenciais = new Dictionary<Empresa, Tuple<string, string>>();

			if (!File.Exists(credentialsFilePath))
			{
				MessageBox.Show("Arquivo de credenciais não encontrado. Usando credenciais padrão.");
				_credenciais = new Dictionary<Empresa, Tuple<string, string>>(_defaultCredenciais); // Use credenciais padrão
				return;
			}

			try
			{
				var lines = File.ReadAllLines(credentialsFilePath);
				foreach (var line in lines)
				{
					var parts = line.Split('/');
					if (parts.Length == 3)
					{
						var empresa = (Empresa)Enum.Parse(typeof(Empresa), parts[0].Trim());
						var login = parts[1].Trim();
						var senha = parts[2].Trim();
						_credenciais[empresa] = Tuple.Create(login, senha);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar as credenciais: " + ex.Message);
			}
		}

		private void SaveCredentialsToFile()
		{
			{
				try
				{
					var lines = _credenciais.Select(c =>
					                                string.Format("{0} / {1}* ({2})", c.Value.Item1, c.Value.Item2, c.Key));
					File.WriteAllLines(credentialsFilePath, lines);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao salvar as credenciais: " + ex.Message);
				}
			}
		}

			void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
			{
				WebBrowser webBrowser = sender as WebBrowser;

				if (e.Url.ToString() == "https://webebt01.embratel.com.br/embratelonline/index.asp")
				{
					HtmlElement loginElement = webBrowser.Document.GetElementById("login");
					HtmlElement passWordElement = webBrowser.Document.GetElementById("password");

					if (loginElement != null && passWordElement != null)
					{
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
				if (_credenciais.ContainsKey(empresa))
				{
					var credencials = _credenciais[empresa];
					currentLogin = credencials.Item1;
					currentPassword = credencials.Item2;
					showWebBrowserPortal.Navigate("https://webebt01.embratel.com.br/embratelonline/index.asp");
				}
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

			void AdminToolStripMenuItemClick(object sender, EventArgs e)
			{
				

				try
				{
					if (File.Exists(credentialsFilePath))
					{
						Process.Start("notepad.exe", credentialsFilePath);
						 MessageBox.Show("Abrindo o arquivo: {0}", lines);
					}
					else
					{
						MessageBox.Show("Arquivo de credenciais não encontrado.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao abrir o arquivo de credenciais: " + ex.Message);
				}
			}
		}
	}
