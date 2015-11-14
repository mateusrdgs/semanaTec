using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Dominio
{
    public class Palestrante
    {
        private string nome;
        private string titulacao;
        private string miniCurriculum;
        private string cidade;
        private string telefone;
        private string email;
        private int codigo;

        public Palestrante() 
        {
        
        }

        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Titulacao 
        {
            get { return titulacao; }
            set { titulacao = value; }
        }
        public string MiniCurriculum 
        {
            get { return miniCurriculum; }
            set { miniCurriculum = value; }
        }
        public string Cidade 
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Telefone 
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email 
        {
            get { return email; }
            set { email = value; }
        }
        public int Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Evento Evento;
    }
}
