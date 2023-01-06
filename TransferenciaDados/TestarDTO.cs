using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;

namespace TransferenciaDados
{
    public class TestarDTO
    {
        //Receberá o retorno do método obterConexao()
        public MySqlConnection conectar = null;


        //Receberá o retorno das exceções 
        public string mensagem = string.Empty;


        //Método
        public void Verificar()
        {
            conectar = Conexao.obterConexao();
            mensagem = Conexao.mensagem;
        }
    }
}
