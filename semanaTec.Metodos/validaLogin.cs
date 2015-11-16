using semanaTec.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Metodos
{
    public class validaLogin
    {
        private Contexto contexto;
        public string logar(string login, string password)
        {
            string perfil = "";
            string strLogin = string.Format(@"SELECT sPerfil 
            FROM tblParticipante WHERE sLogin = '{0}' AND 
            sSenha = '{1}'", login, password);
            using(contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executaComandoRetorno(strLogin);
                while(reader.Read())
                {
                    perfil = reader["sPerfil"].ToString();
                }                
            }
            return perfil;            
        }
        public string cpfLogin(string login, string password)
        {
            string cpf = "";
            string strLogin = string.Format(@"SELECT sCPF
            FROM tblParticipante WHERE sLogin = '{0}' 
            AND sSenha = '{1}'", login, password);
            using(contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executaComandoRetorno(strLogin);
                while (reader.Read())
                {
                    cpf = reader["sCPF"].ToString();
                }  
            }
            return cpf;
        }
    }
}
