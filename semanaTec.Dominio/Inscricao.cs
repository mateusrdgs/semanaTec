using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Dominio
{
    public class Inscricao
    {
        private string CPF;
        private string data;
        private int codigo;

        public Inscricao() { }

        public string Cpf 
        {
            get { return CPF; }
            set { CPF = value; }
        }
        public string Data 
        {
            get { return data; }
            set { data = value; }
        }
        public int Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
