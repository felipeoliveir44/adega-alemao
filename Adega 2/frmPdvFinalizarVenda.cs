using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TransferenciaDados;

namespace Adega_2
{
    public partial class frmPdvFinalizarVenda : Form
    {
        public frmPdvFinalizarVenda()
        {
            InitializeComponent();



        }

        decimal totalPagar;

        public frmPdvFinalizarVenda(decimal totalPagamento)
        {
            InitializeComponent();
            totalPagar = totalPagamento;

            lblValorTotalProdutoDinheiro.Text = totalPagar.ToString("F");

            DGVfinalizar dgvfinalizar = new DGVfinalizar();
            produtosDTO dados = new produtosDTO();


            //chamar o metodo
            dgvfinalizar.ListarDGV(dados);
            //Popular a classe




            label1.Text = dados.nomeproduto;
            label2.Text = dados.formapagamento;





            dgvFinalizarVenda.Rows.Add(
                              label1.Text,
                              lblValorTotalProdutoDinheiro.Text,
                              label2.Text);

            //----------------------------------------------------

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.pnlPdvFinalVenda.Controls.Clear();
            frmPdvFormaPagamento frmPdvFormaPagamento_Vrb = new frmPdvFormaPagamento() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPdvFormaPagamento_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlPdvFinalVenda.Controls.Add(frmPdvFormaPagamento_Vrb);
            frmPdvFormaPagamento_Vrb.Show();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        public void CalcularTotais()
        {
            //Declaração de variáveis
            decimal total;
            decimal desconto;
            decimal totalGeral;






            //Atribuição dos valores do form às variáveis
            total = Convert.ToDecimal(lblValorTotalProdutoDinheiro.Text);
            desconto = Convert.ToDecimal(txtDesconto.Text);



            if (chkDesconto.Checked == true)   //Verificar se o desconto está habilitado
            {
                desconto = Convert.ToDecimal(txtDesconto.Text);
                //Cálculo
                totalGeral = total - (total * (desconto / 100));

                lblDescontoTotal.Text = totalGeral.ToString("F");


            }



        }

        public void CalcularTroco()
        {
            decimal valorTotal;
            decimal recebido;
            decimal troco;




            if (chkDesconto.Checked == true)   //Verificar se o desconto está habilitado
            {
                valorTotal = Convert.ToDecimal(lblDescontoTotal.Text);
                //Cálculo
                recebido = Convert.ToDecimal(txtValorRecebido.Text);

                troco = recebido - valorTotal;

                lblTrocoDinheiro.Text = troco.ToString("F");
            }
            else
            {
                valorTotal = Convert.ToDecimal(lblValorTotalProdutoDinheiro.Text);
                recebido = Convert.ToDecimal(txtValorRecebido.Text);

                troco = recebido - valorTotal;

                lblTrocoDinheiro.Text = troco.ToString("F");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarFormaPagamento_Click(object sender, EventArgs e)
        {
            cboFormaPagamento2.Visible = true;
            txtFormaPagamento2.Visible = true;
            btnAddFormaPagamento2.Visible = true;
        }

        private void btnAddFormaPagamento2_Click(object sender, EventArgs e)
        {
            //variavel que recebe o valor total depois da subtrção
            decimal valorTotal2;
            //valor total
            decimal valorTotal;
            //valor da forma de pagamento 2
            decimal valorforma;



            valorTotal = Convert.ToDecimal(lblValorTotalProdutoDinheiro.Text);

            valorforma = Convert.ToDecimal(txtFormaPagamento2.Text);

            valorTotal2 = valorTotal - valorforma;

            //Remover a linha antiga do  DataGridView 
            dgvFinalizarVenda.Rows.RemoveAt(dgvFinalizarVenda.CurrentRow.Index);

            //Adicionar linha com o valor da forma de pagamento secundária
            dgvFinalizarVenda.Rows.Add(
                  label1.Text,
                  valorTotal2,
                  label2.Text);

            //Adicionar linha ao dgv com a subtrção
            dgvFinalizarVenda.Rows.Add(label1.Text, txtFormaPagamento2.Text, cboFormaPagamento2.SelectedItem);

            FormaPagamento2 formapagamento2 = new FormaPagamento2();
            produtosDTO dados = new produtosDTO();


            dados.formapagamento2 = (string)cboFormaPagamento2.SelectedItem;
            dados.valor2 = valorTotal2;

            //chamar o metodo
            formapagamento2.AtualizarFormaPagamento(dados);
            //Popular a classe

            MessageBox.Show(dados.mensagens);

            cboFormaPagamento2.TabIndex = 1;
            txtFormaPagamento2.Clear();





        }

        private void txtFormaPagamento2_TextChanged(object sender, EventArgs e)
        {
            //variavel que recebe o valor total depois da subtrção
            decimal valorTotal2;
            //valor total
            decimal valorTotal;
            //valor da forma de pagamento 2
            decimal valorforma;



            valorTotal = Convert.ToDecimal(lblValorTotalProdutoDinheiro.Text);

            valorforma = Convert.ToDecimal(txtFormaPagamento2.Text);

            valorTotal2 = valorTotal - valorforma;

            //Remover a linha antiga do  DataGridView 
            dgvFinalizarVenda.Rows.RemoveAt(dgvFinalizarVenda.CurrentRow.Index);

            //Adicionar linha com o valor da forma de pagamento secundária
            dgvFinalizarVenda.Rows.Add(
                  label1.Text,
                  valorTotal2,
                  label2.Text);

            //Adicionar linha ao dgv com a subtrção
            dgvFinalizarVenda.Rows.Add(label1.Text, txtFormaPagamento2.Text, cboFormaPagamento2.SelectedItem);

            FormaPagamento2 formapagamento2 = new FormaPagamento2();
            produtosDTO dados = new produtosDTO();


            dados.formapagamento2 = (string)cboFormaPagamento2.SelectedItem;
            dados.valor2 = valorTotal2;

            //chamar o metodo
            formapagamento2.AtualizarFormaPagamento(dados);
            //Popular a classe

            MessageBox.Show(dados.mensagens);

            cboFormaPagamento2.TabIndex = 1;


        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda finalizada!");

            this.pnlPdvFinalVenda.Controls.Clear();
            frmPdvPedidos frmPdvPedidos_Vrb = new frmPdvPedidos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPdvPedidos_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlPdvFinalVenda.Controls.Add(frmPdvPedidos_Vrb);


            frmPdvPedidos_Vrb.Show();


        }

        private void lblValorTotalProdutoDinheiro_Click(object sender, EventArgs e)
        {

        }

        private void chkDesconto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesconto.Checked == true)
            {
                txtDesconto.Visible = true;
                txtDesconto.Focus();
                txtDesconto.Clear();
            }
            else
            {
                txtDesconto.Visible = false;
                txtDesconto.Clear();
            }
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            if (txtValorRecebido.Text != "")
            {
                CalcularTroco();

                if (chkDesconto.Checked == true)
                {
                    CalcularTroco();
                }
            }

            else
            {
                lblTrocoDinheiro.Text = "0,00";
            }
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            codigosGerais c = new codigosGerais();

            if (c.campoVazio(txtDesconto))
            {
                return;
            }
            /*
                        if (chkDesconto.Checked != true)
                        {
                            MessageBox.Show("Desconto desativado");

                        }*/
            else
            {
                CalcularTotais();
            }
            CalcularTroco();
        }
    }
}


