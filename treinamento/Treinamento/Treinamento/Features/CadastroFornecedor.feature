Funcionalidade: Cadastro de Fornecedor
	A fim de cadastrar um fornecedor novo
	eu como um usuário
	gostaria de cadastrar um novo fornecedor

Contexto: Autenticação com credenciais válidas
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão de entrar
	Então a tela de formuários deverá ser apresentada

Esquema do Cenário: Cadastro de fornecedores
	Dado que eu esteja na tela de consultar fornecedor
	Quando eu clicar no botão de cadastrar
	E preencher o campo de fornecedor com <Fornecedor>
	E selecionar a opção <TipoDoc>
	E preencher o campo com <Documento>
	E clicar no botão de gravar
	Entao o sistema deverá exibir a mensagem "Empresa cadastrada com sucesso!"
	E exibir o novo fornecedor cadastrado na tabela

	Exemplos:
		| Fornecedor | TipoDoc | Documento          |
		| Teste      | CPF     | 348.625.643-21     |
		| Teste LTDA | CNPJ    | 67.214.041/0001-51 |