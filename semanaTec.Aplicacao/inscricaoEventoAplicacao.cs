using semanaTec.Dominio;
using semanaTec.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable retornaEventosInscritos(string cpf)
        {
            string strQuery = string.Format(@"SELECT ev.sNome 
            FROM tblParticipante p
            INNER JOIN tblInscSeminfo ism
            ON p.sCPF = ism.sCPF
            INNER JOIN tblInscEvento iev
            ON iev.nCodSi = ism.nCodSi
            INNER JOIN tblEvento ev
            ON iev.nCodEv = ev.nCodEv
            WHERE p.sCPF = '{0}'", cpf);
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strQuery);
                return eventoInscritosReaderToDT(retornoDataReader);
            }
        }
        private DataTable eventoInscritosReaderToDT(SqlDataReader reader) // FAZ A CONVERSÃO DO DATAREADER LISTADO ACIMA EM UM DATATABLE
        {
            DataTable tbEsquema = reader.GetSchemaTable();
            DataTable tbRetorno = new DataTable();
            foreach (DataRow r in tbEsquema.Rows)
            {
                if (!tbRetorno.Columns.Contains(r["ColumnName"].ToString()))
                {
                    DataColumn col = new DataColumn()
                    {
                        ColumnName = r["ColumnName"].ToString(),
                        Unique = Convert.ToBoolean(r["IsUnique"]),
                        AllowDBNull = Convert.ToBoolean(r["AllowDBNull"]),
                        ReadOnly = Convert.ToBoolean(r["IsReadOnly"])
                    };
                    tbRetorno.Columns.Add(col);
                }
            }
            while (reader.Read())
            {
                DataRow novaLinha = tbRetorno.NewRow();
                for (int i = 0; i < tbRetorno.Columns.Count; i++)
                {
                    novaLinha[i] = reader.GetValue(i);
                }
                tbRetorno.Rows.Add(novaLinha);
            }
            return tbRetorno;
        }

        public bool cadastradoEvento(int codigo, string cpf) // CHAMA O STORED PROCEDURE QUE VERIFICA SE 
        {                                                    //DETERMINADO CPF JA ESTÁ CADASTRADO NAQUELE EVENTO
            string strProcedure = "cpfCadEv";
            bool existe = false;
            string parametro = "@Cod";
            string parametro2 = "@CPF";
            using (contexto = new Contexto())
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
