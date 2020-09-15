
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Treinamento2.PageObjects;
using Xunit;

namespace Treinamento2.Actions
{
    class CadastroCatalogoActions
    {

        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly CadastroCatalogoPage cadastroCatalogoPage;


        public CadastroCatalogoActions(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            cadastroCatalogoPage = new CadastroCatalogoPage(driver);

        }

        public void EntrarTelaCatalogo()
        {
            cadastroCatalogoPage.MenuAdm.Click();
            cadastroCatalogoPage.MenuDadosForm.Click();
            cadastroCatalogoPage.MenuCat.Click();
        }

        public void ClicarBotaoCadastar()
        {
            cadastroCatalogoPage.BtnCadastrar.Click();
        }

        public void PreencherNome(string Nome)
        {
            cadastroCatalogoPage.InpNome.SendKeys(Nome);
        }

        public void PreencherDescrição(string Descricao)
        {
            cadastroCatalogoPage.InpDesc.SendKeys(Descricao);
        }

        public void PreencherFormulario(string Formulario)
        {
            string FormAux = Formulario[0..^1];
            cadastroCatalogoPage.InpForm.SendKeys(FormAux);
            By AutoComp = By.CssSelector("body > div:nth-child(26)");
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AutoComp));


        }

        public void SelecionarFormularioBuscaViva(string Formulario)
        {
            bool encontrado = false;

            foreach (var l in cadastroCatalogoPage.ListaFormulario)
            {
                if (l.Text.Equals(Formulario))
                {
                    l.Click();
                    encontrado = true;
                    break;
                }
                Assert.True(encontrado);
            }

            cadastroCatalogoPage.BtnAdicionar.Click();
        }


        public void VerificaInsercaoLista(string Formulario)
        {
            IList<IWebElement> ListaAdc = _driver.FindElements(cadastroCatalogoPage.ByListaAdc);
            bool encontrado = false;

            foreach (var linha in ListaAdc)
            {
                var lForm = linha.FindElement(By.XPath("td[1]"));

                if (lForm.Text.Equals(Formulario))
                {

                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);

        }


        public void ClicarBotaoGravar()
        {
            cadastroCatalogoPage.BtnGravar.Click();
        }

        public void VerificaMensagemConfirmação(string Mensagem)
        {
            IWebElement Texto = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(cadastroCatalogoPage.Mensagem));
            Assert.Equal(Mensagem, Texto.Text);
        }
    }
}
