using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2.PageObjects
{
    class FeriadoPage
    {
       
        public FeriadoPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

       // -----------------------------FERIADO --------------------- //

        [FindsBy(How = How.Id, Using = "administrador")]
        public IWebElement MenuAdm { get; set; }

        [FindsBy(How = How.Id, Using = "adminDadosOferta")]
        public IWebElement MenuDadosForm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#submenu > ul > li.dropdown.open > ul > li:nth-child(7)")]
        public IWebElement MenuTempo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li:nth-child(7) > ul >li:last-child")]
        public IWebElement MenuFeriado { get; set; }

        [FindsBy(How = How.Id, Using = "btn-cadastrar")]
        public IWebElement BtnCadastrar { get; set; }

        [FindsBy(How = How.Id, Using = "txt_descricao")]
        public IWebElement InpDesc { get; set; }

        [FindsBy(How = How.Id, Using = "inputDataD")]
        public IWebElement InpDia { get; set; }

        [FindsBy(How = How.Id, Using = "inputDataM")]
        public IWebElement InpMes { get; set; }

        [FindsBy(How = How.Id, Using = "inputDataY")]
        public IWebElement InpAno { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cadastrar > div.modal-body > div:nth-child(3) > a")]
        public IWebElement BtnAdicionar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#show0 > td")]
        public IList<IWebElement> ListaData { get; set; }

        [FindsBy(How = How.Id, Using = "btn-enviar")]
        public IWebElement BtnGravar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#modalErrorSuccess #inputSuccess")]
        public IWebElement BtnOk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-sm-12.panel__content > table > tbody > tr")]
        public IList<IWebElement> ListaFeri { get; set; }

        public By Mensagem = By.CssSelector("#modalErrorSuccess #modalText");














    }
}
