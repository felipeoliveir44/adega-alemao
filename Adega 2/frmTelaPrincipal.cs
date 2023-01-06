using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Adega_2
{
    public partial class frmTelaPrincipal : Form
    {
 

        


        public frmTelaPrincipal()
        {
            InitializeComponent();

            this.pnlFormLoader.Controls.Clear();
            frmGerenciarFuncionarios frmEstoque_Vrb = new frmGerenciarFuncionarios() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();

        }

        
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Close(); // Fechar programa
            }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            frmEstoque frmEstoque_Vrb = new frmEstoque() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            frmVendas frmEstoque_Vrb = new frmVendas() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            frmPdvPedidos frmEstoque_Vrb = new frmPdvPedidos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            frmGerenciarFuncionarios frmEstoque_Vrb = new frmGerenciarFuncionarios() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            frmFecharCaixa frmEstoque_Vrb = new frmFecharCaixa() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmEstoque_Vrb);
            frmEstoque_Vrb.Show();
        }

     
    }
}
