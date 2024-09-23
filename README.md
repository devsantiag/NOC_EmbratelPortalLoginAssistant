#### NOC_EmbratelPortalLoginAssistant

O NOC_EmbratelPortalLoginAssistant é uma aplicação Windows Forms desenvolvida para automatizar o login em portais da Embratel, como o Embratel Online, com o objetivo de facilitar o processo de login para múltiplas contas de diferentes empresas.

Funcionalidades
Login Automático: A aplicação realiza o login automático nos portais Embratel preenchendo os campos de login e senha automaticamente e simulando o clique no botão de login.
Suporte para Múltiplas Contas: Atualmente, a aplicação suporta login para as seguintes empresas:
JSL
Movida
Intermédica
Centauro
Interface Simples e Intuitiva: A aplicação possui botões para cada uma das empresas, facilitando o acesso rápido ao portal e login automático.
Arrastar Janela com Mouse: A janela pode ser arrastada ao clicar e segurar em qualquer área dela.
Requisitos
.NET Framework 4.7.2 ou superior
Visual Studio ou SharpDevelop para edição do código-fonte
Instalação
1. Clonando o Repositório
Clone o repositório ou baixe o código-fonte.

bash
Copy code
git clone https://github.com/seu-usuario/NOC_EmbratelPortalLoginAssistant.git
Abra o projeto no Visual Studio ou SharpDevelop.

Restaure as dependências e compile o projeto.

2. Executando o Executável Diretamente
3. 
Se você não deseja compilar o código, pode baixar o executável diretamente e rodá-lo:

*https://github.com/devsantiag/NOC_EmbratelPortalLoginAssistant/blob/main/NOC_EmbratelPortalLoginAssistant/bin/Debug/NOC_EmbratelPortalLoginAssistant.exe*

Baixe o executável diretamente clicando aqui.

Após o download, basta rodar o arquivo NOC_EmbratelPortalLoginAssistant.exe.

Estrutura de Código
Classes Principais
MainForm.cs: Esta classe contém a lógica principal da interface gráfica e a gestão dos botões que realizam o login automático para as diferentes empresas.
PortalWeb.cs: Representa a janela do navegador embutido (WebBrowser) onde o login é realizado automaticamente.
Funções Importantes
OpenPortalAndFillCredentials(string url, string login, string password, bool autoLogin)
Descrição: Abre o portal na URL fornecida e preenche os campos de login e senha automaticamente. Caso o parâmetro autoLogin seja verdadeiro, o botão de login também será clicado automaticamente.
HandleButtonClick(Empresa empresa)
Descrição: Trata o clique no botão de uma das empresas, chamando o método de login com as credenciais corretas.
Como Usar
Abra a aplicação e selecione a empresa desejada (JSL, Movida, Intermédica, Centauro) clicando no botão correspondente.
O portal será aberto em uma nova janela, os campos de login e senha serão preenchidos automaticamente, e o login será realizado.
Exemplo de Uso
Para efetuar login no portal da JSL, o usuário deve clicar no botão "JSL". A aplicação navegará para o portal Embratel Online, preencherá o login e a senha configurados e automaticamente submeterá o formulário.
Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests para melhorias.

Licença
Este projeto está licenciado sob a licença MIT - consulte o arquivo LICENSE para mais detalhes.
