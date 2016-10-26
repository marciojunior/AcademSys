using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_Plano
    {
        /// <summary>
        /// Id do plano em questão
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// usuario que mecheu no plano.
        /// </summary>
        public int? idUsu { get; set; }
        /// <summary>
        /// Nome do plano
        /// </summary>
        public string nome { get; set; }
        /// <summary>
        /// quantidade de aulas
        /// </summary>
        public int qtdAula { get; set; }
        /// <summary>
        /// Valor do plano 
        /// </summary>
        public double valor { get; set; }
        /// <summary>
        /// Status, manter a consistencia
        /// </summary>
        public Status stat { get; set; }
    }
}
