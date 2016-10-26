using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_ContasReceber
    {
        /// <summary>
        /// id da conta;;
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// id do usuario que cadatrou a conta recebida
        /// </summary>
        public int? idUsu { get; set; }
        /// <summary>
        /// id do cliente q pagou, ou nao..
        /// </summary>
        public int? idCli { get; set; }
        /// <summary>
        /// valor que entrou..
        /// </summary>
        public double valor { get; set; }
        /// <summary>
        /// motivo do pagamento
        /// </summary>
        public string motivo { get; set; }
        /// <summary>
        /// Forma de pagamento..
        /// </summary>
        public FormaP fp { get; set; }
    }
}
