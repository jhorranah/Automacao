using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.PageObjects
{
    class CadastroFornecedorPage
    {
        public CadastroFornecedorPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "administrador")]
        public IWebElement MenuAdm { get; set; }

        [FindsBy(How = How.Id, Using = "adminUsuarios")]
        public IWebElement MenuUser { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li:nth-child(2) > ul > li:nth-child(5) > a")]
        public IWebElement MenuForn { get; set; }

        [FindsBy(How = How.Id, Using = "btn-cadastrar")]
        public IWebElement BtnCadastrar { get; set; }

        [FindsBy(How = How.Id, Using = "EMP_NOME")]
        public IWebElement InpNome { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cadastro_empresa .form__control-radio:first-child")]
        public IWebElement RadioCnpj { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cadastro_empresa .form__control-radio:last-child")]
        public IWebElement RadioCPF { get; set; }

        [FindsBy(How = How.Id, Using = "EMP_CNPJ")]
        public IWebElement InpDocCNPJ { get; set; }

        [FindsBy(How = How.Id, Using = "EMP_CPF")]
        public IWebElement InpDocCPF { get; set; }

        [FindsBy(How = How.Id, Using = "btn-enviar")]
        public IWebElement BtnEnviar { get; set; }

        [FindsBy(How = How.Id, Using = "inputSuccess")]
        public IWebElement BtnOk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-sm-12.panel__content > table > tbody > tr")]
        public IList<IWebElement> ListaForn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "td:nth-child(1) > span")]
        public IList<IWebElement> ListaTd { get; set; }

        public By Msg = By.CssSelector("#modalErrorSuccess .modal-body #modalText");
    }
}
