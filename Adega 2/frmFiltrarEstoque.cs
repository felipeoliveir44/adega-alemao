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
    public partial class frmFiltrarEstoque : Form
    {
        public frmFiltrarEstoque()
        {
            InitializeComponent();
        }

        private void btnProcurarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciar as classes ConsultarProdutos
                ConsultarProdutos consultarprodutos = new ConsultarProdutos();
                produtosDTO dados = new produtosDTO();

                //popular a classe
                dados.nomeproduto = txtFiltrar.Text;

                //chamar o metodo para consultar
                consultarprodutos.ProdutosConsultar(dados);

                //Limpar o grid
                dgvEstoque.Rows.Clear();

                //verificar o retorno do metodo
                if (dados.mensagens == null)
                {
                    //Preencher o grid com os dados do DataTable
                    // se i (linha) for igual a 0 e rows count = quantidade de linhas
                    for (int i = 0; i < consultarprodutos.ProdutosDataTable.Rows.Count; i++)
                    {
                        dgvEstoque.Rows.Add(//consultarprodutos.ProdutosDataTable.Rows[i]["codproduto"],
                                            consultarprodutos.ProdutosDataTable.Rows[i]["nome_produto"],
                                            consultarprodutos.ProdutosDataTable.Rows[i]["unidade"],
                                            consultarprodutos.ProdutosDataTable.Rows[i]["qntd_estoque"],
                                            consultarprodutos.ProdutosDataTable.Rows[i]["categoria"]);
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
        }
    }
}
