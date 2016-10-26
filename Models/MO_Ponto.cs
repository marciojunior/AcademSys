using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_Ponto
    {
        /// <summary>
        /// id do ponto
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// usuario que entrou ou saiu
        /// </summary>
        public int? idUsu { get; set; }
        /// <summary>
        /// data de entrada do usuario
        /// </summary>
        public DateTime dataEntrada { get; set; }
        /// <summary>
        /// data de saida do usuario
        /// </summary>
        public DateTime dataSaida { get; set; }
        /// <summary>
        /// hora que o usuario entrou no sistema
        /// </summary>
        public DateTime hrEntrada { get; set; }
        /// <summary>
        /// horario que ele saiu do sistema..
        /// </summary>
        public DateTime hrSaida { get; set; }
    }
}
