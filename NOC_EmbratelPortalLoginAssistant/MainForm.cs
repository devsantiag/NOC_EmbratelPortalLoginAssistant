using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace NOC_EmbratelPortalLoginAssistant
{
	public partial class MainForm : Form
	{
		// Controle WebBrowser que será utilizado para navegar no portal.
		private WebBrowser showWebBrowserPortal;
		
		// Caminho do arquivo de credenciais onde login e senha são armazenados.
		private readonly string credentialsFilePath = @"C:\NOC_EmbratelPortalLoginAssistant\NOC_EmbratelPortalLoginAssistant\credentials.txt";
		
		// Dicionário que armazena login e senha para diferentes usuários.
		private Dictionary<string, string> _credenciais;
		
		// FileSystemWatcher para monitorar alterações no arquivo de credenciais.
		private FileSystemWatcher fileWatcher;
		
		// Variáveis que armazenam o login e a senha atuais.
		private string currentLogin;
		private string currentPassword;

		public MainForm()
		{
			InitializeComponent();
			
			// Inicializa o controle WebBrowser e o configura.
			showWebBrowserPortal = new WebBrowser
			{
				Dock = DockStyle.None,
				Top = 26,
				Width = this.ClientSize.Width,
				Height = this.ClientSize.Height - 0,
				ScriptErrorsSuppressed = true // Suprime erros de script da página.
			};
			
			// Adiciona o controle WebBrowser ao formulário.
			this.Controls.Add(showWebBrowserPortal);
			
			// Define o evento que será acionado quando a navegação no WebBrowser for completada.
			showWebBrowserPortal.DocumentCompleted += WebBrowser1DocumentCompleted;

			// Carrega as credenciais a partir do arquivo.
			LoadCredentialsFromFile();
			
			// Inicia o monitoramento do arquivo de credenciais.
			StartFileWatcher();
			
			// Navega até o portal especificado.
			showWebBrowserPortal.Navigate("https://webebt01.embratel.com.br/embratelonline/index.asp");
		}
		

		// Método que carrega as credenciais do arquivo para o dicionário.
		private void LoadCredentialsFromFile()
		{
			_credenciais = new Dictionary<string, string>(); // Inicializa o dicionário.

			// Verifica se o arquivo de credenciais existe.
			if (!File.Exists(credentialsFilePath))
			{
				// Tenta ler o arquivo de credenciais.
				try
				{
					var lines = File.ReadAllLines(credentialsFilePath);
					foreach(var line in lines)
					{
						var parts = line.Split('/'); // Divide a linha em login e senha.
						if(parts.Length == 2)
						{
							var login = parts[0].Trim();
							var senha = parts[1].Trim();
							_credenciais[login] = senha; // Adiciona ao dicionário.
						}
					}
				}
				catch (Exception ex)
				{
					// Exibe mensagem de erro caso ocorra alguma exceção ao carregar as credenciais.
					Directory.CreateDirectory(Path.GetDirectoryName(credentialsFilePath));
					if(!File.Exists(credentialsFilePath))
					{
						MessageBox.Show("O arquivo de credenciais não foi encontrado e será criado automaticamente na pasta 'Documentos'.\n\n" +
						                "Instruções:\n" +
						                "1. Um novo arquivo 'credentials.txt' será criado na pasta 'NOC_EmbratelPortalLoginAssistant' dentro de 'Documentos'.\n" +
						                "2. Você pode editar esse arquivo com suas credenciais utilizando um editor de texto (por exemplo, Bloco de Notas).\n" +
						                "3. Após salvar as alterações, o programa utilizará as novas credenciais automaticamente.\n\n" +
						                "Caso tenha dúvidas, entre em contato com o suporte.",
						                "Arquivo de Credenciais Criado",
						                MessageBoxButtons.OK,
						                MessageBoxIcon.Information);

						File.WriteAllText(credentialsFilePath, "");
					}
				}
			}

			// Outra tentativa de carregar o arquivo de credenciais, em caso de falha anterior.
			try
			{
				var lines = File.ReadAllLines(credentialsFilePath);
				foreach (var line in lines)
				{
					var parts = line.Split('/');
					if (parts.Length == 2)
					{
						var login = parts[0].Trim();
						var senha = parts[1].Trim();
						_credenciais[login] = senha;
					}
				}
			}
			catch (Exception ex)
			{
				// Exibe uma mensagem de erro mais específica caso ocorra uma exceção.
				MessageBox.Show("Erro ao carregar as credenciais: " + ex.Message);
			}
		}

		// Método que inicia o monitoramento do arquivo de credenciais para detectar alterações.
		private void StartFileWatcher()
		{
			fileWatcher = new FileSystemWatcher(Path.GetDirectoryName(credentialsFilePath))
			{
				Filter = Path.GetFileName(credentialsFilePath), // Filtra o arquivo a ser monitorado.
				NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Size // Notifica alterações no conteúdo.
			};
			
			// Define o evento a ser acionado quando o arquivo for alterado.
			fileWatcher.Changed += OnFileChanged;
			fileWatcher.EnableRaisingEvents = true; // Habilita o monitoramento.
		}

		// Método acionado quando o arquivo de credenciais for alterado.
		private void OnFileChanged(object sender, FileSystemEventArgs e)
		{
			System.Threading.Thread.Sleep(200); // Aguarda 200ms para evitar conflitos de leitura/escrita.

			// Atualiza as credenciais no dicionário na thread da interface gráfica.
			Invoke((MethodInvoker)delegate
			       {
			       	LoadCredentialsFromFile();
			       	MessageBox.Show("Credenciais atualizadas"); // Notifica o usuário sobre a atualização.
			       });
		}

		// Método acionado quando a navegação no WebBrowser é completada.
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			WebBrowser webBrowser = sender as WebBrowser;

			// Verifica se a URL atual é a página de login do portal.
			if (e.Url.ToString() == "https://webebt01.embratel.com.br/embratelonline/index.asp")
			{
				// Obtém os elementos HTML da página (campos de login e senha).
				HtmlElement loginElement = webBrowser.Document.GetElementById("login");
				HtmlElement passWordElement = webBrowser.Document.GetElementById("password");

				// Se os campos de login e senha forem encontrados, preenche-os com as credenciais atuais.
				if (loginElement != null && passWordElement != null)
				{
					loginElement.SetAttribute("value", currentLogin);
					passWordElement.SetAttribute("value", currentPassword);

					// Simula o clique no botão de login, caso ele seja encontrado.
					HtmlElement loginButton = showWebBrowserPortal.Document.GetElementById("loginButton");

					if (loginButton != null)
					{
						loginButton.InvokeMember("click");
					}
				}
			}
		}

		// Método para lidar com o clique de um botão de login para determinada empresa.
		private void HandleButtonClick(string login)
		{
			// Verifica se o login informado existe no dicionário de credenciais.
			if (_credenciais.ContainsKey(login))
			{
				currentLogin = login; // Armazena o login atual.
				currentPassword = _credenciais[login]; // Armazena a senha correspondente.
				showWebBrowserPortal.Navigate("https://webebt01.embratel.com.br/embratelonline/index.asp"); // Navega até a página de login.
			}
			else
			{
				// Exibe uma mensagem caso as credenciais não sejam encontradas.
				MessageBox.Show("Credenciais não identificadas.");
			}
		}

		// Métodos acionados pelos cliques dos botões de login para diferentes empresas.
		void TripJslClick(object sender, EventArgs e)
		{
			HandleButtonClick("EOL6442376");
		}

		void TripMovidaClick(object sender, EventArgs e)
		{
			HandleButtonClick("EOL1534997");
		}

		void TripCentauroClick(object sender, EventArgs e)
		{
			HandleButtonClick("EOL4421197");
		}

		void TripIntermedicaClick(object sender, EventArgs e)
		{
			HandleButtonClick("EOL799371");
		}

		// Método que permite ao usuário abrir o arquivo de credenciais para edição.
		void AdminToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				if (File.Exists(credentialsFilePath))
				{
					// Abre o arquivo de credenciais no Bloco de Notas.
					Process.Start("notepad.exe", credentialsFilePath);
				}
				else
				{
					// Exibe uma mensagem caso o arquivo de credenciais não seja encontrado.
					MessageBox.Show("Arquivo de credenciais não encontrado.");
				}
			}
			catch (Exception ex)
			{
				// Exibe uma mensagem caso ocorra um erro ao tentar abrir o arquivo.
				MessageBox.Show("Erro ao abrir o arquivo de credenciais: " + ex.Message);
			}
		}
	}
}
