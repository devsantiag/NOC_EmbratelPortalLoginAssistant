/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 23/09/2024
 * Time: 13:33
 */

/*
 * 
 * Sobre: págia responsável por adicionar informações (novos logins e senhas) na ferramenta principal de acesso ao portal
 * 
 * db - NOC_EmbratelPortalAccess_Credenciais 
 * 
 */

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace NOC_EmbratelPortalLoginAssistant
{
	public partial class Admin : Form
	{
		public Admin()
		{
			InitializeComponent();
			
		}
		void AdminLoad(object sender, EventArgs e)
		{
//			var strConnection = "server=localhost;uid=aulas; darabase=NOC_EmbratelPortalAccess_Credenciais";
//			var conexao = new MySqlConnection(strConnection);
//			conexao.Open();
		}
	}
}
