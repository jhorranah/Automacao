@Nivel
Funcionalidade: CadastroNivel
	A fim de cadastrar a classificação de formulario
	eu como administrador
	gostaria de cadastrar uma classificação de formulário

Contexto: Autenticação com credenciais válidas
	Dado que eu esteja na tela de autenticação
	Quando eu preencher os campos de usuário e senha
		| Email           | Senha     |
		| admin@admin.com | Senha1234 |
	E clicar no botão de entrar
	Então a tela de formuários deverá ser apresentada

Esquema do Cenario: Cadastro de classificação de formulario
	Dado que eu esteja na tela de cadastro classificação
	E clique em cadastrar
	E selecionar o nível <nivel>
		| Nivel 1 | Nivel 2 | Nivel 3 | Nivel 4 | Nivel 5 | Nivel 6 |
		| Teste 1 | Teste 2 | Teste 3 | Teste 4 | Teste 5 | Teste 6 |
	E preencher o campo nível "<Nome>"
	E clicar em adicionar nível
	E clicar em gravar
	Então o sistema deverá exibir a mensagem "Classificação cadastrada com sucesso."

	Exemplos: 
		| Nivel | Nome    |
		| 1     | Teste 1 |
		| 2     | Teste 2 |
		| 3     | Teste 3 |
		| 4     | Teste 4 |
		| 5     | Teste 5 |
		| 6     | Teste 6 |