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
            strInsert += string.Format(@"INSERT INTO tblParticipante
            (sCPF, sNome, sEmail, sTelefone, sLogin, sSenha, sPerfil, 
            nPeriodo, sCurso) VALUES ('{0}', '{1}', '{2}', {3}, '{4}', 
            '{5}', '{6}', '{7}', '{8}')", participante.Cpf, participante.Nome, 
            participante.Email, participante.Telefone, participante.Login, 
            participante.Senha, participante.Perfil, participante.Periodo, 
            participante.Curso);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }
        private void atualizaParticipante(Participantes participante)
        {
            var strUpdate = "";
            strUpdate += string.Format(@"UPDATE tblParticipante SET 
            (sCPF, sNome, sEmail, sTelefone, sLogin, sSenha, sPerfil, 
            nPeriodo, sCurso) VALUES ('{0}', '{1}', '{2}', {3}, '{4}', 
            '{5}', '{6}', '{7}', '{8}')", participante.Cpf, participante.Nome,
            participante.Email, participante.Telefone, participante.Login,
            participante.Senha, participante.Perfil, participante.Periodo,
            participante.Curso);
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
        public Participantes selectParticipantesWhere(string CPF)
        {
            var strSelect = string.Format(@"SELECT * FROM tblParticipante
            WHERE sCPF = '{0}'", CPF);
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return participanteReaderToObject(retornoDataReader);
            }
        }
        public Participantes participanteReaderToObject(SqlDataReader reader)
        {
            var participantes = new Participantes();
            while (reader.Read())
            {
                var temp = new Participantes()
                {
                    Cpf = (reader["sCPF"].ToString()),
                    Nome = (reader["sNome"].ToString()),
                    Email = (reader["sEmail"].ToString()),
                    Telefone = (reader["sTelefone"].ToString()),
                    Login = (reader["sLogin"].ToString()),
                    Senha = (reader["sSenha"].ToString()),
                    Perfil = (reader["sPerfil"].ToString()),
                    Periodo = int.Parse(reader["nPeriodo"].ToString()),
                    Curso = (reader["sCurso"].ToString()),
                };
                participantes = temp;
            }
            reader.Close();
            return participantes;
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
