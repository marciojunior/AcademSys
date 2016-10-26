using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_AdicionaisCliente
    {
        #region Referente a Tabela de Adicionais de Cliente

        /// <summary>
        /// id do adicional
        /// </summary>
        public int? idAdicional { get; set; }
        /// <summary>
        /// id do cliente
        /// </summary>
        public int? idCli { get; set; }
        /// <summary>
        /// Objetivo do cliente na academia
        /// </summary>
        public string objetivo { get; set; }
        /// <summary>
        /// profissao que exerce
        /// </summary>
        public string profissao { get; set; }
        /// <summary>
        /// casado ou solteiro
        /// </summary>
        public string estadoCivil { get; set; }
        /// <summary>
        /// empresa onde atua
        /// </summary>
        public string empresa { get; set; }
        /// <summary>
        /// telefone da empresa onde atua
        /// </summary>
        public string telEmpresa { get; set; }
        /// <summary>
        /// nome do pai
        /// </summary>
        public string nomePai { get; set; }
        /// <summary>
        /// nome da mae
        /// </summary>
        public string nomeMae { get; set; }
        /// <summary>
        /// atual responsavel(guarda)
        /// </summary>
        public string responsavel { get; set; }
        /// <summary>
        /// telefone do atual responsavel
        /// </summary>
        public string telResponsavel { get; set; }
        /// <summary>
        /// endereço onde mora
        /// </summary>
        public string endereco { get; set; }
        /// <summary>
        /// bairro referente ao endereço
        /// </summary>
        public string bairro { get; set; }
        /// <summary>
        /// cep da rua
        /// </summary>
        public string cep { get; set; }
        /// <summary>
        /// cidade onde reside
        /// </summary>
        public string cidade { get; set; }

        #endregion
    }
}
