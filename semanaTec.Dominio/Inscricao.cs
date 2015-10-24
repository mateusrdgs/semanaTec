using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Dominio
{
    public class Inscricao
    {
        private Participantes participante = new Participantes();
        private string data;
        private int codigo;
        private Evento evento = new Evento();

        public Inscricao() 
        {
        
        }
       
        
        public string Cpf 
        {
            get { return participante.Cpf; }
            set { participante.Cpf = value; }
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
        public int Evento
        {
            get { return evento.Codigo; }
            set { evento.Codigo = value; }
        }
    }
}
