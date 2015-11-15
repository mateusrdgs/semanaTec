using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace semanaTec.Repositorio
{
    public class Contexto : IDisposable
    {
        public readonly SqlConnection minhaConexao; // Declaração da conexão com o DB
        public Contexto()
        {
            minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["semanaTecConfig"].ConnectionString);
            minhaConexao.Open();
        }
        public void executaComando(string strCommand) //Execução de comandos SQL sem retorno (INSERT, UPDATE, DELETE)
        {
            if(minhaConexao.State == ConnectionState.Closed)
                minhaConexao.Open();
            var cmdComando = new SqlCommand
            {
                CommandText = strCommand,
                CommandType = System.Data.CommandType.Text,
                Connection = minhaConexao
            };
            cmdComando.ExecuteNonQuery();
        }
        public SqlDataReader executaComandoRetorno(string strCommand) //Execução de comando SQL com retorno (SELECT)
        {
            if (minhaConexao.State == ConnectionState.Closed)
                minhaConexao.Open();
            var cmdComando = new SqlCommand(strCommand, minhaConexao);
            return cmdComando.ExecuteReader();
        }

        public dynamic executaScalar(string strCommand)
        {
            if (minhaConexao.State == ConnectionState.Closed)
                minhaConexao.Open();
            var cmdComando = new SqlCommand
            {
                Connection = minhaConexao,
                CommandText = strCommand,
                CommandType = CommandType.StoredProcedure
            };
            var fenda = cmdComando.ExecuteScalar();
            return fenda;
        }
        
        public dynamic executaScalar(string strCommand, string parametro, string valor) 
        {
            if (minhaConexao.State == ConnectionState.Closed)
                minhaConexao.Open();
            var cmdComando = new SqlCommand
            {
                Connection = minhaConexao,
                CommandText = strCommand,
                CommandType = CommandType.StoredProcedure
            };
            cmdComando.Parameters.AddWithValue(parametro, valor);
            var fenda = cmdComando.ExecuteScalar();
            return fenda;
        }
        public dynamic executaScalar(string strCommand, string parametro, int codigo, string parametro2, string valor)
        {
            if (minhaConexao.State == ConnectionState.Closed)
                minhaConexao.Open();
            var cmdComando = new SqlCommand
            {
                Connection = minhaConexao,
                CommandText = strCommand,
                CommandType = CommandType.StoredProcedure
            };
            cmdComando.Parameters.AddWithValue(parametro, codigo);
            cmdComando.Parameters.AddWithValue(parametro2, valor);
            var fenda = cmdComando.ExecuteScalar();
            return fenda;
        }
        public dynamic executaScalar(string strCommand, string parametro, int codigo, string parametro2, string valor, string parametro3, string valor2)
        {
            if (minhaConexao.State == ConnectionState.Closed)
                minhaConexao.Open();
            var cmdComando = new SqlCommand
            {
                Connection = minhaConexao,
                CommandText = strCommand,
                CommandType = CommandType.StoredProcedure
            };
            cmdComando.Parameters.AddWithValue(parametro, codigo);
            cmdComando.Parameters.AddWithValue(parametro2, valor);
            cmdComando.Parameters.AddWithValue(parametro3, valor2);
            var fenda = cmdComando.ExecuteScalar();
            return fenda;
        }
        public void Dispose() // Método para fechar a conexão com o banco após uma execução
        {
            if (minhaConexao.State == ConnectionState.Open)
                minhaConexao.Close();            
        }
    }
}
