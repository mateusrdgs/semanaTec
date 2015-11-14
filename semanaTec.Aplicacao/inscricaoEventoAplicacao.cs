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
    public class inscricaoEventoAplicacao
    {
        private Contexto contexto;

        private void insereInscricao(inscricaoEvento inscricao) // INSERE UMA NOVA INSCRIÇÃO NA TABELA DE INSCRIÇÃO DE EVENTOS
        {
            var strInsert = "";
            strInsert += @"INSERT INTO tblInscEvento (nCodEv, nCodSi)";
            strInsert += string.Format(@" VALUES ({0}, {1})",
            inscricao.Evento, inscricao.codigoSeminfo);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }

        private void atualizaInscricao(inscricaoEvento inscricao) // ATUALIZA UMA INSCRIÇÃO NA TABELA DE INSCRIÇÃO DE EVENTOS
        {
            var strUpdate = "";
            strUpdate += @"UPDATE tblInscEvento SET ";
            strUpdate += string.Format(@"nCodEv = {0}, 
            nCodSi = {1})", inscricao.Evento, inscricao.codigoSeminfo);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strUpdate);
            }
        }
        public void salvar(inscricaoEvento inscricao) // SALVA UMA NOVA INSCRIÇÃO
        {
            if (listaInscricoes().Count(x => x.Codigo == inscricao.Codigo) > 0)
            {
                atualizaInscricao(inscricao);
            }
            else
            {
                insereInscricao(inscricao);
            }
        }
        private void deletaInscricao(string cpf) // DELETA UMA INSCRIÇÃO NA TABELA DE INSCRIÇÃO DE EVENTOS
        {
            var strDelete = string.Format(@"DELETE * FROM 
            tblInscEvento WHERE sCPF = '{0}'", cpf);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }

        public List<inscricaoEvento> listaInscricoes() // SELECIONA AS INFORMAÇÕES DE TODAS AS INSCRIÇÕES REALIZADAS
        {
            var strSelect = "SELECT * FROM tblInscEvento";
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return inscricaoReaderToObjectList(retornoDataReader);
            }
        }
        private List<inscricaoEvento> inscricaoReaderToObjectList(SqlDataReader reader) //CONVERTE O DATAREADER DO MÉTODO ACIMA
        {                                                                               //EM UMA LISTA DE INSCRIÇÃO DE EVENTOS
            var inscricoes = new List<inscricaoEvento>();
            while (reader.Read())
            {
                var temp = new inscricaoEvento()
                {
                    Codigo = int.Parse(reader["nCodInsc"].ToString()),                    
                    Evento = int.Parse(reader["nCodEv"].ToString()),
                    codigoSeminfo = int.Parse(reader["nCodSi"].ToString())
                };
                inscricoes.Add(temp);
            }
            reader.Close();
            return inscricoes;
        }
        /*public bool cpfJaCadastradoEvento(int nCodEv, string sCPF) // VERIFICA SE O CPF PASSADO POR PARAMETRO EXISTE NAQUELE DETERMINADO EVENTO
        {
            int n = 0;
            string strSelect = string.Format(@"SELECT COUNT(sCPF) FROM
            tblInscEvento i, tblParticipante p WHERE i.nCodEv = {0} AND p.sCPF = '{1}'", nCodEv, sCPF);
            contexto = new Contexto();
            SqlDataReader retorno = contexto.executaComandoRetorno(strSelect);
            try
            {
                while (retorno.Read())
                {
                    n = int.Parse(retorno.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (n == 0)
                return false;
            else
                return true;
        }*/

        public bool cadastradoEvento(int codigo, string cpf) // CHAMA O STORED PROCEDURE QUE VERIFICA SE 
        {                                                    //DETERMINADO CPF JA ESTÁ CADASTRADO NAQUELE EVENTO
            string strProcedure = "cpfCadEv";
            bool existe = false;
            string parametro = "@Cod";
            string parametro2 = "@CPF";
            using(contexto = new Contexto())
            {
                existe = contexto.executaScalar(strProcedure, parametro, codigo, parametro2, cpf);
            }
            return existe;            
        }

        public int retornoCodSeminfo(string cpf) // RETORNA O CÓDIGO DE INSCRIÇÃO NA SEMINFO DO CPF DESEJADO
        {
            string strQuery = "returnCodSeminfo";
            string parametro = "@CPF";
            int codigo = 0;
            using (contexto = new Contexto())
            {
                codigo = contexto.executaScalar(strQuery, parametro, cpf);
            }
            return codigo;
        }
    }
}
