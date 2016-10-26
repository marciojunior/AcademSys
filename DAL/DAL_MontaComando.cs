using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace DAL
{
    class DAL_MontaComando
    {
        string sql;

        public string montaInserir(MO_DB db)
        {
            if (db != null)
                sql = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", db.tabela, db.campos, db.valores);
            return sql; 
        }

        public string montaEditar(MO_DB db)
        {
            if (db != null)
                sql = string.Format("UPDATE {0} SET {1} WHERE {2}", db.tabela, db.campos, db.adicionais);
            return sql;
        }

        public string montaExcluir(MO_DB db)
        {
            if (db != null)
                sql = string.Format("DELETE FROM {0} WHERE {1}", db.tabela, db.adicionais);
            return sql;
        }

        public string montaSelecionar(MO_DB db)
        {
            if (db != null)
                sql = string.Format("SELECT {0} FROM {1}{2}", db.campos, db.tabela, db.adicionais);
            return sql;
        }
    }
}
