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

        private void inserir(Evento evento)
        {
            var strInsert = "";
            strInsert += @"INSERT INTO tblEvento (sNome, sLocal, sData, 
            sHora, sTipo, nDuracao, sDescricao, nCodPales, nVagas)";
            strInsert += string.Format(@" VALUES ('{0}', '{1}','{2}',
            '{3}', '{4}','{5}','{6}','{7}','{8}')",
            evento.Nome, evento.Local, evento.Data, evento.Hora, evento.Tipo,
            evento.Duracao, evento.Descricao, evento.CodPal, evento.Vagas);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }

        private void alterar(Evento evento)
        {
            var strUpdate = "";
            strUpdate += @"UPDATE tblEvento SET ";
            strUpdate += string.Format(@"sNome = '{0}', sLocal = '{1}', sData = '{2}',
            sHora = '{3}', sTipo = '{4}', nDuracao = '{5}', sDescricao = '{6}', 
            nCodPalest = '{7}', nVagas = '{8}')",
            evento.Nome, evento.Local, evento.Data, evento.Hora, evento.Tipo,
            evento.Duracao, evento.Descricao, evento.CodPal, evento.Vagas);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strUpdate);
            }
        }
        public void salvar(Evento evento)
        {
            if (evento.Codigo > 0)
            {
                alterar(evento);
            }
            else
                inserir(evento);
        }
        public void excluir(int codigo)
        {
            var strDelete = string.Format(@"DELETE FROM tblEvento 
            WHERE nCodEven = {0}", codigo);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        public List<Evento> listarEventos()
        {
            var strSelect = "SELECT * FROM tblEvento";
            using (contexto = new Contexto())
            {                
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return readerToObjectList(retornoDataReader);
            }
        }
        public List<Evento> readerToObjectList(SqlDataReader reader)
        {
            var eventos = new List<Evento>();
            while (reader.Read())
            {
                var temp = new Evento()
                {
                    Codigo = int.Parse(reader["nCodEven"].ToString()),
                    Nome = reader["sNome"].ToString(),
                    Local = reader["sLocal"].ToString(),
                    Data = reader["dData"].ToString(),
                    Hora = reader["hHora"].ToString(),
                    Tipo = reader["sTipo"].ToString(),
                    Duracao = int.Parse(reader["nDuracao"].ToString()),
                    Descricao = reader["sDescricao"].ToString(),
                    CodPal = int.Parse(reader["nCodPales"].ToString()),
                    Vagas = int.Parse(reader["nVagas"].ToString())
                };
                eventos.Add(temp);
            }
            reader.Close();
            return eventos;
        }
    }
}
