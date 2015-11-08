using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Dominio
{
    public class Evento
    { 
        private string nome;
        private string local;
        private DateTime data;
        private DateTime hora;
        private string tipo;
        private string descricao;
        private int codigo;
        private int duracao;
        private int codPal;
        private int vagas;

        /*public Evento() 
        { 
        
        }*/

        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Local 
        {
            get { return local; }
            set { local = value; }
        }
        public DateTime Data 
        {
            get { return data; }
            set { data = value; }
        }
        public DateTime Hora 
        {
            get { return hora; }
            set { hora = value; }
        }
        public string Tipo 
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Descricao 
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Duracao 
        {
            get { return duracao; }
            set { duracao = value; }
        }
        public int CodPal 
        {
            get { return codPal; }
            set { codPal = value; }
        }
        public int Vagas 
        {
            get { return vagas; }
            set { vagas = value; }
        }
    }
}
