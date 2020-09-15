using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Treinamento2.PageObjects;
using Xunit;

namespace Treinamento2
{
    class FeriadoActions
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly FeriadoPage feriadoPage;

        public FeriadoActions(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            feriadoPage = new FeriadoPage(driver);
        }

        public void EntrarNaTelaFeriado()
        {
            feriadoPage.MenuAdm.Click();
            feriadoPage.MenuDadosForm.Click();
            feriadoPage.MenuTempo.Click();
            feriadoPage.MenuFeriado.Click();
        }

        public void ClicarBotaoCadastrar()
        {
            feriadoPage.BtnCadastrar.Click();

        }

        public void PreencherCampoDescricao(string Descricao)
        {
            feriadoPage.InpDesc.SendKeys(Descricao);
        }

        public void PrencherCampoDia(string dia)
        {
            feriadoPage.InpDia.Click();
            feriadoPage.InpDia.SendKeys(dia);
        }

        public void PrencherCampoMes(string mes)
        {
            feriadoPage.InpMes.Click();
            feriadoPage.InpMes.SendKeys(mes);
        }

        public void PrencherCampoAno(string ano)
        {
            feriadoPage.InpAno.Click();
            feriadoPage.InpAno.SendKeys(ano);
        }

        public void ClicarBotaoAdicionar()
        {
            feriadoPage.BtnAdicionar.Click();
        }

        public void VerificarDataAdicionada(string data)
        {
            bool encontrado = false;
            foreach(var linha in feriadoPage.ListaData)
            {
                var Ldata = linha.FindElement(By.XPath("span[1]"));

                if (Ldata.Text.Equals(data))
                {
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);
        }

        public void ClicarBotaoGravar()
        {
            feriadoPage.BtnGravar.Click();
        }

        public void VerificaMensagemDeSucesso(string mensagem)
        {
            IWebElement Texto = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(feriadoPage.Mensagem));
            Assert.Equal(mensagem, Texto.Text);

            feriadoPage.BtnOk.Click();
            Assert.True(EsperaModalDesaparecer());
        }

        public void ExibeFeriadoNaLista(string Descricao)
        {
            bool encontrado = false;

            foreach(var lin in feriadoPage.ListaFeri)
            {
                var Desc = lin.FindElement(By.XPath("td[1]"));

                if (Desc.Text.Equals(Descricao))
                {
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);
        }
        public bool EsperaModalDesaparecer()
        {
             return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("modalErrorSuccess")));
        }

    }

}

