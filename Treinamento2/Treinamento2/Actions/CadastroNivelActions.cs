using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Treinamento2.PageObjects;

namespace Treinamento2.Actions
{
    class CadastroNivelActions
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly CadastroNivelPage cadastroNivelPage;


        public CadastroNivelActions(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;

        }

    }

    
}
