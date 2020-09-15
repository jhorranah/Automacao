using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Treinamento.PageObjects;
using Xunit;

namespace Treinamento.Actions
{
    class CadastroFornecedorActions
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly CadastroFornecedorPage cadastroFornecedorPage;

        public CadastroFornecedorActions(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            cadastroFornecedorPage = new CadastroFornecedorPage(driver);

        }

        public void AcessarTelaDeFornecedor()
        {

            cadastroFornecedorPage.MenuAdm.Click();
            cadastroFornecedorPage.MenuUser.Click();
            cadastroFornecedorPage.MenuForn.Click();
        }

        public void ClicarBotaoCadastrar()
        {
            cadastroFornecedorPage.BtnCadastrar.Click();
        }

        public void PreencherCampoFornecedor(string Nome)
        {
            cadastroFornecedorPage.InpNome.SendKeys(Nome);
        }

        public void SelecionarCpfCnpj(String TipoDoc)
        {
            if (TipoDoc.Equals("CPF"))
            {
                cadastroFornecedorPage.RadioCPF.Click();
            }
            else
            {
                cadastroFornecedorPage.RadioCnpj.Click();
            }
        }

        public void PreencherCampoDocumento(string Documento, string TipoDoc)
        {
            if (TipoDoc.Equals("CPF"))
            {
                cadastroFornecedorPage.InpDocCPF.Click();
                cadastroFornecedorPage.InpDocCPF.SendKeys(Documento);
            }
            else
            {
                cadastroFornecedorPage.InpDocCNPJ.Click();
                cadastroFornecedorPage.InpDocCNPJ.SendKeys(Documento);
            }

        }

        public void ClicarBotaoGravar()
        {
            cadastroFornecedorPage.BtnEnviar.Click();
        }

        public void VerificarMensagemConfirmação(string confirmacao)
        {
            IWebElement TextMsg = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(cadastroFornecedorPage.Msg));
            Assert.Equal(confirmacao, TextMsg.Text);

            cadastroFornecedorPage.BtnOk.Click();
        }

        public void VerificaEmpresaCadastrada(string Nome)
        {
            bool encontrado = false;

            foreach (var linha in cadastroFornecedorPage.ListaForn)
            {

                var tdNome = linha.FindElement(By.XPath("td[1]"));

                if (tdNome.Text.Equals(Nome))
                {
                    encontrado = true;
                    break;
                }

            }

            Assert.True(encontrado, Nome + " não foi encontrado na tabela!");
        }

    }
}

