using Projeto_Lucas.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lucas.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "" ;
        public bool acessar(string login, string senha)
        {
            LoginComandos loginDal = new LoginComandos();
            tem = loginDal.verificarlogin(login, senha);
            if(!loginDal.mensagem.Equals(""))
                {
                    this.mensagem = loginDal.mensagem;
                }
            return tem; 
        }
        public string cadastrar(string email,string senha,string confsenha, string nome)
        {
            LoginComandos loginDal = new LoginComandos();
            this.mensagem = loginDal.cadastrar(email, senha, confsenha,nome);
            if(loginDal.tem)
            {
                this.tem = true;
            }

            return mensagem;
        }
      
    }
}
