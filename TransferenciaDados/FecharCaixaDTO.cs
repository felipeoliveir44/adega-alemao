using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferenciaDados;

//namespace para acesso ao banco de dados

using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;

namespace TransferenciaDados
{


    public class fecharcaixaDTO
    {
        public  string Debito { get; set; }
        public string Debito2 { get; set; }
        public string Credito { get; set; }
        public string Credito2 { get; set; }
        public string Dinheiro { get; set; }
        public string Dinheiro2 { get; set; }
        public  string Pix { get; set; }
        public string Pix2 { get; set; }
        public decimal valortotal { get; set; }
        public decimal valorRetirada { get; set; }

        public string formapagamento { get; set; }
        public string mensagens { get; set; }
        


    }


    


    public class FechamentoCaixa
    {
        public void fechamentocaixa(fecharcaixaDTO dados)
        {
            //tratamento das exceções
            try
            {
                //definir comando para execução 
                MySqlCommand cmd = new MySqlCommand("spFechamentoCaixa", Conexao.obterConexao());


                //Definir como storedProcedure 
                cmd.CommandType = CommandType.StoredProcedure;

                //paramentros de entrada (input)
                
                cmd.Parameters.AddWithValue("@pFormaPagamentoDinheiro", dados.Dinheiro);
                cmd.Parameters.AddWithValue("@pFormaPagamentoDebito", dados.Debito);
                cmd.Parameters.AddWithValue("@pFormaPagamentoCredito", dados.Credito);
                cmd.Parameters.AddWithValue("@pFormaPagamentoPix", dados.Pix);




                //executar os comandos sql
                MySqlDataReader dr = cmd.ExecuteReader();



                if (dr.HasRows)
                {
                    //Pecorrer os registros
                    while (dr.Read())
                    {
                        //Popular com o resultado


                        //Formaspagamento.Credito =  Convert.ToInt32(dr.GetValue(1).ToString());
                        //Formaspagamento.Debito = Convert.ToInt32(dr.GetValue(1).ToString());
                        dados.Dinheiro = dr.GetValue(0).ToString();
                        dados.Dinheiro2 = dr.GetValue(4).ToString();

                        dados.Debito = dr.GetValue(1).ToString();
                        dados.Debito2 = dr.GetValue(5).ToString();

                        dados.Credito = dr.GetValue(2).ToString();
                        dados.Credito2 = dr.GetValue(6).ToString();

                        dados.Pix = dr.GetValue(3).ToString();
                        dados.Pix2 = dr.GetValue(7).ToString();
                        //Formaspagamento.Pix = Convert.ToInt32(dr.GetValue(1).ToString());

                    }
                }
                dr.Close();

                

                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {

                dados.mensagens = "Erro - ValidarUsuario - VerificarUsuarios \r\n " + e.Message.ToString();
            }

        }
    }


    public class FechandoCaixa
    {
        public void Fechando(fecharcaixaDTO dados)
        {
            try
            {

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spFechandoCaixa", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Popular o parametro

                cmd.Parameters.AddWithValue("@pValorTotal", dados.valortotal);
                cmd.Parameters.AddWithValue("@pValorRetirada", dados.valorRetirada);





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
                    case 1:
                        dados.mensagens = "Fechamento de Caixa com sucesso!";
                        break;

                    default:
                        dados.mensagens = "Não foi possível fechar o caixa!";
                        break;
                }

            }
            catch (MySqlException e)
            {

                dados.mensagens = "Erro - SalvarProduto - ProdutosIncluir" + e.Message.ToString();

            }
        }
    }















}





