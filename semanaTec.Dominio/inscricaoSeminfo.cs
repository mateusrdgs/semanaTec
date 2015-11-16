using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Dominio
{
    public class inscricaoSeminfo
    {
        private int codigo;
        private Participantes participante = new Participantes();
        private DateTime data;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string ParticipanteCpf
        {
            get { return participante.Cpf; }
            set { participante.Cpf = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

    }
}
