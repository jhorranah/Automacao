using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2.PageObjects
{
    class CadastroNivelPage
    {
        public CadastroNivelPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "administrador")]
        public IWebElement MenuAdm { get; set; }

        [FindsBy(How = How.Id, Using = "adminDadosOferta")]
        public IWebElement MenuDadosForm { get; set; }

        [[FindsBy(How = How.CssSelector, Using = "li:nth - child(1) > ul > li:nth - child(3) > a")]
        public IWebElement MenuClassificação { get; set; }

        [FindsBy(How =  How.Id, Using = "show-form")]
        public IWebElement BtnCadastrar { get; set; }

        [FindsBy(How = How.Id, Using = "nivel1")]
        public IList<IWebElement> ListaNivel1 { get; set; }

        [FindsBy(How = How.Id, Using = "nivel2")]
        public IList<IWebElement> ListaNivel2 { get; set; }

        [FindsBy(How = How.Id , Using = "nivel3")]
        public IList<IWebElement> ListaNivel3 { get; set; }

        [FindsBy(How = How.Id, Using = "nivel4")]
        public IList<IWebElement> ListaNivel4 { get; set; }
        
        [FindsBy(How = How.Id, Using = "nivel5")]
        public IList<IWebElement> ListaNivel5 { get; set; }

        [FindsBy(How = How.Id, Using = "nivel6")]
        public IList<IWebElement> ListaNivel6 { get; set; }

        [FindsBy(How = How.Id, Using = "add-nivel")]
        public IWebElement BtnAdicionarNivel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#niveis-adicionados > tbody > tr")]
        public IWebElement ListaAdicionados { get; set; }

        [FindsBy(How = How.CssSelector, Using = "btn-enviar")]
        public IWebElement BtnGravar { get; set; }

        [FindsBy(How = How.Id, Using = "#modalErrorSuccess #inputSuccess")]
        public IWebElement BtnOk { get; set; }

        public By Mensagem = By.CssSelector("#modalErrorSuccess #modalText");










    }
}
