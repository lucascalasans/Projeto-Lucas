using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lucas.Dal
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=LAPTOP-9KADH1ED\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True";

        }
        public SqlConnection Conectar ()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
               con.Close();
            }
        }
    }
}
