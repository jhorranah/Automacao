using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Treinamento.PageObjects;
using Xunit;

namespace Treinamento.Actions
{
    class AutenticacaoActions
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly AutenticacaoPage autenticacaoPage;
        private readonly FormulariosPage formulariosPage;

        public AutenticacaoActions(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            autenticacaoPage = new AutenticacaoPage(driver);
            formulariosPage = new FormulariosPage(driver);
        }

        public void NavegarTelaAutenticacao(string BaseUrl)
        {
            _driver.Navigate().GoToUrl(BaseUrl);
        }

        public void VerificarExibicaoCampoUsuario()
        {

            Assert.True(autenticacaoPage.InpUsuario.Displayed);
        }

        public void PreencheCampoUsuario(string Usuario)
        {
            autenticacaoPage.InpUsuario.SendKeys(Usuario);
        }

        public void PreencheCampoSenha(string Senha)
        {
            autenticacaoPage.InpSenha.SendKeys(Senha);
        }

        public void ClicarBotaoEntrar()
        {
            autenticacaoPage.BtnEntrar.Click();
        }

        public void VerificaExibicaoCampoBusca()
        {
            Assert.True(formulariosPage.InpBuscar.Displayed);
        }

        public void VerificaMensagemErro(string Mensagem)
        {
            IWebElement Texto = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(autenticacaoPage.ByMsg));
            Assert.Equal(Mensagem, Texto.Text);
        }
    }
}
