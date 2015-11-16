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
    public class inscricaoSeminfoAplicacao
    {
        private Contexto contexto;

        public void insereInscricao(inscricaoSeminfo inscricao) // INSERE UMA NOVA INSCRIÇÃO NA TABELA DE INSCRIÇÃO DA SEMINFO
        {
            var strInsert = "";
            strInsert += @"INSERT INTO tblInscSeminfo (dData, sCPF)";
            strInsert += string.Format(@"VALUES ('{0}', '{1}')",
            inscricao.Data, inscricao.ParticipanteCpf);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }
        private void deletaInscricaoCpf(string cpf) //DELETA UMA INSCRIÇÃO NA TABELA DE INSCRIÇÃO DA SEMINFO
        {                                           //ATRAVÉS DO CPF INFORMADO
            var strDelete = string.Format(@"DELETE * FROM 
            tblInscSeminfo WHERE sCPF = '{0}'", cpf);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        private void deletaInscricaoCod(int cod) // DELETA UMA INSCRIÇÃO NA TABELA DE INSCRIÇÃO DA SEMINFO
        {                                        //ATRAVÉS DO CPF INFORMADO
            var strDelete = string.Format(@"DELETE * FROM 
            tblInscSeminfo WHERE nCodSi = '{0}'", cod);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        public List<inscricaoSeminfo> selectInscricaoSeminfo() // SELECIONA TODAS AS INFORMAÇÕES DA TABELA DE INSCRIÇÕES DA SEMINFO
        {
            var strSelect = string.Format(@"SELECT * FROM tblInscSeminfo");
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return inscToDataReader(retornoDataReader);
            }
        }

        public List<inscricaoSeminfo>inscToDataReader(SqlDataReader reader) // CONVERTE AS INFORMAÇÕES DO DATAREADER TRAGO PELO
        {                                                                   // MÉTODO ACIMA EM UMA LISTA DO TIPO INSCRIÇÃO SEMINFO
            var inscricoes = new List<inscricaoSeminfo>();
            while (reader.Read())
            {
                var temp = new inscricaoSeminfo()
                {
                    Codigo = int.Parse((reader["nCodSi"]).ToString()),
                    Data = DateTime.Parse((reader["dData"]).ToString()),
                    ParticipanteCpf = (reader["sCPF"].ToString())
                };
                inscricoes.Add(temp);
            }
            reader.Close();
            return inscricoes;
        }

        public bool jaCadastrado(string valor) // CHAMA UM STORED PROCEDURE QUE VERIFICA SE O CPF INFORMADO EXISTE NA TABELA DE INSCRIÇÃO DA SEMINFO
        {
            bool existe = false;
            string parametro = "@CPF";
            try
            {    
                string strQuery = "inscCpfExistente";
                using (contexto = new Contexto())
                {
                    existe = (bool)contexto.executaScalar(strQuery,parametro,valor);                    
                }
            }
            catch(Exception ex)
            {
                string y = ex.Message.ToString();
            }
            
            return existe;
        }        
    }
}
