using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public enum Status
    {
        ativo,
        inativo
    }

    public class MO_Cliente
    {
        #region Referente a Tabela de Clientes

        /// <summary>
        /// Id do cliente
        /// </summary>
        public int? idCli { get; set; }
        /// <summary>
        /// id do usuário que adicionou o cliente
        /// </summary>
        public int? idUsu { get; set; }
        /// <summary>
        /// matricula devida do cliente
        /// </summary>
        public int? matricula { get; set; }
        /// <summary>
        /// nome do cliente
        /// </summary>
        public string nome { get; set; }
        /// <summary>
        /// telefone fixo do cliente
        /// </summary>
        public string telefone { get; set; }
        /// <summary>
        /// celular do cliente
        /// </summary>
        public string celular { get; set; }
        /// <summary>
        /// sexo do cliente, string mais no banco char
        /// </summary>
        public string sexo { get; set; }
        /// <summary>
        /// cpf de algum cliente -> retirar pontos
        /// </summary>
        public string cpf { get; set; }
        /// <summary>
        /// identidade do cliente(se tiver)
        /// </summary>
        public string identidade { get; set; }
        /// <summary>
        /// uf de onde foi expedida a identidade
        /// </summary>
        public string ufIdentidade { get; set; }
        /// <summary>
        /// email do cliente.. talvez fazer notificãções para os clientes..
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// data de nasciemento..
        /// </summary>
        public DateTime nasc { get; set; }
        /// <summary>
        /// no banco int(converte na hora de salvar)
        /// </summary>
        public Status status { get; set; }

        #endregion
    }
}
