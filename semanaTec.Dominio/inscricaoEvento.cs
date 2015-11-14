using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Dominio
{
    public class inscricaoEvento
    {
        private DateTime data;
        private int codigo;
        private Evento evento = new Evento();
        private inscricaoSeminfo codSeminfo = new inscricaoSeminfo();

        public inscricaoEvento() 
        {
        
        }      
        public int codigoSeminfo 
        {
            get { return codSeminfo.Codigo; }
            set { codSeminfo.Codigo = value; }
        }
        public DateTime Data 
        {
            get { return data; }
            set { data = value; }
        }
        public int Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Evento
        {
            get { return evento.Codigo; }
            set { evento.Codigo = value; }
        }
    }
}
