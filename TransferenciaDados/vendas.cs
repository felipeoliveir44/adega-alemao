using AcessoBanco;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TransferenciaDados
{
    public class vendas
    {
        public string nomeproduto { get; set; }

        public DateTime datainicio { get; set; }

        public DateTime datafinal { get; set; }

        public object mensagens { get; set; }

        public string Setor { get; set; }
        public decimal Valor { get; set; }
        public short Ano { get; set; }

        public vendas()
        {

        }

        public vendas(short ano, string setor, decimal valor)
        {
            Ano = ano;
            Valor = valor;
            Setor = setor;
        }

        public List<vendas> VendasAnual(short ano, string descricao1, int totalQtde, string descricao2, decimal lucro)
        {
            var vendasSetor = new List<vendas>();

            vendasSetor.Add(new vendas(ano, descricao1, totalQtde));
            vendasSetor.Add(new vendas(ano, descricao2, lucro));
            /*vendasSetor.Add(new vendas(ano, "Jack", 210235));
            vendasSetor.Add(new vendas(ano, "Tequila", 210235));*/


            return vendasSetor;
        }

        public string[] GetNomeSetores(List<vendas> vendas)
        {
            string[] setores = new string[vendas.Count];

            for (int i = 0; i < vendas.Count; i++)
                setores[i] = vendas[i].Setor;

            return setores;
        }

        public decimal[] GetValoresSetores(List<vendas> vendas)
        {
            decimal[] valores = new decimal[vendas.Count];

            for (int i = 0; i < vendas.Count; i++)
                valores[i] = vendas[i].Valor;

            return valores;
        }

        public class ConsultarPedidos

        {
            //conteiner de dados
            public DataTable ProdutosDataTable;

            public void PedidosConsultar(vendas dados)
            {
                try
                {
                    //Interação de dados
                    // MySqlDataAdapter ProdutoDataAdapter = new MySqlDataAdapter("spConsultarProdutos", Conexao.obterConexao());

                    //Definir comando para execução
                    MySqlCommand cmd = new MySqlCommand("spConsultarPedidos", Conexao.obterConexao());
                    //Definir como Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Popular o parametro

                    cmd.Parameters.AddWithValue("@pnome", dados.nomeproduto);
                    cmd.Parameters.AddWithValue("@pinicio", dados.datainicio);
                    cmd.Parameters.AddWithValue("@pfinal", dados.datafinal);

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
                    dados.mensagens = "Erro - ConsultarPedidos - PedidosConsultar \r\n" + e.Message;
                }
            }

        }

    }
}





