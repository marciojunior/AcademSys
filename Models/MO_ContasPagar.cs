using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public enum Pago
    {
        sim,
        nao
    }

    public enum FormaP
    {
        dinheiro,
        cheque,
        cartão
    }

    public class MO_ContasPagar
    {
        /// <summary>
        /// id da conta
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// id do usuario q cadastrou a conta
        /// </summary>
        public int? idUsu { get; set; }
        /// <summary>
        /// valor que esta sendo cobrado
        /// </summary>
        public double valor { get; set; }
        /// <summary>
        /// motivo deste valor.. 
        /// </summary>
        public string motivo { get; set; }
        /// <summary>
        /// Se ja foi pago ou não, no banco int.
        /// </summary>
        public Pago pag { get; set; }
        /// <summary>
        /// Forma de pagamento
        /// </summary>
        public FormaP fp { get; set; }
    }
}
