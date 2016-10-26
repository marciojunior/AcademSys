using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_MensalidadePlano
    {
        /// <summary>
        /// id da relação
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// id da mensalidade proposta
        /// </summary>
        public int? idMens { get; set; }
        /// <summary>
        /// id do plano proposto
        /// </summary>
        public int? idPlano { get; set; }
    }
}
