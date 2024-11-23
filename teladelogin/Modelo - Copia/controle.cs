using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teladelogin.DAL;

namespace teladelogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            logindaocomandos logindao = new logindaocomandos();
            tem = logindao.verificarLogin(login, senha);
            if (!logindao.mensagem.Equals(""))
            {
                this.mensagem = logindao.mensagem;
            }
            return tem;
        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            logindaocomandos logindao = new logindaocomandos();
            this.mensagem = logindao.cadastrar(email, senha, confSenha);
            if(logindao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
    

