using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adega_2
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();

            this.pnlEstoque.Controls.Clear();
            frmFiltrarEstoque frmEstoque_Vrb = new frmFiltrarEstoque() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlEstoque.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();
        }

        private void dgvEstoque_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Evento utilizado para desenhar na célula

            //Verificar se é a linha do cabeçalho 
            //Verificar qual a coluna que irá receber a imagem

            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 5)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    //Retornar a largura da imagem contida no arquivo de recursos
                    var w = Properties.Resources.editar.Width;

                    //Retornar a altura da imagem contida no arquivo de recursos
                    var h = Properties.Resources.editar.Height;

                    //Definir o posicionamento da imagem na coluna ação, tendo como base a 
                    //altura e largura
                    var x = e.CellBounds.Left + (e.CellBounds.Width - 18) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - 18) / 2;

                    //Desenhar a imagem
                    e.Graphics.DrawImage(Properties.Resources.editar, new Rectangle(x, y, 18, 18));
                    e.Handled = true;
                }
            }
        }

       

        

     
        

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                MessageBox.Show("Teste - Linha " + e.RowIndex);
  
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            this.pnlEstoque.Controls.Clear();
            frmNovoProduto frmEstoque_Vrb = new frmNovoProduto() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlEstoque.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();
        }

  
    }

}


