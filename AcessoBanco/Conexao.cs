using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBanco.Properties;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AcessoBanco
{
    public class Conexao
    {
        //Ira receber as mensagens do MySqlException
        public static string mensagem = string.Empty;


        //Definir string de Conexão 
        private static string strConn = Settings.Default.strConexao;


        //Definir variável de conexão com o banco de dados
        private static MySqlConnection conn = null;


        //Método que permite obter a conexão
        public static MySqlConnection obterConexao()
        {

            //Instanciar 
            conn = new MySqlConnection(strConn);


            //Tratamento de excessões 
            try
            {
                //Abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (MySqlException e)
            {
                //Retorna a variável como nulo
                conn = null;

                //Apresentar a mensagem de exceções
                //throw e;
                mensagem = e.Message.ToString();
            }

            return conn;



        }


        //Método que permite fechar a conexão
        public static MySqlConnection fecharConexao()
        {

            //Instanciar 
            conn = new MySqlConnection(strConn);


            //Tratamento de excessões 
            try
            {
                //Abre a conexão e a devolve ao chamador do método
                conn.Close();
            }
            catch (MySqlException e)
            {
                //Retorna a variável como nulo
                conn = null;

                //Apresentar a mensagem de exceções
                //throw e;
                mensagem = e.Message.ToString();
            }

            return conn;



        }
    }
}
