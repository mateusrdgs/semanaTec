using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Dominio
{
    public class Participantes
    {
        private string CPF;
        private string nome;
        private string curso;
        private string periodo;
        private string telefone;
        private string email;
        private string login;
        private string senha;
        private bool perfil = false;

        public Participantes() { }

        public string Cpf 
        {
            get { return CPF; }
            set { CPF = value; }
        }
        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Curso 
        {
            get { return curso; }
            set { curso = value; }
        }
        public string Periodo 
        {
            get { return periodo; }
            set { periodo = value; }
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
        public string Login 
        {
            get { return login; }
            set { login = value; }
        }
        public string Senha 
        {
            get { return senha; }
            set { senha = value; }
        }
        public bool Perfil 
        {
            get { return perfil; }
            set { perfil = value; }
        }
    }
}
