using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_Usuario
    {
        /// <summary>
        /// Id do usuário
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// nome para uso do sistema
        /// </summary>
        public string nome { get; set; }
        /// <summary>
        /// Login do usuario no sistema
        /// </summary>
        public string login { get; set; }
        /// <summary>
        /// senha para o validamento do usuario no sistema
        /// </summary>
        public string senha { get; set; }
        /// <summary>
        /// no banco está como int..
        /// </summary>
        public Status status { get; set; }
    }
}
