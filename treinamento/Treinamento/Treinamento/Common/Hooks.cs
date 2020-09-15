using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Treinamento.Common
{   
    [Binding]
    class Hooks
    {
        private IObjectContainer _objectContainer;
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public Hooks(IObjectContainer objectContainer) 
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void NovoDriver()
        {
            _driver = new ChromeDriver();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _objectContainer.RegisterInstanceAs(_driver);
            _objectContainer.RegisterInstanceAs(_wait);
        }

        [AfterScenario]

        public void QuitDriver()
        {
            _driver?.Quit();
        }
    }
}
