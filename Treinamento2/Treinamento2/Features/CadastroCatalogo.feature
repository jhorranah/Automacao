@Catalogo
Funcionalidade: CadastroCatalogo
	Afim de categorizar os formulários de atendimento
	eu como administrador
	eu gostaria de cadastrar catálogos
	

Contexto: Autenticação com credenciais válidas
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão de entrar
	Então a tela de formuários deverá ser apresentada
	
Cenario: Cadastro de catalogo
	Dado que eu esteja na tela de cadastro de catalogo
	Quando eu clicar em cadastrar
	E preencher o campo Nome e Descrição
		| Nome           | Descricao     |
		| Catalogo Teste 1 | Desc Catalogo |
	E selecionar um formulário
		| Formulário                 |
		| Antecipação do 13º salário |
		| Solicitação de Férias		 |
	E clicar no botão gravar
	Entao o sistema irá exibir a mensagem "Catálogo cadastrado com sucesso."
