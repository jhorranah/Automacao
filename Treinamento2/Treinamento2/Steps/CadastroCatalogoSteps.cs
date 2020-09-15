using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Treinamento2.Actions;
using Treinamento2.DataModels;
using Treinamento2.PageObjects;

namespace Treinamento2.Features
{
    [Binding]
    public class CadastroCatalogoSteps
    {

        private CadastroCatalogoActions actions;
        private ScenarioContext _context;

        public CadastroCatalogoSteps(ScenarioContext injectedContext, IWebDriver driver, WebDriverWait wait)
        {
            actions = new CadastroCatalogoActions(driver, wait);
            _context = injectedContext;
        }


        [Given(@"que eu esteja na tela de cadastro de catalogo")]
        public void DadoQueEuEstejaNaTelaDeCadstroDeCatalogo()
        {
            actions.EntrarTelaCatalogo();
        }
        
        [When(@"eu clicar em cadastrar")]
        public void QuandoEuClicarEmCadastrar()
        {
            actions.ClicarBotaoCadastar();
        }
        
        [When(@"preencher o campo Nome e Descrição")]
        public void QuandoPreencherOCampoNomeEDescricao(Table table)
        {
            Catalogo catalogo = table.CreateInstance<Catalogo>();
            actions.PreencherNome(catalogo.Nome);
            actions.PreencherDescrição(catalogo.Descrição);
        }
        
        [When(@"selecionar um formulário")]
        public void QuandoSelecionarUmFormulario(Table table)
        {

            IEnumerable<Catalogo2> catalogos = table.CreateSet<Catalogo2>();
            
            foreach (Catalogo2 cat in catalogos)
            {
                actions.PreencherFormulario(cat.Formulario);
                actions.SelecionarFormularioBuscaViva(cat.Formulario);
                actions.VerificaInsercaoLista(cat.Formulario);
            }                
            
        }
               
        [When(@"clicar no botão gravar")]
        public void QuandoClicarNoBotaoGravar()
        {
            actions.ClicarBotaoGravar();
        }
        
        [Then(@"o sistema irá exibir a mensagem ""(.*)""")]
        public void EntaoOSistemaIraExibirAMensagem(string Mensagem)
        {
            actions.VerificaMensagemConfirmação(Mensagem);
        }
    }
}
