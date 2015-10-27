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
    public class eventoAplicacao
    {
        private Contexto contexto;

        public void insereEvento(Evento evento)
        {
            var strInsert = "";
            strInsert += @"INSERT INTO tblEvento (sNome, sLocal, dData, 
            hHora, sTipo, nDuracao, sDescricao, nCodPales, nVagas)";
            strInsert += string.Format(@" VALUES ('{0}', '{1}','{2}',
            '{3}', '{4}','{5}','{6}','{7}','{8}')",
            evento.Nome, evento.Local, evento.Data, evento.Hora, evento.Tipo,
            evento.Duracao, evento.Descricao, evento.CodPal, evento.Vagas);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }

        public void atualizaEvento(Evento evento)
        {
            var strUpdate = "";
            strUpdate += @"UPDATE tblEvento SET ";
            strUpdate += string.Format(@"sNome = '{0}', sLocal = '{1}', dData = '{2}',
            hHora = '{3}', sTipo = '{4}', nDuracao = '{5}', sDescricao = '{6}', 
            nCodPalest = '{7}', nVagas = '{8}')",
            evento.Nome, evento.Local, evento.Data, evento.Hora, evento.Tipo,
            evento.Duracao, evento.Descricao, evento.CodPal, evento.Vagas);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strUpdate);
            }
        }
        public void salvaEvento(Evento evento)
        {
             if(evento.Codigo > 0)
            {
                atualizaEvento(evento);
            }
            else
                insereEvento(evento);
        }
        public void deletaEvento(int codigo)
        {
            var strDelete = string.Format(@"DELETE FROM tblEvento 
            WHERE nCodEv = {0}", codigo);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        public List<Evento> selectEventos()
        {
            var strSelect = "SELECT * FROM tblEvento";
            using (contexto = new Contexto())
            {                
                SqlDataReader retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return eventoReaderToObjectList(retornoDataReader);
            }
        }

        public Evento selectEventoWhere(string nome)
        {
            var strSelectWhere = string.Format("SELECT * FROM tblEvento WHERE sNome = '{0}'", nome);
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelectWhere);
                return eventoReaderToObject(retornoDataReader);
            }
        }
        public List<Evento> eventoReaderToObjectList(SqlDataReader reader)
        {
            var eventos = new List<Evento>();
            try
            {
                
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
                        CodPal = int.Parse(reader["nCodPales"].ToString()),
                        Vagas = int.Parse(reader["nVagas"].ToString())
                    };
                    eventos.Add(temp);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                int a;
            }
            return eventos;
        }

        public Evento eventoReaderToObject(SqlDataReader reader)
        {
            var evento = new Evento();
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
                    CodPal = int.Parse(reader["nCodPales"].ToString()),
                    Vagas = int.Parse(reader["nVagas"].ToString())
                };
                evento = temp;
            }
            reader.Close();
            return evento;
        }
    }
}
