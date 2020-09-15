using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Treinamento2.Actions;

namespace Treinamento2
{
    [Binding]
    public class CadastroGrupoUsuarioSteps
    {
        private CadastroGrupoUsuarioActions actions;
        private ScenarioContext _context;
        public CadastroGrupoUsuarioSteps(ScenarioContext injectedContext, IWebDriver driver, WebDriverWait wait)
        {
            actions = new CadastroGrupoUsuarioActions(driver, wait);
            _context = injectedContext;
        }


        [Given(@"que eu esteja na tela de grupo de usuário")]
        public void DadoQueEuEstejaNaTelaDeGrupoDeUsuario()
        {
            actions.EntrarTelaCadastro();
        }

        [When(@"eu clicar no botão de cadastrar")]
        public void QuandoEuClicarNoBotaoDeCadastrar()
        {
            actions.ClicarBotaoCadastrar();
        }

        [When(@"preencher o campo Grupo com ""(.*)""")]
        public void QuandoPreencherOCampoGrupo(string Grupo)
        {
            _context["Grupo"] = Grupo;
            actions.PreencherCampoNomeGrupo(Grupo);
        }

        [When(@"preencher o campo Nome com ""(.*)""")]
        public void QuandoPreencherOCampoNome(string Nome)
        {
            _context["Nome"] = Nome;
            actions.PreencherCampoNomeUsuario(Nome);
            actions.SelecionaUsuarioBuscaViva(Nome);
        }

        [When(@"clicar em adicionar o usuário")]
        public void QuandoClicarEmAdicionarOUsuario()
        {
            actions.ClicarBotãoAdicionar();
        }

        [When(@"o sistema exibir o usuário na lista")]
        public void QuandoOSistemaExibirOUsuarioNaLista()
        {
            string Nome = (string)_context["Nome"];
            actions.VerificaCadastroLista(Nome);
        }

        [When(@"clicar em gravar")]
        public void QuandoClicarEmGravar()
        {
            actions.ClicarBotaoGravar();
        }

        [When(@"o sistema exibir a mensagem de ""(.*)""")]
        public void QuandoOSistemaExibirAMensagemDe(string Mensagem)
        {
            actions.VerificaMensagemDeCadastro(Mensagem);
        }

        [Then(@"o sistema deverá apresentar o grupo cadastrado na tabela")]
        public void EntaoOSistemaDeveraApresentarOGrupoCadastradoNaTabela()
        {
            string Grupo = (string)_context["Grupo"];
            actions.ExibeGrupoNaLista(Grupo);

        }
    }
}
