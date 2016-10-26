using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_AlunoTurma
    {
        /// <summary>
        /// id da relação entre as duas tabelas
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// id do cliente que vai para alguma turma
        /// </summary>
        public int idCli { get; set; }
        /// <summary>
        /// id da turma que o cliente ira pertencer
        /// </summary>
        public int idTurma { get; set; }
    }
}
