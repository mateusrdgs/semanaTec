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
    public class eventoAplicacao
    {
        private Contexto contexto;

        public void insereEvento(Evento evento) // INSERE UM NOVO EVENTO NA TABELA DE EVENTOS
        {
            var strInsert = "";
            strInsert += @"INSERT INTO tblEvento (sNome, sLocal, dData, 
            hHora, sTipo, nDuracao, sDescricao, nCodPal, nVagas)";
            strInsert += string.Format(@" VALUES ('{0}', '{1}','{2}',
            '{3}','{4}','{5}','{6}','{7}','{8}')",
            evento.Nome, evento.Local, evento.Data, evento.Hora, evento.Tipo,
            evento.Duracao, evento.Descricao, evento.CodPal, evento.Vagas);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }

        public void atualizaEvento(Evento evento, int codigo) // ATUALIZA A TABELA DE EVENTOS
        {
            var strUpdate = "";
            strUpdate += @"UPDATE tblEvento SET ";
            strUpdate += string.Format(@"sNome = '{0}', sLocal = '{1}', dData = '{2}',
            hHora = '{3}', sTipo = '{4}', nDuracao = {5}, sDescricao = '{6}', 
            nVagas = {7}, nCodPal = {8} WHERE nCodEv = {9}",
            evento.Nome, evento.Local, evento.Data, evento.Hora, evento.Tipo,
            evento.Duracao, evento.Descricao, evento.Vagas, evento.CodPal, codigo);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strUpdate);
            }
        }

        public void salvaEvento(Evento evento, int codigo) // SALVA O EVENTO
        {
            if (codigo > 0)
            {
                atualizaEvento(evento, codigo);
            }
            else
                insereEvento(evento);
        }

        public void deletaEvento(int codigo) // DELETA UM EVENTO NA TABELA DE EVENTOS
        {
            var strDelete = string.Format(@"DELETE FROM tblEvento 
            WHERE nCodEv = {0}", codigo);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        public List<Evento> selectEventos() // SELECIONA TODOS OS EVENTOS NA TABELA DE EVENTOS
        {
            var strSelect = "SELECT * FROM tblEvento";
            using (contexto = new Contexto())
            {
                SqlDataReader retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return eventoReaderToObjectList(retornoDataReader);
            }
        }
        private List<Evento> eventoReaderToObjectList(SqlDataReader reader) // CONVERTE OS EVENTOS TRAGOS PELO
        {                                                                   // DATAREADER DO MÉTODO ACIMA EM OBJETOS DO TIPO EVENTO
            var eventos = new List<Evento>();
            while (reader.Read())
            {
                var temp = new Evento()
                {
                    Codigo = int.Parse(reader["nCodEv"].ToString()),
                    Nome = reader["sNome"].ToString(),
                    Local = reader["sLocal"].ToString(),
                    Data = DateTime.Parse(reader["dData"].ToString()),
                    Hora = DateTime.Parse(reader["hHora"].ToString()),
                    Tipo = reader["sTipo"].ToString(),
                    Duracao = int.Parse(reader["nDuracao"].ToString()),
                    Descricao = reader["sDescricao"].ToString(),
                    Vagas = int.Parse(reader["nVagas"].ToString()),
                    CodPal = int.Parse(reader["nCodPal"].ToString())
                };
                eventos.Add(temp);
            }
            reader.Close();

            return eventos;
        }

        public Evento selectEventoWhere(string nome) // SELECIONA TODAS AS INFORMAÇÕES DO EVENTO DESEJADO
        {
            var strSelectWhere = string.Format("SELECT * FROM tblEvento WHERE sNome = '{0}'", nome);
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelectWhere);
                return eventoReaderToObject(retornoDataReader);
            }
        }

        private Evento eventoReaderToObject(SqlDataReader reader) // CONVERTE AS INFORMAÇÕES DO DATAREADER
        {                                                         //  DO MÉTODO ACIMA EM UM OBJETO DO TIPO EVENTO
            var evento = new Evento();
            while (reader.Read())
            {
                var temp = new Evento
                {
                    Codigo = int.Parse(reader["nCodEv"].ToString()),
                    Nome = reader["sNome"].ToString(),
                    Local = reader["sLocal"].ToString(),
                    Data = DateTime.Parse(reader["dData"].ToString()),
                    Hora = DateTime.Parse(reader["hHora"].ToString()),
                    Tipo = reader["sTipo"].ToString(),
                    Duracao = int.Parse(reader["nDuracao"].ToString()),
                    Descricao = reader["sDescricao"].ToString(),
                    Vagas = int.Parse(reader["nVagas"].ToString()),
                    CodPal = int.Parse(reader["nCodPal"].ToString()),
                };
                evento = temp;
            }
            reader.Close();
            return evento;
        }

        public DataTable selectDTWhere(string nome) // TRAZ DETERMINADAS INFORMAÇÕES DA TABELA DE EVENTOS, JUNTAMENTE COM INFORMAÇÕES DA TABELA PALESTRANTE
        {
            var strSelectWhere = string.Format(@"SELECT ev.nCodEv, ev.sNome, ev.dData, 
            ev.hHora, ev.sLocal, pl.nCodPal, pl.sNome as pNome FROM tblPalestrante pl 
            INNER JOIN tblEvento ev ON pl.nCodPal = ev.nCodPal
            WHERE ev.sNome = '{0}'", nome);
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelectWhere);
                return eventoReaderToDT(retornoDataReader);
            }
        }
        
        private DataTable eventoReaderToDT(SqlDataReader reader) // FAZ A CONVERSÃO DO DATAREADER LISTADO ACIMA EM UM DATATABLE
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

        public List<string> selectNomesEventos() // SELECIONA O NOME DA TABELA EVENTO
        {
            string strQuery = "SELECT sNome FROM tblEvento";
            using(contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strQuery);
                return eventoNomeReaderToList(retornoDataReader);
            }
        }
        private List<string> eventoNomeReaderToList(SqlDataReader reader) // CONVERTE OS NOMES TRAGOS NO DATAREADER 
        {                                                                 // DO MÉTODO ACIMA EM UMA LISTA DE STRINGS
            var eventos = new List<string>();
            while(reader.Read())
            {
                string evento = reader["sNome"].ToString();
                eventos.Add(evento);
            }
            return eventos;            
        }
       
        public bool existeEvento() // CHAMA O STORED PROCEDURE QUE VERIFICA SE EXISTE OU NÃO EVENTOS CADASTRADOS
        {
            string strQuery = "existeEvento";
            bool existe = false;
            using(contexto = new Contexto())
            {
                existe = contexto.executaScalar(strQuery);
            }
            return existe;
        }
        public int retornaCodEv(string valor) // CHAMA O STORED PROCEDURE QUE RETORNA O CÓDIGO DO EVENTO PASSADO POR PARAMETRO
        {
            string parametro = "@evento";
            string strQuery = "returnCodEv";
            int codigo = 0;
            using(contexto = new Contexto())
            {
                codigo = contexto.executaScalar(strQuery,parametro,valor);                
            }
            return codigo;
        }
        public bool evSameTime(int codigo, DateTime data, DateTime hora)
        {
            string parametro = "@CodSi";
            string parametro2 = "@dData";
            string parametro3 = "@hHora";
            string strQuery = "outroEvHora";
            string date = data.ToString();
            bool existe = false;
            using(contexto = new Contexto())
            {
                existe = contexto.executaScalar(strQuery, parametro, codigo, parametro2, data.ToString(), parametro3, hora.ToString());
            }
            return existe;
        }
    }
}
