using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaDados;

namespace Adega_2
{
    public class codigosGerais
    {
        public bool campoVazio(Control controle)
        {
            if (controle.Text == "")
            {

                MessageBox.Show("Não é possível inserir campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controle.Focus();
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
