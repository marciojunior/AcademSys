using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_DB
    {
        /// <summary>
        /// tabela que ira efetuar operações
        /// </summary>
        public string tabela { get; set; }
        /// <summary>
        ///campos para saber todos os campos que deverão ser inseridos..
        /// </summary>
        public string campos { get; set; }
        /// <summary>
        /// Valores que serão inseridos na tabela..
        /// </summary>
        public string valores { get; set; }
        /// <summary>
        /// Adicionais como WHERE, ORDER BY, GROUP BY, JOIN...
        /// </summary>
        public string adicionais { get; set; }
    }
}
