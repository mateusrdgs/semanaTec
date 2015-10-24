using semanaTec.Dominio;
using semanaTec.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Aplicacao
{
    public class participanteAplicacao
    {
        private Contexto contexto;

        private void insereParticipante(Participantes participante)
        {
            var strInsert = "";
            strInsert += @"INSERT INTO tblParticipante (sCPF, sNome, sCurso, 
            nPeriodo, sTelefone, sEmail, sLogin, sSenha, sPerfil)";
            strInsert += string.Format(@" VALUES ('{0}', '{1}', '{2}', {3}, 
            '{4}', '{5}', '{6}', '{7}', '{8}')", 
            participante.Cpf, participante.Nome, participante.Curso, 
            participante.Periodo, participante.Telefone, participante.Email, 
            participante.Login, participante.Senha, participante.Perfil);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }
        private void atualizaParticipante(Participantes participante)
        {
            var strUpdate = "";
            strUpdate += @"UPDATE tblParticipante SET";
            strUpdate += string.Format(@"sCPF = '{0}', sNome = '{1}', sCurso = '{2},
            nPeriodo = '{3}', sTelefone = '{4}, sEmail = '{5}', sLogin = '{6}', 
            sSenha = {7}, sPerfil = '{8}')", participante.Cpf, participante.Nome, 
            participante.Curso, participante.Periodo, participante.Telefone, 
            participante.Email, participante.Login, participante.Senha, participante.Perfil);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strUpdate);
            }
        }
        public void salvaParticipante(Participantes participante)
        {
            
            if(participante.Cpf == (selectParticipantes().Where(x=>x.Cpf == participante.Cpf)).ToString())
            {
                atualizaParticipante(participante);
            }
            else
                insereParticipante(participante);
        }
        public void deletaParticipante(string CPF)
        {
            var strDelete = string.Format(@"DELETE FROM tblParticipante WHERE sCPF = {0}", CPF);
            using(contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        public List<Participantes> selectParticipantes()
        {
            var strSelect = "SELECT * FROM tblParticipante";
            using(contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return participanteReaderToObjectList(retornoDataReader);
            }
        }
        public List<Participantes> participanteReaderToObjectList(SqlDataReader reader)
        {
            var participantes = new List<Participantes>();
            while(reader.Read())
            {
                var temp = new Participantes()
                {
                    Cpf = (reader["sCPF"].ToString()),
                    Nome = (reader["sNome"].ToString()),
                    Curso = (reader["sCurso"].ToString()),
                    Periodo = int.Parse(reader["nPeriodo"].ToString()),
                    Telefone = (reader["sTelefone"].ToString()),
                    Email = (reader["sEmail"].ToString()),
                    Login = (reader["sLogin"].ToString()),
                    Senha = (reader["sSenha"].ToString()),
                    Perfil = (reader["sPerfil"].ToString()),
                };
                participantes.Add(temp);
            }
            reader.Close();
            return participantes;
        }
    }
}
