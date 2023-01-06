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
    public class pedidosDTO
    {
        public class PedidosDTO
        {

            //Atributos
            public string nomecliente { get; set; }
            public int codproduto { get; set; }
            public string nomeproduto { get; set; }
            public int quantidade { get; set; }
            public string unidade { get; set; }
            public decimal valorTotal { get; set; }
            public decimal preco { get; set; }
            public string formapagamento { get; set; }



            public string mensagens { get; set; }


        }

        public class Pedidos
        {
            public void RealizarPedidos(PedidosDTO dados)
            {
                try
                {

                    //Definir comando para execução
                    MySqlCommand cmd = new MySqlCommand("spRealizarPedidos", Conexao.obterConexao());
                    //Definir como Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Popular o parametro

                    cmd.Parameters.AddWithValue("@pNomeCliente", dados.nomecliente);
                    cmd.Parameters.AddWithValue("@pNomeProduto ", dados.nomeproduto);
                    cmd.Parameters.AddWithValue("@pQuantidade ", dados.quantidade);
                    cmd.Parameters.AddWithValue("@pValorTotal ", dados.valorTotal);
                    cmd.Parameters.AddWithValue("@pFormaPagamento ", dados.formapagamento);

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
                            dados.mensagens = "Pedido realizado com sucesso!";
                            break;

                        default:
                            dados.mensagens = "Não foi possível realizar o pedido!";
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

    }
}

