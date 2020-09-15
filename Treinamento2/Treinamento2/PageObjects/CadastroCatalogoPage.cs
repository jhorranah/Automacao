using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2.PageObjects
{
    class CadastroCatalogoPage
    {
        public CadastroCatalogoPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "administrador")]
        public IWebElement MenuAdm { get; set; }

        [FindsBy(How = How.Id, Using = "adminDadosOferta")]
        public IWebElement MenuDadosForm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#submenu > ul > li:nth-child(1) > ul > li:nth-child(5) > a")]
        public IWebElement MenuCat { get; set; }

        [FindsBy(How = How.Id, Using = "btn-cadastrar")]
        public IWebElement BtnCadastrar { get; set; }

        [FindsBy(How = How.Id, Using = "CAT_NOME")]
        public IWebElement InpNome { get; set; }

        [FindsBy(How = How.Id, Using = "CAT_DESCRICAO")]
        public IWebElement InpDesc { get; set; }

        [FindsBy(How = How.Id, Using = "inputOferta")]
        public IWebElement InpForm { get; set; }

        [FindsBy(How =  How.CssSelector, Using = "body > div:nth-child(26) > div")]
        public IList<IWebElement> ListaFormulario { get; set; }
       
        [FindsBy(How = How.CssSelector, Using = "td.plus > a > span")]
        public IWebElement BtnAdicionar { get; set; }

        [FindsBy(How = How.Id, Using = "btn-enviar")]
        public IWebElement BtnGravar { get; set; }

        public By ByListaAdc = By.CssSelector("#ofertas-adicionadas > tbody > tr");

        [FindsBy(How = How.Id, Using = "inputSuccess")]
        public IWebElement BtnOk { get; set; }


        public By Mensagem = By.CssSelector(" #modalErrorSuccess #modalText"); 

    }
}
