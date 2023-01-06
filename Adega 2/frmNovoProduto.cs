using MySql.Data.MySqlClient;
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
    public partial class frmNovoProduto : Form
    {
        public frmNovoProduto()
        {
            InitializeComponent();
        }

        private void btnVoltarAddProduto_Click(object sender, EventArgs e)
        {
            this.pnlAddProduto.Controls.Clear();
            frmFiltrarEstoque frmEstoque_Vrb = new frmFiltrarEstoque() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlAddProduto.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();
        }

        private void btnAdicionarAddProdutos_Click(object sender, EventArgs e)
        {

           
                //tratamento dos campos - verificar se todos os campos foram preenchidos

                //Instanciar as classes
                SalvarProduto salvarproduto = new SalvarProduto();
                produtosDTO dados = new produtosDTO();

            codigosGerais c = new codigosGerais();

            if (c.campoVazio(txtNomeAddProduto) == true)
                return;

            if (c.campoVazio(txtUnidadeAddProduto))
                return;

            if (c.campoVazio(txtPrecoAddProdutoQuente))
                return;

            if (c.campoVazio(txtPrecoAddProdutoGelado))
                return;

            if (c.campoVazio(txtPrecoAddProdutoCusto))
                return;

            if (c.campoVazio(txtQntdEstoqueAddProduto))
                return;

            if (c.campoVazio(cboCategorias))
                return;


            //Popular a classe
            dados.nomeproduto = txtNomeAddProduto.Text;
                dados.unidade = txtUnidadeAddProduto.Text;
                dados.precoquente = Convert.ToDecimal(txtPrecoAddProdutoQuente.Text);
                dados.precogelado = Convert.ToDecimal(txtPrecoAddProdutoGelado.Text);
                dados.precocusto = Convert.ToDecimal(txtPrecoAddProdutoCusto.Text);
                dados.qntdestoque = txtQntdEstoqueAddProduto.Text;
                dados.categoria = cboCategorias.Text;

            //chamar o metodo
            salvarproduto.ProdutosIncluir(dados);

                //verifcar o resultado

                MessageBox.Show(dados.mensagens);

            //Campo Obrigatorio


            

        }
        
        
        private void btnLimparAddProduto_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        public void LimparCampos()
        {
           
            txtNomeAddProduto.Clear();
            txtUnidadeAddProduto.Clear();
            txtPrecoAddProdutoQuente.Clear();
            txtQntdEstoqueAddProduto.Clear();
            txtPrecoAddProdutoGelado.Clear();
            txtPrecoAddProdutoCusto.Clear();
            cboCategorias.SelectedIndex = -1;
            
        }

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
                cboCategorias.DataSource = null;
                cboCategorias.Items.Clear();

                //Popular o combobox
                //Alem do nome, sera armazenado tambem o codigo (este nao sera visivel)
                cboCategorias.ValueMember = "cod_categoria";
                cboCategorias.DisplayMember = "nome_categoria";

                //Associar a fonte de daos 
                cboCategorias.DataSource = consultarcategorias.CategoriasDataTable;

                //Posicionar no item em branco do combobox
                cboCategorias.SelectedIndex = -1;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
        }

        private void frmNovoProduto_Load(object sender, EventArgs e)
        {
            ListarCategoria();
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carregar o nome da categoria no textbox
            //cboCategorias.Text = cboCategorias.Text;


            //Carregar o nome da categoria no TexBox
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtPrecoAddProdutoQuente_num(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {   

                    //Verifica se já existe alguma vírgula na string
                    if (txtPrecoAddProdutoQuente.Text.Contains(","))
                    {
                        e.Handled = true; // Caso exista, aborte 
                    }
                }

                //aceita apenas números, tecla backspace.
                else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPrecoAddProdutoGelado_num(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {

                    //Verifica se já existe alguma vírgula na string
                    if (txtPrecoAddProdutoGelado.Text.Contains(","))
                    {
                        e.Handled = true; // Caso exista, aborte 
                    }
                }

                //aceita apenas números, tecla backspace.
                else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPrecoAddProdutoCusto_num(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {

                    //Verifica se já existe alguma vírgula na string
                    if (txtPrecoAddProdutoCusto.Text.Contains(","))
                    {
                        e.Handled = true; // Caso exista, aborte 
                    }
                }

                //aceita apenas números, tecla backspace.
                else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtQntdEstoqueAddProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPrecoAddProdutoQuente_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

  /*  public void InsertDBProdutos()
        {
            TestarDTO testarConexao = new TestarDTO();
            testarConexao.Verificar();
            string insert = "call spIncluirProdutos ('" + txtNomeAddProduto.Text + "'," +
                " '" + txtUnidadeAddProduto.Text + "'," +
                " '" + txtPrecoAddProduto.Text + "'," +
                " '" + txtQntdEstoqueAddProduto.Text + "'," +
                "'" + txtCategoriaAddProduto.Text + "')";

            MySqlCommand comando = new MySqlCommand(insert, testarConexao.conectar);
            comando.ExecuteReader();

            MessageBox.Show("Produto adicionado com sucesso!", "Aviso");
        }
    }*/

