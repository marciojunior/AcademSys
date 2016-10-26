using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class BLL_Usuarios
    {
        DAL_Usuarios dalUsu = new DAL_Usuarios();

        public void inserir(MO_Usuario usu)
        {
            if (usu != null)
                if (usu.login != null)
                    if (usu.nome != null)
                        if (usu.senha != null)
                            dalUsu.inserirDados(usu);
        }

        public void atualiza(MO_Usuario usu)
        {
            if (usu != null)
                if (usu.login != null)
                    if (usu.nome != null)
                        if (usu.senha != null)
                            dalUsu.atualizaDados(usu);
        }

        public List<MO_Usuario> pesquisar()
        {
            return dalUsu.pesquisaTodosUsuarios();
        }

        public MO_Usuario logar(MO_Usuario user)
        {
            MO_Usuario usuRet = new MO_Usuario();
            if (user != null)
            {
                if (user.login != null && user.senha != null)
                {
                    //removendo ' contra sql injection
                    user.senha = user.senha.Replace("'", "");
                    usuRet = dalUsu.pesquisaLogin(user);
                }
            }
            return usuRet;
        }
    }
}
