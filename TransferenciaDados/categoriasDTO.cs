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
    public class categoriasDTO
    {
       public int codcategoria { get; set; }

       public string nomecategoria { get; set; }

       public string mensagens { get; set; }

        public int id { get; set; }
        public string nome { get; set; }
    }

    

    
    public class ConsultarrCategorias
    {
        public DataTable CategoriasDataTable;

        public DataTable UsuariosDataTable { get; private set; }

        public void ListarProdutosPdv(categoriasDTO dados)
        {
            try
            {
                //Definir comando para execução 
                MySqlCommand cmd = new MySqlCommand("spConsultarProdutos", Conexao.obterConexao());

                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                //Parâmetros de entrada (input)
                cmd.Parameters.AddWithValue("@pNome", dados.nomecategoria);

                //instanciar o DataAdapter
                //dataAdapter representa i, conjunto de comandos sql e uma conexao de banco de dados
                //que sao usados para preencher o DataSet e atualizar a fonte de dados.
                MySqlDataAdapter CategoriaDataAdapter = new MySqlDataAdapter();

                //obter a intrução Transact-SQL
                CategoriaDataAdapter.SelectCommand = cmd;

                //instaciar o dataTable
                //dataTable é como um container que podemps isar para armazenar 
                //dados de praticamente qualquer fonte de dados, sendo composto 
                //por uma coleçao de linhas(rows) e colunas (columns)
                CategoriasDataTable = new DataTable();


                //Ppopukar o dataTable 
                CategoriaDataAdapter.Fill(CategoriasDataTable);
            }
            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ConsultarCategorias - ListarCategorias \r\n " + e.Message.ToString();
            }
        }
        public void  ListarCategorias(categoriasDTO dados)
        {
            try
            {
                //Definir comando para execução 
                MySqlCommand cmd = new MySqlCommand("spConsultarCategorias", Conexao.obterConexao());

                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                //Parâmetros de entrada (input)
                cmd.Parameters.AddWithValue("@pnomecategoria", dados.nomecategoria);

                //instanciar o DataAdapter
                //dataAdapter representa i, conjunto de comandos sql e uma conexao de banco de dados
                //que sao usados para preencher o DataSet e atualizar a fonte de dados.
                MySqlDataAdapter CategoriaDataAdapter = new MySqlDataAdapter();

                //obter a intrução Transact-SQL
                CategoriaDataAdapter.SelectCommand = cmd;

                //instaciar o dataTable
                //dataTable é como um container que podemps isar para armazenar 
                //dados de praticamente qualquer fonte de dados, sendo composto 
                //por uma coleçao de linhas(rows) e colunas (columns)
                CategoriasDataTable = new DataTable();


                //Ppopukar o dataTable 
                CategoriaDataAdapter.Fill(CategoriasDataTable);
            }
            catch (MySqlException e )
            {
                 dados.mensagens = "Erro - ConsultarCategorias - ListarCategorias \r\n " + e.Message.ToString();
            }
        }

        public void UsuariosConsultar(categoriasDTO dados)
        {
            try
            {
                //Interação de dados
                // MySqlDataAdapter ProdutoDataAdapter = new MySqlDataAdapter("spConsultarProdutos", Conexao.obterConexao());

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spConsultarFuncionarios", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Popular o parametro

                cmd.Parameters.AddWithValue("@pnome", dados.nome);

                MySqlDataAdapter UsuariosDataAdapter = new MySqlDataAdapter();
                UsuariosDataAdapter.SelectCommand = cmd;




                //instanciar o objeto
                UsuariosDataTable = new DataTable();
                //popular o datatable
                UsuariosDataAdapter.Fill(UsuariosDataTable);

                Conexao.fecharConexao();
            }

            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ConsultarProdutos - ProdutosConsultar \r\n" + e.Message;
            }
        }

    }
}
