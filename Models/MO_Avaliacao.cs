using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_Avaliacao
    {
        /// <summary>
        /// Id da avaliação
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// Id do cliente avaliado
        /// </summary>
        public int? idCli { get; set; }
        /// <summary>
        /// id do usuario q marcou a avaliacao
        /// </summary>
        public int? idUsu { get; set; }
        /// <summary>
        /// data da avaliacao
        /// </summary>
        public string data { get; set; }
        /// <summary>
        /// hora da avaliacao
        /// </summary>
        public string hora { get; set; }
    }
}
