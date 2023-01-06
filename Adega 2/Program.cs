using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adega_2
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTelaPrincipal());
           //Application.Run(new frmTelaPrincipal());

           /* frmLogin frm = new frmLogin();
              frm.ShowDialog();
              if(frm.LoginSucesso)
              {
                  Application.Run(new frmTelaPrincipal());
              }*/
        }
    }
    
}
