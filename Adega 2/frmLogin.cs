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
    public partial class frmLogin : Form
    {
        //declaração de variaveis e atribuir valor
        public bool LoginSucesso = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        { // Rotinas de verificar todos os campos
            try
            {

                ValidarUsuario ValidarUsuario = new ValidarUsuario();
                UsuariosDTO dados = new UsuariosDTO();


                // Popular a classe
                dados.email = txtUsuarioLogin.Text;
                dados.senha = txtSenhaUsuario.Text;

                //chamar o metodo
                ValidarUsuario.VerificarUsuario(dados);



                if (dados.mensagens == null)
                {

                    if (LoginSistema.nome != null)
                    {
                        LoginSucesso = true;

                        MessageBox.Show("Bem vindo ao Sistema", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (LoginSucesso == true)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha Incorretos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //limpar os campos e posicionar o cursor no nome usuarios
                        txtSenhaUsuario.Clear();
                        txtUsuarioLogin.Clear();

                        LoginSucesso = false;
                    }
                }
                else
                {
                    MessageBox.Show("Contate o suporte \r\n" + dados.mensagens, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

    }
}

