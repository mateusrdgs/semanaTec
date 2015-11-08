using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanaTec.Metodos
{
    public class criaLogin
    {
        public string crialogin(string nome)
        {
            int contador = 0, uBranco = 0;
            string newLogin = "";
            nome = nome.ToLower();
            nome = nome.TrimStart();
            nome = nome.TrimEnd();
            while (nome[contador] != ' ')
            {
                newLogin += nome.ToLower()[contador];
                contador++;
            }
            newLogin += ".";
            //Console.Write(newLogin);
            while (contador < nome.Length)
            {
                if (nome[contador] == ' ')
                {
                    uBranco = contador;
                }
                contador++;
            }
            uBranco++;
            while (uBranco < nome.Length)
            {
                newLogin += nome.ToLower()[uBranco];
                uBranco++;
            }
            return newLogin;
        }
    }
}
