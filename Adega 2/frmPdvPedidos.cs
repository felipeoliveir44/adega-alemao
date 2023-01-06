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

namespace Adega_2
{
    public partial class frmPdvPedidos : Form
    {
        

        public frmPdvPedidos()
        {
            InitializeComponent();
        }

        private void btnProximaEtapa_Click(object sender, EventArgs e)
        {

            if (dgvPdv.Rows.Count <= 0)
            {
                MessageBox.Show("Adicionar um produto antes \r\n ",
                       "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
             
               
            //this.pnlPdvPedidos.Controls.Clear();
            frmPdvFormaPagamento frmEstoque_Vrb = new frmPdvFormaPagamento(lblValorTotal.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlPdvPedidos.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();
            frmEstoque_Vrb.BringToFront();

                
            }
        }

        public void ListarCategoria()
        {
            try
            {
                //Instaciar as classes
                ConsultarrCategorias consultarcategorias = new ConsultarrCategorias();
                categoriasDTO dados = new categoriasDTO();

                //Chamar o método para consulta
                consultarcategorias.ListarProdutosPdv(dados);

                //Limpar a fonte de dados
                cboPedidosProdutos.DataSource = null;
                cboPedidosProdutos.Items.Clear();

                //Popular o combobox
                //Alem do nome, sera armazenado tambem o codigo (este nao sera visivel)
                cboPedidosProdutos.ValueMember = "cod_produto";
                cboPedidosProdutos.DisplayMember = "nome_produto";

                //Associar a fonte de daos 
                cboPedidosProdutos.DataSource = consultarcategorias.CategoriasDataTable;

                //Posicionar no item em branco do combobox
                cboPedidosProdutos.SelectedIndex = -1;



            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
        }


        private void frmPdvPedidos_Load(object sender, EventArgs e)
        {
            ListarCategoria();
            /*txtID.Text = "1";
            txtNome.Text = "Corote";
            txtDescricao.Text = "Gelado";
            txtQtde.Text = "10";
            txtUnitario.Text = "12,00";
            txtTotal.Text = "120";*/
        }


        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            EnviarPedidos enviarpedidos = new EnviarPedidos();
            produtosDTO dados = new produtosDTO();

            dados.nomecliente = txtNomeCliente.Text;
            dados.nomeproduto = txtNome.Text;
            dados.descricao = txtDescricao.Text;
            dados.quantidade = Convert.ToInt32(txtQtde.Text);
            dados.valorTotal = Convert.ToDecimal(txtTotal.Text);
            dados.formapagamento = cboFormaPagamento.SelectedItem.ToString();


            enviarpedidos.PedidosEnviar(dados);


            MessageBox.Show(dados.mensagens);



            dgvPdv.Rows.Add(
                              txtNomeCliente.Text, txtID.Text, txtNome.Text, txtDescricao.Text,
                              txtQtde.Text, txtUnitario.Text,
                              txtTotal.Text);

            txtID.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtQtde.Clear();
            txtUnitario.Clear();
            txtTotal.Clear();

            CalcularTotalGeral();

            /*codigosGerais c = new codigosGerais();

            if (c.campoVazio(txtQtde) == true)
            {
                return;
            }

            if (c.campoVazio(txtNomeCliente) == true)
                return;
            else
            {

             

            }*/

        }


        public void CalcularTotalGeral()
        {
            decimal totalGeral = 0;


            foreach (DataGridViewRow linha in dgvPdv.Rows)
            {
                // += atualiza o valor da variavel
                // Somar o valor existente com o valor novo
                totalGeral += Convert.ToDecimal(linha.Cells["valor_total"].Value);
            }

            lblValorTotal.Text = totalGeral.ToString("F");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja remover a linha selecionada?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                //Remover a linha selecionada do DataGridView
                dgvPdv.Rows.RemoveAt(dgvPdv.CurrentRow.Index);
            }
        }

        public void CalcularTotais()
        {
            // Declaração de variavel

            int quantidade;
            decimal unitario;
            decimal total;
            

            // && igual a E ----------- || igual a OU

            if (txtQtde.Text == "" || txtUnitario.Text == "")
            {

                txtTotal.Clear();
                
            }

            // Verificar se a quantidade ou unitario estao vazios
            if (txtQtde.Text != "" && txtUnitario.Text != "")
            {



                // Atribuição dos valores do form as variaveis

                quantidade = Convert.ToInt32(txtQtde.Text);
                unitario = Convert.ToDecimal(txtUnitario.Text);

                
                    // Calculo

                    total = quantidade * unitario;
                    txtTotal.Text = total.ToString("F");

                // Setar o campo de texto com o valor do calculo

                txtTotal.Text = total.ToString("F");


            }

        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            CalcularTotais();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNome.Clear();

            if (cboPedidosProdutos.Text != "")
            {
                ConsultarProdutosPedidosPdv consultarProdutospdv = new ConsultarProdutosPedidosPdv();
                produtosDTO dados = new produtosDTO();

                dados.nomeproduto = cboPedidosProdutos.Text;
                dados.descricao = cboTipoPreco.Text;

                consultarProdutospdv.ProdutosConsultarPedidosPdv(dados);

                txtID.Text = dados.codproduto.ToString();
                txtNome.Text = dados.nomeproduto;
                txtUnitario.Text = Convert.ToString(dados.preco);
                txtDescricao.Text = dados.descricao;
            }
           
        }

        
    }
}
