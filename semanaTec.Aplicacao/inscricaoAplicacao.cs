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
            strInsert += @"INSERT INTO tblInscricao (sCPF, dData, nCodEv)";
            strInsert += string.Format(@"VALUES ('{0}', '{1}', {2})",
            inscricao.Cpf, inscricao.Data, inscricao.Evento);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }
        private void atualizaInscricao(Inscricao inscricao)
        {

            var strUpdate = "";
            strUpdate += @"UPDATE tblInscricao SET ";
            strUpdate += string.Format(@"sCPF = '{0}', 
            dData = '{1}', nCodEv = {2})", inscricao.Cpf,
            inscricao.Data, inscricao.Evento);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strUpdate);
            }
        }
        public void salvar(Inscricao inscricao)
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
        private void deletaInscricao(string cpf)
        {
            var strDelete = string.Format(@"DELETE * FROM 
            tblInscricao WHERE sCPF = '{0}'", cpf);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        public List<Inscricao> listaInscricoes()
        {
            var strSelect = "SELECT * FROM tblInscricao";
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return inscricaoReaderToObjectList(retornoDataReader);
            }
        }
        private List<Inscricao> inscricaoReaderToObjectList(SqlDataReader reader)
        {
            var inscricoes = new List<Inscricao>();
            while (reader.Read())
            {
                var temp = new Inscricao()
                {
                    Codigo = int.Parse(reader["nCodInsc"].ToString()),
                    Cpf = (reader["sCPF"].ToString()),
                    Data = DateTime.Parse(reader["dData"].ToString()),
                    Evento = int.Parse(reader["nCodEv"].ToString())
                };
                inscricoes.Add(temp);
            }
            reader.Close();
            return inscricoes;
        }
        public bool cpfJaCadastradoEvento(int nCodEv, string sCPF)
        {
            int n = 0;
            string strSelect = string.Format(@"SELECT COUNT(sCPF) FROM
            tblInscricao i WHERE i.nCodEv = {0} AND i.sCPF = '{1}'", sCPF, nCodEv);
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
        }
    }
}
