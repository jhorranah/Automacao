using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2.PageObjects
{
    class CadastroGrupoUsuarioPage
    {

        public CadastroGrupoUsuarioPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "administrador")]
        public IWebElement MenuAdm { get; set; }

        [FindsBy(How = How.Id, Using = "adminUsuarios")]
        public IWebElement MenuUser { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li:nth-child(2) > ul > li:nth-child(7) > a")]
        public IWebElement MenuGrupo { get; set; }

        [FindsBy (How = How.Id, Using = "btn-cadastrar")]
        public IWebElement BtnCadastrar { get; set; }

        [FindsBy(How = How.Id, Using = "grupo")]
        public IWebElement InpGrupo { get; set; }

        [FindsBy(How = How.Id, Using = "nome")]
        public IWebElement InpNome { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(22) > div")]
        public IList<IWebElement> ListausuarioAutoComp { get; set; }

        [FindsBy(How = How.Id, Using = "add-grupo")]
        public IWebElement BtnAdicionar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#usuarios-adicionados > tbody tr:last-child")]
        public IList<IWebElement> ListaUser { get; set; }

        [FindsBy(How = How.Id, Using = "btn-enviar")]
        public IWebElement BtnGravar { get; set; }

        [FindsBy(How = How.Id, Using = "inputSuccess")]
        public IWebElement BtnOk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.col-sm-12.panel__content > table > tbody > tr")]
        public IList<IWebElement> ListaGrupo { get; set; }

        public By Mensagem = By.CssSelector("#modalErrorSuccess #modalText");




    }
}
