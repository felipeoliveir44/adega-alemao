using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaDados;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using static TransferenciaDados.vendas;

namespace Adega_2
{
    public partial class frmVendas : Form
    {
        private object txtFiltrar;
        private object dados;
        private object consultarpedidos;
        private object consultarpedido;
        private object cmbCategoriaVendas;

        public frmVendas()
        {
            InitializeComponent();
        }


        private void btnBuscarVendas_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciar as classes ConsultarProdutos
                ConsultarPedidos consultarpedidos = new ConsultarPedidos();
                vendas dados = new vendas();

                //popular a classe
                dados.nomeproduto = txtPesquisarProdutos.Text;
                dados.datainicio = dtpInicio.Value.Date;
                dados.datafinal = dtpFinal.Value.Date;

                //MessageBox.Show(dados.datainicio.ToString());

                //chamar o metodo para consultar
                consultarpedidos.PedidosConsultar(dados);

                //Limpar o grid
                dgvPesquisarProdutos.Rows.Clear();

                //verificar o retorno do metodo
                if (dados.mensagens == null)
                {
                    //Preencher o grid com os dados do DataTable
                    // se i (linha) for igual a 0 e rows count = quantidade de linhas
                    for (int i = 0; i < consultarpedidos.ProdutosDataTable.Rows.Count; ++i)
                    {
                        dgvPesquisarProdutos.Rows.Add(//consultarprodutos.ProdutosDataTable.Rows[i]["codproduto"],
                                            consultarpedidos.ProdutosDataTable.Rows[i]["nome_produto"],
                                            //consultarpedidos.ProdutosDataTable.Rows[i]["cod_pedido"],
                                            //consultarpedidos.ProdutosDataTable.Rows[i]["cod_produto"],
                                           // consultarpedidos.ProdutosDataTable.Rows[i]["cod_cliente"],
                                            consultarpedidos.ProdutosDataTable.Rows[i]["quantidade"],
                                            consultarpedidos.ProdutosDataTable.Rows[i]["data_pedido"],
                                            consultarpedidos.ProdutosDataTable.Rows[i]["valor_total"]);

                    }
                }

                else
                {
                    // "\r\n" pular linha
                    MessageBox.Show("Contate o Suporte \r\n " + dados.mensagens,
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Contate o Suporte \r\n " + ex.ToString(),
                       "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            var vendas = new vendas();

            //Pegar os parâmetros do formulário do Datagrid - Foreach
            string descricao1 = "Qtnd Total";
            string descricao2 = "Valor Total";
            int totalQtde = 0;
            decimal lucro = 0;


            //Pega o conteudo de uma linha especifica da tabela (nesse caso tabela dgv)
            foreach (DataGridViewRow linha in dgvPesquisarProdutos.Rows)
            {

                // += Atualiza o valor da variavel
                //Somar o valor existente com o valor novo
                totalQtde += Convert.ToInt32
                   (linha.Cells["colquantidade"].Value); //Pega um valor especifico da coluna na tabela (nesse caso Total Geral)

                lucro += Convert.ToInt32
                (linha.Cells["colvalor_total"].Value);

            }



            var lista = vendas.VendasAnual(2022, descricao1, totalQtde, descricao2, lucro);

            var setores = vendas.GetNomeSetores(lista);
            var valores = vendas.GetValoresSetores(lista);

            /*//Titulo principal
            var titulo = new Title();
            titulo.Font = new Font("Elephant", 22, FontStyle.Bold);
            titulo.ForeColor = Color.DarkBlue;
            titulo.Text = "Vendas" + lista[0].Ano.ToString();
            chart1.Titles.Add(titulo);*/

            /*//titulo secundario
            var titulo2 = new Title();
            titulo2.Font = new Font("Arial", 18, FontStyle.Bold);
            titulo2.ForeColor = Color.DarkBlue;
            titulo2.Text = "Valores e, reais";
            chart1.Titles.Add(titulo2);*/

            if (chart1.Legends.Count == 1)
            {
                chart1.Legends.Remove(chart1.Legends[0]);
                chart1.Series.Remove(chart1.Series[0]);
            }

            chart1.Legends.Add("Legenda");
            chart1.Legends[0].Title = "setores";


            chart1.Series.Add("Vendas");
            chart1.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //Inclinação e rotação do gráfico
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.ChartAreas[0].Area3DStyle.Inclination = 30;
            chart1.ChartAreas[0].Area3DStyle.Rotation = 60;




            //Monstrar os valores sobre as fatias da pizza
            chart1.Series[0].IsValueShownAsLabel = true;


            //Paleta de cores
            chart1.Palette = ChartColorPalette.BrightPastel;

            //serie de dados com os valores do grafico
            chart1.Series[0].Points.DataBindXY(setores, valores);

        }

        


        private object Chart1(string v)
        {
            throw new NotImplementedException();
        }

     






        /* private void cmbCategoriaVendas_SelectedIndexChanged(object sender, EventArgs e)
         {
             //Carregar o nome da categoria no TexBox
             cmbCategoriaVendas.DropDownStyle = ComboBoxStyle.DropDownList;


        public void ListarCategoria()
         {
             try
             {
                 //Instaciar as classes
                 ConsultarrCategorias consultarcategorias = new ConsultarrCategorias();
                 categoriasDTO dados = new categoriasDTO();

                 //Chamar o método para consulta
                 consultarcategorias.ListarCategorias(dados);

                 //Limpar a fonte de dados
                 cmbCategoriaVendas.DataSource = null;
                 cmbCategoriaVendas.Items.Clear();

                 //Popular o combobox
                 //Alem do nome, sera armazenado tambem o codigo (este nao sera visivel)
                 cmbCategoriaVendas.ValueMember = "cod_categoria";
                 cmbCategoriaVendas.DisplayMember = "nome_categoria";

                 //Associar a fonte de daos 
                 cmbCategoriaVendas.DataSource = consultarcategorias.CategoriasDataTable;

                 //Posicionar no item em branco do combobox
                 cmbCategoriaVendas.SelectedIndex = -1;

             }
             catch (Exception e)
             {

                 MessageBox.Show(e.Message.ToString());
             }
         }*/


    }
}
















