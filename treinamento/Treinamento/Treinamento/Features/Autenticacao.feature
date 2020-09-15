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

Esquema do Cenário: Autenticação inváida
	Dado que eu esteja na tela de autenticação
	Quando eu preencher o campo de usuário com <usuario>
	E eu preencher o campo de senha com <senha>
	E clicar no botão de entrar
	Então será exibido em tela a mensagem <mensagem>

	Exemplos:
		| usuario     | senha  | mensagem                                  |
		|             |        | Os campos marcados com * são obrigatórios |
		| sahsdhas    | 687664 | Os campos marcados com * são obrigatórios |
		| asd@asd.com | 4532   | Os campos marcados com * são obrigatórios |