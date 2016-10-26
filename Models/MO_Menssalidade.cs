using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_Menssalidade
    {
        /// <summary>
        /// id da menssalidade
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// id do cliente que tem a menssalidade
        /// </summary>
        public int? idCli { get; set; }
        /// <summary>
        /// id do usuário que deu entrada na menssalidade
        /// </summary>
        public int? idUsu { get; set; }
        /// <summary>
        /// data que vence o pagamento da menssalidade
        /// </summary>
        public DateTime dataVenc { get; set; }
        /// <summary>
        /// data em que foi pago..
        /// </summary>
        public DateTime dataPago { get; set; }
        /// <summary>
        /// valor da menssalidade, que foi pago
        /// </summary>
        public double valor { get; set; }
    }
}
