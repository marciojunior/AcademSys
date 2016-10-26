using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MO_Turma
    {
        /// <summary>
        /// id da turma
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// id do usuario que criou a turma
        /// </summary>
        public int? idUsu { get; set; }
        /// <summary>
        /// Nome da turma
        /// </summary>
        public string nome { get; set; }
        /// <summary>
        /// local onde iram acontecer as atividades
        /// </summary>
        public string local { get; set; }
        /// <summary>
        /// sexos aceitos na turma
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// numero maximo de alunos;;
        /// </summary>
        public int maxAlunos { get; set; }
        /// <summary>
        /// status da turma, para manter a consistencia de dados
        /// </summary>
        public Status status { get; set; }
    }
}
