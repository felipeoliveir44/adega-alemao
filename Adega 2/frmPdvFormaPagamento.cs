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
    public partial class frmPdvFormaPagamento : Form
    {
        public frmPdvFormaPagamento()
        {
            InitializeComponent();
        }

        decimal totalPagar;
        
        



        public frmPdvFormaPagamento(string totalPagamento)
        {
            InitializeComponent();
            totalPagar = Convert.ToDecimal(totalPagamento);
            
 
        }
        
        private void btnDinheiro_Click_1(object sender, EventArgs e)
        {
            //this.pnlPdvFormaPagamento.Controls.Clear();
            frmPdvFinalizarVenda frmFinVenda_Vrb = new frmPdvFinalizarVenda(totalPagar) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFinVenda_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlPdvFormaPagamento.Controls.Add(frmFinVenda_Vrb);
            
            frmFinVenda_Vrb.BringToFront();
            frmFinVenda_Vrb.Show();

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {/*
            //this.pnlPdvFormaPagamento.Controls.Clear();
            frmPdvPedidos frmPdvPedidos_Vrb = new frmPdvPedidos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPdvPedidos_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlPdvFormaPagamento.Controls.Add(frmPdvPedidos_Vrb);
            
            frmPdvPedidos_Vrb.BringToFront();
            frmPdvPedidos_Vrb.Show();
            */

            this.Close();
        }

        
    }
}
