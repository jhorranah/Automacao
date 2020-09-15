@Autenticacao
Funcionalidade: Autenticacao
	A fim de acessar as funcionalidades do sistema do Tessera
	Como um usuário 
	Eu gostaria de realizar a autenticação do sistema

Cenário: Autenticação com credenciais válidas
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão de entrar
	Então a tela de formuários deverá ser apresentada
	