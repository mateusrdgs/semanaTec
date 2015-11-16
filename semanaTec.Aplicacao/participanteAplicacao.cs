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

        private void insereParticipante(Participantes participante) // INSERE UM NOVO PARTICIPANTE NA TABELA DE PARTICIPANTE
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
        private void atualizaParticipante(Participantes participante, string cpf) // ATUALIZA AS INFORMAÇÕES DE DETERMINADO PARTICIPANTE
        {
            var strUpdate = "";
            strUpdate += string.Format(@"UPDATE tblParticipante SET 
            sCPF = '{0}', sNome = '{1}', sEmail = '{2}', sTelefone = '{3}', 
            sLogin = '{4}', sSenha = '{5}', sPerfil = '{6}', nPeriodo = {7}, 
            sCurso = '{8}' WHERE sCPF = '{9}'", participante.Cpf, participante.Nome,
            participante.Email, participante.Telefone, participante.Login,
            participante.Senha, participante.Perfil, participante.Periodo,
            participante.Curso, cpf);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strUpdate);
            }
        }
        public void salvaParticipante(Participantes participante, string cpf) // SALVA UM NOVO OU ATUALIZA AS INFORMAÇÕES DE UM PARTICIPANTE
        {
            try
            {
                if (selectParticipantesWhere(cpf).Cpf == cpf)
                {
                    atualizaParticipante(participante, cpf);
                }
                else
                    insereParticipante(participante);
            }
            catch(Exception ex)
            {
                string y = ex.Message;
            }
        }
        public void deletaParticipante(string CPF) // DELETA AS INFORMAÇÕES DE DETERMINADO PARTICIPANTE
        {
            var strDelete = string.Format(@"DELETE FROM tblParticipante WHERE sCPF = {0}", CPF);
            using(contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        public List<Participantes> selectParticipantes() // SELECIONA AS INFORMAÇÕES DA TABELA DE PARTICIPANTE
        {
            var strSelect = "SELECT * FROM tblParticipante";
            using(contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return participanteReaderToObjectList(retornoDataReader);
            }
        }
        public List<Participantes> participanteReaderToObjectList(SqlDataReader reader) //CONVERTE AS INFORMAÇÕES DO DATAREADER
        {                                                                               //TRAGO PELO MÉTODO ACIMA EM UMA LISTA DO TIPO PARTICIPANTE
            var participantes = new List<Participantes>();
            while (reader.Read())
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
        public Participantes selectParticipantesWhere(string CPF) //SELECIONA AS INFORMAÇÕES DE DETERMINADO PARTICIPANTE
        {
            var strSelect = string.Format(@"SELECT * FROM tblParticipante
            WHERE sCPF = '{0}'", CPF);
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return participanteReaderToObject(retornoDataReader);
            }
        }
        public Participantes participanteReaderToObject(SqlDataReader reader) // CONVERTE AS INFORMAÇÕES DO DATAREADER TRAGO ACIMA 
        {                                                                     // EM UM OBJETO DO TIPO PARTICIPANTE
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
    }
}
