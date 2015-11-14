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
    public class palestranteAplicacao
    {
        private Contexto contexto;

        public void inserePalestrante(Palestrante palestrante) //INSERE NOVAS INFORMAÇÕES NA TABELA PALESTRANTE
        {
            var strInsert = "";
            strInsert += @"INSERT INTO tblPalestrante (sNome, sTitulacao,
            sMiniCurriculum, sCidade, sTelefone, sEmail)";
            strInsert += string.Format(@"VALUES ('{0}', '{1}', '{2}',
            '{3}', '{4}', '{5}')", palestrante.Nome, palestrante.Titulacao,
            palestrante.MiniCurriculum, palestrante.Cidade, palestrante.Telefone,
            palestrante.Email);
            using(contexto = new Contexto())
            {
                contexto.executaComando(strInsert);
            }
        }
        public void atualizaPalestrante(Palestrante palestrante) //ATUALIZA INFORMAÇÕES NA TABELA DE PALESTRANTE
        {
            var strUpdate = "";
            strUpdate += @"UPDATE tblPalestrante SET ";
            strUpdate += string.Format(@"sNome = '{0}, sTitulacao ='{1}',
            sMiniCurriculum ='{2}', sCidade = '{3}', sTelefone = '{4}', sEmail = '{5}'");
            using(contexto = new Contexto())
            {
                contexto.executaComando(strUpdate);
            }
        }
        public void salvaPalestrante(Palestrante palestrante) // SALVA OU ATUALIZA A TABELA DE PALESTRANTE
        {
            if (selectPalestrante().Count(x => x.Codigo == palestrante.Codigo) > 0)
            {
                atualizaPalestrante(palestrante);
            }
            else
                inserePalestrante(palestrante);

        }
        public void deletaPalestrante(string CPF)
        {
            var strDelete = "";
            strDelete += string.Format(@"DELETE tblPalestrante WHERE sCPF = '{0}'", CPF); // DELETA UM PALESTRANTE
            using(contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        public List<Palestrante> selectPalestrante() // SELECIONA TODAS AS INFORMAÇÕES DA TABELA DE PALESTRANTES
        {
            var strSelect = "SELECT * FROM tblPalestrante";
            using(contexto =new Contexto())
            {
                var retornoDataReader = contexto.executaComandoRetorno(strSelect);
                return palestranteReaderToObjectList(retornoDataReader);
            }
        }
        public List<Palestrante> palestranteReaderToObjectList(SqlDataReader reader) //CONVERTE O DATAREADER DA TABELA ACIMA EM OBJETOS DO TIPO PALESTRANTE
        {
            var palestrantes = new List<Palestrante>();
            while(reader.Read())
            {
                var temp = new Palestrante()
                {
                    Codigo = int.Parse(reader["nCodPal"].ToString()),
                    Nome = (reader["sNome"].ToString()),
                    Titulacao = (reader["sTitulacao"].ToString()),
                    MiniCurriculum = (reader["sMiniCurriculum"].ToString()),
                    Cidade = (reader["sCidade"].ToString()),
                    Telefone = (reader["sTelefone"].ToString()),
                    Email = (reader["sEmail"].ToString()),
                };
                palestrantes.Add(temp);
            }
            reader.Close();
            return palestrantes;
        }
    }
}
