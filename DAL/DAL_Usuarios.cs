using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
    public class DAL_Usuarios : IRepository
    {
        string sql;
        List<MO_Usuario> lstUsu = new List<MO_Usuario>();
        MO_Usuario usu = new MO_Usuario();
        MO_DB db;
        DAL_MontaComando monta = new DAL_MontaComando();

        /// <summary>
        /// Inserir os dados, montando dinamicamente para não ficar mechendo com sql toda hora e evitar erros de digitação
        /// </summary>
        /// <param name="user">passando todas as informações necessarias de usuario para inserilo no banco de dados..</param>
        public void inserirDados(MO_Usuario user)
        {
            db = new MO_DB();
            //montar os campos
            if (user != null)
            {
                db.tabela = MO_NomesBanco.tabelaUsu;
                db.campos = string.Format("{0},{1},{2},{3},{4}",
                    MO_NomesBanco.idUsu, MO_NomesBanco.nomeUsu, MO_NomesBanco.loginUsu, MO_NomesBanco.senhaUsu, MO_NomesBanco.statusUsu);
                db.valores = string.Format("null,'{0}','{1}','{2}',{3}", user.nome, user.login, user.senha, (int)user.status);
                //montar sql e depois executa-lo no banco
                sql = monta.montaInserir(db);
                executar(sql);
            }
        }

        /// <summary>
        /// Atualiza algum usuario, tambem sever pra excluir, pois usuario não se exclui, ele se torna inativo(MANTER A CONSISTENCIA DOS DADOS)
        /// </summary>
        /// <param name="user">dados para atualizar usuario</param>
        public void atualizaDados(MO_Usuario user)
        {
            db = new MO_DB();
            //montar os campos dinamicamente
            if (user != null)
            {
                db.tabela = MO_NomesBanco.tabelaUsu;
                db.campos = string.Format("{0}='{4}', {1}='{5}', {2}='{6}', {3}={7}",
                    MO_NomesBanco.nomeUsu, MO_NomesBanco.loginUsu, MO_NomesBanco.senhaUsu, MO_NomesBanco.statusUsu,
                    user.nome, user.login, user.senha, (int)user.status);
                db.adicionais = string.Format("{0}={1}", MO_NomesBanco.idUsu, user.id);
                //montar sql e executa-lo no banco de dados..
                sql = monta.montaEditar(db);
                executar(sql);
            }
        }

        /// <summary>
        /// pesquisar todos usuarios que estão ativos..
        /// </summary>
        /// <returns>uma lista de usuarios para ser trabalhada..</returns>
        public List<MO_Usuario> pesquisaTodosUsuarios()
        {
            db = new MO_DB();
            db.tabela = MO_NomesBanco.tabelaUsu;
            db.campos = "*";
            //pegar somente os ativos(não excluidos)
            db.adicionais = string.Format(" WHERE {0} = {1}", MO_NomesBanco.statusUsu, (int)Status.ativo);

            sql = monta.montaSelecionar(db);
            return montaLista(executaRetorno(sql));
        }

        /// <summary>
        /// Dinamicamente, uma pesquisa diferente em que consiste o login
        /// </summary>
        /// <param name="user">usuario(login, senha)</param>
        /// <returns>retorna o obj de usuario todo para ser utilizado</returns>
        public MO_Usuario pesquisaLogin(MO_Usuario user)
        {
            DataTable dt = new DataTable();
            if (user != null)
            {
                db = new MO_DB();
                db.tabela = MO_NomesBanco.tabelaUsu;
                db.campos = "*";
                db.adicionais = string.Format(" WHERE {0}='{3}' and {1}='{4}' and {2}={5}", MO_NomesBanco.loginUsu, MO_NomesBanco.senhaUsu, MO_NomesBanco.statusUsu,
                    user.login, user.senha, (int)Status.ativo);
                sql = monta.montaSelecionar(db);
            }
            dt = executaRetorno(sql);
            if (dt.Rows.Count == 1)
                return montaLista(dt)[0];
            else
                return null;
        }

        private List<MO_Usuario> montaLista(DataTable dt)
        {
            lstUsu = new List<MO_Usuario>();

            //percorrer para passar para determinada lista, mais facil e mais pratica de se trabalhar.
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //setando a parada, provavelmente esta carregando lixo..
                usu = new MO_Usuario();

                usu.id = int.Parse(dt.Rows[i][MO_NomesBanco.idUsu].ToString());
                usu.login = dt.Rows[i][MO_NomesBanco.loginUsu].ToString();
                usu.nome = dt.Rows[i][MO_NomesBanco.nomeUsu].ToString();
                usu.senha = dt.Rows[i][MO_NomesBanco.senhaUsu].ToString();
                usu.status = (Status)dt.Rows[i][MO_NomesBanco.statusUsu];
                //adiciona a lista o objeto de usuário..
                lstUsu.Add(usu);
            }

            return lstUsu;
        }
    }
}
