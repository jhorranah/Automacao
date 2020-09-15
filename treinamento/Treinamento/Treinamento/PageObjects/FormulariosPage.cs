using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.PageObjects
{
    class FormulariosPage
    {

        public FormulariosPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "input_buscar")]
        public IWebElement InpBuscar { get; set; }


    }
    }