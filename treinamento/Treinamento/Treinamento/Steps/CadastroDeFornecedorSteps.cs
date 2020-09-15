using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Treinamento.Actions;
using Treinamento.DataModels;

namespace Treinamento.Steps
{
    [Binding]
    public class CadastroDeFornecedorSteps
    {[
        private CadastroFornecedorActions actions;

        private ScenarioContext _context;

        public CadastroDeFornecedorSteps(ScenarioContext injectedContext, IWebDriver driver, WebDriverWait wait)
        {
            actions = new CadastroFornecedorActions(driver, wait);
            _context = injectedContext;
        }

        [Given(@"que eu esteja na tela de consultar fornecedor")]
        public void DadoQueEuEstejaNaTelaDeConsultarFornecedor()
        {
            actions.AcessarTelaDeFornecedor();
        }

        [When(@"eu clicar no botão de cadastrar")]
        public void QuandoEuClicarNoBotaoDeCadastrar()
        {
            actions.ClicarBotaoCadastrar();
        }

        [When(@"preencher o campo de fornecedor com (.*)")]
        public void QuandoPreencherOCampoDeFornecedorCom(string Nome)
        {
            actions.PreencherCampoFornecedor(Nome);
            _context["Nome"] = Nome;
        }

        [When(@"selecionar a opção (.*)")]
        public void QuandoSelecionarAOpcao(string TipoDoc)
        {
            actions.SelecionarCpfCnpj(TipoDoc);
            _context["TipoDoc"] = TipoDoc;
        }

        [When(@"preencher o campo com (.*)")]
        public void QuandoPreencherOCampoCom(string Documento)
        {
            string TipoDoc = (string) _context["TipoDoc"];
            actions.PreencherCampoDocumento(Documento, TipoDoc);
        }

        [When(@"clicar no botão de gravar")]
        public void QuandoClicarNoBotaoDeGravar()
        {
            actions.ClicarBotaoGravar();
        }

        [Then(@"o sistema deverá exibir a mensagem ""(.*)""")]
        public void EntaoOSistemaDeveraExibirAMensagem(string confirmação)
        {
            actions.VerificarMensagemConfirmação(confirmação);

        }

        [Then(@"exibir o novo fornecedor cadastrado na tabela")]
        public void EntaoExibirONovoFornecedorCadastradoNaTabela()
        {
            string Nome = (string) _context["Nome"];
            actions.VerificaEmpresaCadastrada(Nome);
        }
    }
}
