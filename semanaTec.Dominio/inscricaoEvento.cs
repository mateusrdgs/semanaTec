using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Dominio
{
    public class inscricaoEvento
    {
        private Participantes participante = new Participantes();
        private DateTime data;
        private int codigo;
        private Evento evento = new Evento();

        public inscricaoEvento() 
        {
        
        }      
        public string Cpf 
        {
            get { return participante.Cpf; }
            set { participante.Cpf = value; }
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
