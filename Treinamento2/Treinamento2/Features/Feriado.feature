@Feriado
Funcionalidade: Feriado
A fim de cadastrar uma data de feriado
eu como usuário
gostaria de cadastrar uma nova data de feriado

Contexto: Contexto: Autenticação com credenciais válidas
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão de entrar
	Então a tela de formuários deverá ser apresentada

Esquema do Cenario: Cadastro de Feriado
	Dado que eu esteja na tela de cadastro de feriado
	Quando eu clicar no botão cadastrar
	E preencher o campo de descrição "<Descricao>"
	E preencher o campo de dia "<Dia>"
	E preencher o campo de mes "<Mes>"
	E preencher o campo de ano "<Ano>"
	E clicar no botão adicionar 
	E exibir a nova data cadastrada na lista
	E eu clicar em gravar
	Entao o sistema deverá apresentar a mensagem "Feriado cadastrado com sucesso."
	E exibir o novo feriado cadastrado na tabela

	Exemplos: 
		| Descricao     | Dia | Mes | Ano  |
		| Revolução	    | 09  | 07  | 2020 |
		| Independência | 07  | 09  | 2020 |