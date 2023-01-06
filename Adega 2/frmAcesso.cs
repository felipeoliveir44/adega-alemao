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
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            string msg = "Teste da conexão com o Banco de dados.";


            //instanciar a classe
            TestarDTO testarConexao = new TestarDTO();


            //Chamar método
            testarConexao.Verificar();


            //Determinar o tamanho máximo na label
            lblTeste.MaximumSize = new Size(700, 0);


            //Qual o retorno?

            if (testarConexao.conectar == null)
            {
                lblTeste.BackColor = Color.Red;
                lblTeste.Text = msg + " Falhou!";
                MessageBox.Show(testarConexao.mensagem, "Aviso");
            }
            else
            {
                lblTeste.BackColor = Color.Green;
                lblTeste.Text = msg + " OK!";
            }
        }
    }
}
