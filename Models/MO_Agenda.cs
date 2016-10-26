using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_Agenda
    {
        /// <summary>
        /// id do agendamento
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// id do usuario que pertence a agenda
        /// </summary>
        public int? idUsu { get; set; }
        /// <summary>
        /// data do agendamento
        /// </summary>
        public DateTime data { get; set; }
        /// <summary>
        /// titulo do agendamento
        /// </summary>
        public string titulo { get; set; }
        /// <summary>
        /// descricao da atividade da agenda
        /// </summary>
        public string descricao { get; set; }
    }
}
