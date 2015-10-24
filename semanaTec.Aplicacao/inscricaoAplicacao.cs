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
    public class inscricaoAplicacao
    {
        private Contexto contexto;

        private void insereInscricao(Inscricao inscricao)
        {
            var strInsert = "";
            strInsert += @"INSERT INTO tblInscricao (sCPF, sData, nCodEv)";
            strInsert = string.Format(@"VALUES ('{0}', '{1}', '{2}", 
            inscricao.Cpf, inscricao.Data, inscricao.Evento);
            using(contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }
        private void atualizaInscricao(Inscricao inscricao)
        {
            var strUpdate = "";
            strUpdate += @"UPDATE tblInscricao SET ";
            strUpdate += string.Format(@"sCPF = '{0}', 
            sData = '{1}', nCodEv = '{2}')", inscricao.Cpf,
            inscricao.Data, inscricao.Evento);
            using(contexto = new Contexto())
            {
                contexto.executaComando(strUpdate);
            }
        }
        /*public void salvar(Inscricao inscricao)
        {
            if(inscricao.Codigo == )
        }*/

        private void deletaInscricao(string cpf)
        {
            var strDelete = string.Format(@"DELETE * FROM 
            tblInscricao WHERE sCPF = '{0}", cpf);
            using(contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        public List<Inscricao> listaInscricoes()
        {
            var strSelect = "SELECT * FROM tblInscricoes";
            using(contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return inscricaoReaderToObjectList(retornoDataReader);
            }
        }
        public List<Inscricao> inscricaoReaderToObjectList(SqlDataReader reader)
        {
            var inscricoes = new List<Inscricao>();
            while(reader.Read())
            {
                var temp = new Inscricao()
                {
                    Codigo = int.Parse(reader["nCodInsc"].ToString()),
                    Cpf = (reader["sCPF"].ToString()),
                    Data = (reader["sData"].ToString()),
                    Evento = int.Parse(reader["nCodEv"].ToString())
                };
                inscricoes.Add(temp);
            }
            reader.Close();
            return inscricoes;
        }
    }
}
