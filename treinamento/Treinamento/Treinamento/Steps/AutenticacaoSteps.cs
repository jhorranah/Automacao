using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Treinamento.Actions;
using Treinamento.DataModels;
using Xunit;

namespace Treinamento.Steps
{
    [Binding]
    public class AutenticacaoSteps
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private readonly string BaseUrl = "https://demohelpdesk.luxfacta.com/login";

        private readonly AutenticacaoActions actions;

        public AutenticacaoSteps(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            actions = new AutenticacaoActions(driver, wait);
        }


        [Given(@"que eu esteja na tela de autenticação")]
        public void DadoQueEuEstejaNaTelaDeAutenticacao()
        {

            actions.NavegarTelaAutenticacao(BaseUrl);
            actions.VerificarExibicaoCampoUsuario();

        }

        [When(@"eu preencher o campo de usuário com (.*)")]
        public void QuandoEuPreencherOCampoDeUsuarioCom(string Usuario)
        {
            actions.PreencheCampoUsuario(Usuario);
        }

        [When(@"eu preencher o campo de senha com (.*)")]
        public void QuandoEuPreencherOCampoDeSenhaCom(string Senha)
        {
            actions.PreencheCampoSenha(Senha);
        }

        [When(@"eu preencher os campos de usuário e senha")]
        public void QuandoEuPreencherOsCamposDeUsuarioESenha(Table table)
        {
            Usuario usuario = table.CreateInstance<Usuario>();
            actions.PreencheCampoUsuario(usuario.Email);
            actions.PreencheCampoSenha(usuario.Senha);
        }

        [When(@"clicar no botão de entrar")]
        public void QuandoClicarNoBotaoDeEntrar()
        {
            actions.ClicarBotaoEntrar();
        }

        [Then(@"a tela de formuários deverá ser apresentada")]
        public void EntaoATelaDeFormuariosDeveraSerApresentada()
        {
            actions.VerificaExibicaoCampoBusca();
        }
        //-------------------------------------------//


        [Then(@"será exibido em tela a mensagem (.*)")]
        public void EntaoSeraExibidoEmTelaAMensagem(string Mensagem)
        {
            actions.VerificaMensagemErro(Mensagem);
        }


    }
}
