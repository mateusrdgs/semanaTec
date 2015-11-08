using semanaTec.Dominio;
using semanaTec.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Aplicacao
{
    class inscricaoSeminfoAplicacao
    {
        private Contexto contexto;

        private void insereInscricao(inscricaoSeminfo inscricao)
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
        private void deletaInscricaoCpf(string cpf)
        {
            var strDelete = string.Format(@"DELETE * FROM 
            tblInscSeminfo WHERE sCPF = '{0}'", cpf);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
        private void deletaInscricaoCod(int cod)
        {
            var strDelete = string.Format(@"DELETE * FROM 
            tblInscSeminfo WHERE nCodSi = '{0}'", cod);
            using (contexto = new Contexto())
            {
                contexto.executaComando(strDelete);
            }
        }
    }
}
