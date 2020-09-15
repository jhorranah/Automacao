
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Treinamento2.PageObjects;
using Xunit;

namespace Treinamento2.Actions
{
    class CadastroGrupoUsuarioActions
    {
       private readonly IWebDriver _driver;
    private readonly WebDriverWait _wait;
    private readonly CadastroGrupoUsuarioPage cadastroGrupoUsuarioPage;


    public CadastroGrupoUsuarioActions(IWebDriver driver, WebDriverWait wait)
    {
        _driver = driver;
        _wait = wait;
        cadastroGrupoUsuarioPage = new CadastroGrupoUsuarioPage(driver);
    }
        public void EntrarTelaCadastro()
        {
            cadastroGrupoUsuarioPage.MenuAdm.Click();
            cadastroGrupoUsuarioPage.MenuUser.Click();
            cadastroGrupoUsuarioPage.MenuGrupo.Click();
        }

        public void ClicarBotaoCadastrar()
        {
            cadastroGrupoUsuarioPage.BtnCadastrar.Click();
        }

        public void PreencherCampoNomeGrupo(string Grupo)
        {
            cadastroGrupoUsuarioPage.InpGrupo.SendKeys(Grupo);
        }

        public void PreencherCampoNomeUsuario(string Nome)
        {
            string NomeAux = Nome[0..^1];
            cadastroGrupoUsuarioPage.InpNome.SendKeys(NomeAux);

            By AutoComp = By.CssSelector("body > .autocomplete-suggestions:nth-child(22)");
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AutoComp));
        }

        public void SelecionaUsuarioBuscaViva(string Nome)
        {
            bool encontrado = false;
            foreach (var linha in cadastroGrupoUsuarioPage.ListausuarioAutoComp)
            {
                if (linha.Text.Equals(Nome))
                {
                    linha.Click();
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado, Nome + " não foi encontrado!");
        }
    
        public void ClicarBotãoAdicionar()
        {
            cadastroGrupoUsuarioPage.BtnAdicionar.Click();
        }

        public void VerificaCadastroLista(string Nome)
        {
                bool encontrado = false;
                foreach (var linha in cadastroGrupoUsuarioPage.ListaUser)
                {
                    var LUser = linha.FindElement(By.XPath("td[1]"));

                    if (LUser.Text.Equals(Nome))
                    {
                        encontrado = true;
                        break;
                    }
                }
                Assert.True(encontrado);
            }

        public void ClicarBotaoGravar()
        {
            cadastroGrupoUsuarioPage.BtnGravar.Click();
        }

        public void VerificaMensagemDeCadastro(string Msg)
        {
            IWebElement Texto = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(cadastroGrupoUsuarioPage.Mensagem));
            Assert.Equal(Msg, Texto.Text);

            cadastroGrupoUsuarioPage.BtnOk.Click();
            Assert.True(EsperaModal());

        }
        public void ExibeGrupoNaLista(string Grupo)
        {
            bool encontrado = false;
            foreach(var l in cadastroGrupoUsuarioPage.ListaGrupo)
            {
                var Gp = l.FindElement(By.XPath("td[1]"));

                if (Gp.Text.Equals(Grupo))
                {
                    encontrado = true;
                    break;
                }
            }
            Assert.True(encontrado);
        }

        public bool EsperaModal()
        {
            return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("modalErrorSuccess")));
        }

        }
    }

