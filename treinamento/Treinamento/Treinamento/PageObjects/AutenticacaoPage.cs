using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.PageObjects
{
    class AutenticacaoPage
    {
        public AutenticacaoPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement InpUsuario { get; set; }

        [FindsBy(How = How.Id, Using = "inputPassword")]
        public IWebElement InpSenha { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.button__login")]
        public IWebElement BtnEntrar { get; set; }

        public By ByMsg = By.CssSelector("#validate > label:nth-child(1)");

        

    }

}
