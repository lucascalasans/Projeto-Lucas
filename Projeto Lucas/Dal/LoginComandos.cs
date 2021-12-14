using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lucas.Dal
{
    internal class LoginComandos
    {
        // metodo para verificar no bando se tem 
        public bool tem = false ;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr ;
        public bool verificarlogin (string login, string senha)
        {
            cmd.CommandText = "select * from  logins  where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar(); 
     
                dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados..";
            }
            return tem;

        }
        //comandos para inserir no banco 
        public string cadastrar (string email, string senha,string confsenha, string nome)
        {
            tem=false;
            if(senha.Equals(confsenha))
            {
                cmd.CommandText = "insert into logins values (@e, @s, @n);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);
                cmd.Parameters.AddWithValue("@n", nome);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado com Sucesso !!";
                    tem = true;
                }
                catch (SqlException)
                { 
                    this.mensagem = "Erro com o banco de dados";
                }
            }
            else
            {
                this.mensagem = "Verificar as senhas..";
            }
            
            return mensagem;

        }
       
        
    }
}
