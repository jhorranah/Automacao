using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Treinamento2.DataModels;

namespace Treinamento2
{
    [Binding]
    public class FeriadoSteps
    {
        private FeriadoActions actions;
        private ScenarioContext _context;

        public FeriadoSteps(ScenarioContext injectedContext, IWebDriver driver, WebDriverWait wait)
        {
            actions = new FeriadoActions(driver, wait);
            _context = injectedContext;
        }
               
        [Given(@"que eu esteja na tela de cadastro de feriado")]
        public void DadoQueEuEstejaNaTelaDeCadastroDeFeriado()
        {
            actions.EntrarNaTelaFeriado();
        }
         
        [When(@"eu clicar no botão cadastrar")]
        public void QuandoEuClicarNoBotaoCadastrar()
        {
            actions.ClicarBotaoCadastrar();
        }
        
        [When(@"preencher o campo de descrição ""(.*)""")]
        public void QuandoPreencherOCampoDeDescricao(string Descricao)
        {
            _context["Descricao"] = Descricao;
            actions.PreencherCampoDescricao(Descricao);
        }
        
        [When(@"preencher o campo de dia ""(.*)""")]
        public void QuandoPreencherOCampoDeDia(string dia)
        {
            actions.PrencherCampoDia(dia);
            _context["dia"] = dia;
        }
        
        [When(@"preencher o campo de mes ""(.*)""")]
        public void QuandoPreencherOCampoDeMes(string mes)
        {
            actions.PrencherCampoMes(mes);
            _context["mes"] = mes;
        }
        
        [When(@"preencher o campo de ano ""(.*)""")]
        public void QuandoPreencherOCampoDeAno(string ano)
        {
            actions.PrencherCampoAno(ano);
            _context["ano"] = ano;
        }
        
        [When(@"clicar no botão adicionar")]
        public void QuandoClicarNoBotaoAdicionar()
        {
            actions.ClicarBotaoAdicionar();
        }

        [When(@"exibir a nova data cadastrada na lista")]
        public void QuandoExibirANovaDataCadastradaNaLista()
        {
            string dia = (string)_context["dia"];
            string mes = (string)_context["mes"];
            string ano = (string)_context["ano"];
            string data = dia + "/" + mes + "/" + ano;

            actions.VerificarDataAdicionada(data);
        }

        [When(@"eu clicar em gravar")]
        public void QuandoEuClicarEmGravar()
        {
            actions.ClicarBotaoGravar();
        }

        [Then(@"o sistema deverá apresentar a mensagem ""(.*)""")]
        public void EntaoOSistemaDeveraApresentarAMensagem(string mensagem)
        {

            actions.VerificaMensagemDeSucesso(mensagem);
        }
        
        [Then(@"exibir o novo feriado cadastrado na tabela")]
        public void EntaoExibirONovoFeriadoCadastradoNaTabela()
        {
            string Descricao = (string)_context["Descricao"];
            actions.ExibeFeriadoNaLista(Descricao);
        }
    }
}
