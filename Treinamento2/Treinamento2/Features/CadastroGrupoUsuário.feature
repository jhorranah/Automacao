@GrupoUsuário
Funcionalidade: CadastroGrupoUsuário
	A fim de cadastrar um novo grupo de de usuário
	eu como usuário
	gostaria de cadastrar um novo grupo de usuário

Contexto: Autenticação com credenciais válidas
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão de entrar
	Então a tela de formuários deverá ser apresentada

Esquema do Cenario: Cadastro de grupo de usuários
	Dado que eu esteja na tela de grupo de usuário
	Quando eu clicar no botão de cadastrar
	E preencher o campo Grupo com "<Grupo>"
	E preencher o campo Nome com "<Nome>"
	E clicar em adicionar o usuário
	E o sistema exibir o usuário na lista
	E clicar em gravar
	E o sistema exibir a mensagem de "Grupo cadastrado com sucesso"
	Então o sistema deverá apresentar o grupo cadastrado na tabela

	Exemplos:
		| Grupo     | Nome          |
		| Comercial | Administrador |
		| Marketing | Administrador |