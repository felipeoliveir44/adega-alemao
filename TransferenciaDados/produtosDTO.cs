
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace para acesso ao banco de dados

using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;

namespace TransferenciaDados
{
    public class produtosDTO
    {

        //Atributos

        public int codproduto { get; set; }
        public string nomecliente { get; set; }
        public string nomeproduto { get; set; }
        public int quantidade {get; set; }
        public decimal valor1 { get; set; }
        public decimal valor2 { get; set; }
        public decimal valorTotal { get; set; }

        public string unidade { get; set; }
        public decimal preco { get; set; }
        public string descricao { get; set; }

        public decimal precoquente { get; set; }
        public decimal precogelado { get; set; }
        public string formapagamento { get; set; }
        public string formapagamento2 { get; set; }
        public decimal precocusto { get; set; }


        public string statusprodutos { get; set; }

        public string qntdestoque { get; set; }

        public string categoria { get; set; }

        public int tipopreco { get; set; }

        public string mensagens { get; set; }


    }

    public class SalvarProduto
    {

        public void ProdutosIncluir(produtosDTO dados)
        {
            try
            {

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spIncluirProdutos", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Popular o parametro
              
                cmd.Parameters.AddWithValue("@pnome_produto", dados.nomeproduto);
                cmd.Parameters.AddWithValue("@punidade", dados.unidade);
                cmd.Parameters.AddWithValue("@pqntd_estoque", dados.qntdestoque);
                cmd.Parameters.AddWithValue("@pcategoria", dados.categoria);
                cmd.Parameters.AddWithValue("@pprecoquente", dados.precoquente);
                cmd.Parameters.AddWithValue("@pprecogelado", dados.precogelado);
                cmd.Parameters.AddWithValue("@pprecocusto", dados.precocusto);
                cmd.Parameters.AddWithValue("@pstatus_produtos", "A");
                



                //Executar os comandos SQL
                //Tabela temporaria
                /* MySqlDataReader dr = cmd.ExecuteReader();

                 //Verificar a existencia de registros
                if (dr.HasRows)
                 {
                     //Percorre os registros
                     while (dr.Read())
                     {
                         dados.codproduto = Convert.ToInt32(dr.GetValue(0).ToString());
                     }
                 }
                 dr.Close();*/


                int registrosinseridos = cmd.ExecuteNonQuery();
                //verificar se os registros foram inseridos
                switch (registrosinseridos)
                {
                    case 8:
                        dados.mensagens = "Registros inseridos com sucesso";
                        break;

                    default:
                        dados.mensagens = "Não foi possivel inserir registros";
                        break;
                }

                

                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {

                dados.mensagens = "Erro - SalvarProduto - ProdutosIncluir" + e.Message.ToString();

            }
        }

    }

    public class ConsultarProdutos

    {
        //conteiner de dados
        public DataTable ProdutosDataTable;

        public void ProdutosConsultar(produtosDTO dados)
        {
            try
            {
                //Interação de dados
                // MySqlDataAdapter ProdutoDataAdapter = new MySqlDataAdapter("spConsultarProdutos", Conexao.obterConexao());

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spConsultarProdutos", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Popular o parametro

                cmd.Parameters.AddWithValue("@pnome", dados.nomeproduto);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //Pecorrer os registros
                    while (dr.Read())
                    {
                        //Popular com o resultado
                        dados.codproduto = Convert.ToInt32(dr.GetValue(0).ToString());
                       dados.nomeproduto = (dr.GetValue(1).ToString());

                    }
                }
                dr.Close();


                
                MySqlDataAdapter ProdutoDataAdapter = new MySqlDataAdapter();
                ProdutoDataAdapter.SelectCommand = cmd;
                
                //instanciar o objeto
                ProdutosDataTable = new DataTable();
                //popular o datatable
                ProdutoDataAdapter.Fill(ProdutosDataTable);
                




                Conexao.fecharConexao();
            }

            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ConsultarProdutos - ProdutosConsultar \r\n" + e.Message;
            }
        }

    }

    public class ConsultarProdutosPedidosPdv

    {
        //conteiner de dados
        public DataTable ProdutosDataTable;

        public void ProdutosConsultarPedidosPdv(produtosDTO dados)
        {
            try
            {
                //Interação de dados
                // MySqlDataAdapter ProdutoDataAdapter = new MySqlDataAdapter("spConsultarProdutos", Conexao.obterConexao());

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spConsultarDescricao", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Popular o parametro

                cmd.Parameters.AddWithValue("@pnome", dados.nomeproduto);
                cmd.Parameters.AddWithValue("@pDescricao", dados.descricao);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //Pecorrer os registros
                    while (dr.Read())
                    {
                        //Popular com o resultado
                        dados.codproduto = Convert.ToInt32(dr.GetValue(0).ToString());
                        dados.nomeproduto = dr.GetValue(1).ToString();
                        dados.descricao = dr.GetValue(2).ToString();
                        dados.preco = Convert.ToDecimal(dr.GetValue(3).ToString());
                    }
                }
                dr.Close();



                MySqlDataAdapter ProdutoDataAdapter = new MySqlDataAdapter();
                ProdutoDataAdapter.SelectCommand = cmd;

                //instanciar o objeto
                ProdutosDataTable = new DataTable();
                //popular o datatable
                ProdutoDataAdapter.Fill(ProdutosDataTable);





                Conexao.fecharConexao();
            }

            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ConsultarProdutos - ProdutosConsultar \r\n" + e.Message;
            }
        }

    }

    public class EnviarPedidos
    {
        public void PedidosEnviar (produtosDTO dados)
        {
            try
            {

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spRealizarPedidos", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Popular o parametro

                cmd.Parameters.AddWithValue("@pNomeCliente", dados.nomecliente);
                cmd.Parameters.AddWithValue("@pNomeProduto", dados.nomeproduto);
                cmd.Parameters.AddWithValue("@pDescricao", dados.descricao);
                cmd.Parameters.AddWithValue("@pQuantidade", dados.quantidade);
                cmd.Parameters.AddWithValue("@pValorTotal", dados.valorTotal);
                cmd.Parameters.AddWithValue("@pFormaPagamento", dados.formapagamento);





                //Executar os comandos SQL
                //Tabela temporaria
                /* MySqlDataReader dr = cmd.ExecuteReader();

                 //Verificar a existencia de registros
                if (dr.HasRows)
                 {
                     //Percorre os registros
                     while (dr.Read())
                     {
                         dados.codproduto = Convert.ToInt32(dr.GetValue(0).ToString());
                     }
                 }
                 dr.Close();*/


                int registrosinseridos = cmd.ExecuteNonQuery();
                //verificar se os registros foram inseridos
                switch (registrosinseridos)
                {
                    case 8:
                        dados.mensagens = "Registros inseridos com sucesso";
                        break;

                    default:
                        dados.mensagens = "Não foi possivel inserir registros";
                        break;
                }



                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {

                dados.mensagens = "Erro - SalvarProduto - ProdutosIncluir" + e.Message.ToString();

            }
        }
    }

    public class FormaPagamento2
    {
        public void AtualizarFormaPagamento(produtosDTO dados)
        {
            try
            {

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spPedidoFormaPagamento2", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Popular o parametro

                cmd.Parameters.AddWithValue("@pFormaPagamento", dados.formapagamento2);
                cmd.Parameters.AddWithValue("@pValor", dados.valor2);

                //Executar os comandos SQL
                //Tabela temporaria
                /* MySqlDataReader dr = cmd.ExecuteReader();

                 //Verificar a existencia de registros
                if (dr.HasRows)
                 {
                     //Percorre os registros
                     while (dr.Read())
                     {
                         dados.codproduto = Convert.ToInt32(dr.GetValue(0).ToString());
                     }
                 }
                 dr.Close();*/


                int registrosinseridos = cmd.ExecuteNonQuery();
                //verificar se os registros foram inseridos
                switch (registrosinseridos)
                {
                    case 3:
                        dados.mensagens = "Registros inseridos com sucesso";
                        break;

                    default:
                        dados.mensagens = "Não foi possivel inserir registros";
                        break;
                }



                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {

                dados.mensagens = "Erro - SalvarProduto - ProdutosIncluir" + e.Message.ToString();

            }
        }
    }

    public class DGVfinalizar
    {

        public DataTable PedidosDataTable;

        public void ListarDGV(produtosDTO dados)
        {
            try
            {

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spListarPedidos", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pnome", dados.nomeproduto);

                //Executar os comandos SQL
                //Tabela temporaria
                MySqlDataReader dr = cmd.ExecuteReader();

                //Verificar a existencia de registros
                if (dr.HasRows)
                {
                    //Percorre os registros
                    while (dr.Read())
                    {
                        dados.nomeproduto = dr.GetValue(2).ToString();
                        dados.valorTotal = Convert.ToDecimal(dr.GetValue(0).ToString());
                        dados.formapagamento = dr.GetValue(1).ToString();


                    }
                }

                dr.Close();


                Conexao.fecharConexao();



            }
            catch (MySqlException e)
            {

                dados.mensagens = "Erro - SalvarUsuario - UsuariosIncluir" + e.Message.ToString();

            }

        }


    }


}

    