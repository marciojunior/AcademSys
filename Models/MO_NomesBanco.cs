using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_NomesBanco
    {
        #region usuario
        public const string tabelaUsu = "usuario";
        public const string idUsu = "id";
        public const string nomeUsu = "nome";
        public const string loginUsu = "login";
        public const string senhaUsu = "senha";
        public const string statusUsu = "status";
        #endregion

        #region cliente
        public const string tabelaCli = "cliente";
        public const string idCli = "id";
        public const string fkUsuCli = "idUsu";
        public const string matricCli = "matricula";
        public const string nomeCli = "nome";
        public const string telCli = "telefone";
        public const string celCli = "celular";
        public const string sexCli = "sexo";
        public const string cpfCli = "cpf";
        public const string identCli = "identidade";
        public const string ufIdentCli = "ufId";
        public const string emailCli = "email";
        public const string dtNCli = "dataNasc";
        public const string statCli = "status";
        #endregion

        #region adicionais
        public const string tabelaAd = "adicionais";
        public const string idAd = "id";
        public const string fkCliAd = "idCli";
        public const string objAd = "objetivo";
        public const string profAd = "profissao";
        public const string estCivilAd = "estadoCivil";
        public const string empAd = "empresa";
        public const string telEmpAd = "telEmpresa";
        public const string nPaiAd = "nomePai";
        public const string nMaeAd = "nomeMae";
        public const string RespAd = "responsavel";
        public const string telRespAd = "telResponsavel";
        public const string enderAd = "endereco";
        public const string bairroAd = "bairro";
        public const string cepAd = "cep";
        public const string cidadAd = "cidade";
        #endregion

        #region avaliacoes
        public const string tabelaAva = "avaliacoes";
        public const string idAva = "id";
        public const string fkCliAva = "idCli";
        public const string fkUsuAva = "idUsu";
        public const string dtAva = "dataAvaliacao";
        public const string hrAva = "horaAvaliacao";
        #endregion

        #region contas pagar
        public const string tabelaCP = "contasPagar";
        public const string idCP = "id";
        public const string fkUsuCP = "idUsu";
        public const string valCP = "valor";
        public const string motCP = "motivo";
        public const string pagCP = "pago";
        public const string fPagCP = "formaPag";
        #endregion

        #region contas receber
        public const string tabelaCR = "contasReceber";
        public const string idCR = "id";
        public const string fkUsuCR = "idUsu";
        public const string fkCliCR = "idCli";
        public const string valCR = "valor";
        public const string motCR = "motivo";
        public const string fPagCR = "formaPag";
        #endregion

        #region turma
        public const string tabelaTr = "turma";
        public const string idTr = "id";
        public const string fkUsuTr = "idUsu";
        public const string nomTr = "nome";
        public const string locTr = "local";
        public const string sexTr = "sexo";
        public const string maxTr = "maxAlunos";
        public const string statTr = "status";
        #endregion

        #region aluno-turma
        public const string tabelaAlTr = "alunoTurma";
        public const string idAlTr = "id";
        public const string fkCliAlTr = "idCli";
        public const string fkTrAlTr = "idTurma";
        #endregion

        #region agenda
        public const string tabelaAg = "agenda";
        public const string idAg = "id";
        public const string fkUsuAg = "idUsu";
        public const string dtAg = "data";
        public const string tituAg = "titulo";
        public const string descAg = "descricao";
        #endregion

        #region menssalidade
        public const string tabelaMen = "menssalidade";
        public const string idMen = "id";
        public const string fkUsuMen = "idUsu";
        public const string fkCliMen = "idCli";
        public const string dtVencMen = "dataVenc";
        public const string dtPagMen = "dataPago";
        public const string valMen = "valor";
        #endregion

        #region ponto
        public const string tabelaPt = "ponto";
        public const string idPt = "id";
        public const string fkUsuPt = "idUsu";
        public const string dtEPt = "dataEntrada";
        public const string dtSPt = "dataSaida";
        public const string hrEPt = "horaEntrada";
        public const string hrSPt = "horaSaida";
        #endregion

        #region planos
        public const string tabelaPlan = "plano";
        public const string idPlan = "id";
        public const string fkUsuPlan = "idUsu";
        public const string nomePlan = "nome";
        public const string qtdVPlan = "qtdAulas";
        public const string valPlan = "valor";
        public const string statPlan = "status";
        #endregion

        #region Mensalidade Planos
        public const string tabelaMenPlan = "MensalidadePlano";
        public const string idMenPlan = "id";
        public const string fkMenMenPlan = "idMens";
        public const string fkPlanMenPlan = "idPlano";
        #endregion
    }
}
