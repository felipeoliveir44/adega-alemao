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
    public partial class frmFecharCaixa : Form
    {
        public frmFecharCaixa()
        {
            InitializeComponent();

            FecharCaixa();

        }
        /*decimal ValorDinheiro;
        decimal ValorDebito;
        decimal ValorCredito;
        decimal ValorPix;*/
        decimal ValorTotal;
        decimal ValorDinheiroRetirar;
        decimal ValorTotalRetirado;

        decimal valordebito;
        decimal valordebito2;
        decimal valortotaldebito;

        decimal valordinheiro;
        decimal valordinheiro2;
        decimal valortotaldinheiro;

        decimal valorcredito;
        decimal valorcredito2;
        decimal valortotalcredito;

        decimal valorpix;
        decimal valorpix2;
        decimal valortotalpix;

        decimal valortotal;


        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {

                //Verifica se já existe alguma vírgula na string
                if (txtValor.Text.Contains(","))
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

        private void btnAvancar_Click(object sender, EventArgs e)
        {

            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja fechar o caixa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                ValorDinheiroRetirar = Convert.ToDecimal(txtValor.Text);

                ValorTotalRetirado = valortotaldinheiro - ValorDinheiroRetirar;

                if (ValorDinheiroRetirar > valortotaldinheiro)
                {
                    MessageBox.Show("Não é possível retirar o dinheiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ValorTotal = valortotal - ValorDinheiroRetirar;



                    lblValorDinheiro.Text = ValorTotalRetirado.ToString();

                    lblValorTotal.Text = ValorTotal.ToString("F");
                    //Sua rotina de exclusão
                    //Confirmando exclusão para o usuário
                    

                    

                        //Instaciar as classes
                        FechandoCaixa fechandocaixa = new FechandoCaixa();
                        fecharcaixaDTO dados = new fecharcaixaDTO();

                        dados.valortotal = Convert.ToDecimal(lblValorTotal.Text);
                        dados.valorRetirada = Convert.ToDecimal(txtValor.Text);


                        fechandocaixa.Fechando(dados);
                    MessageBox.Show(dados.mensagens);


                }
            }
        }


       public void FecharCaixa()
        {
            try
            {
                




                //Instaciar as classes
                FechamentoCaixa fechamentocaixa = new FechamentoCaixa();
                fecharcaixaDTO dados = new fecharcaixaDTO();

                dados.Dinheiro = lblDinheiro1.Text;
                dados.Debito = lblDebito.Text;
                dados.Credito = lblCredito.Text;
                dados.Pix = lblPixIcon.Text;

                fechamentocaixa.fechamentocaixa(dados);

                

                valordebito = Convert.ToDecimal(dados.Debito);
                valordebito2 = Convert.ToDecimal(dados.Debito2);
                valortotaldebito = valordebito + valordebito2;

                valordinheiro = Convert.ToDecimal(dados.Dinheiro);
                valordinheiro2 = Convert.ToDecimal(dados.Dinheiro2);
                valortotaldinheiro = valordinheiro + valordinheiro2;

                valorcredito = Convert.ToDecimal(dados.Credito);
                valorcredito2 = Convert.ToDecimal(dados.Credito2);
                valortotalcredito = valorcredito + valorcredito2;

                valorpix = Convert.ToDecimal(dados.Pix);
                valorpix2 = Convert.ToDecimal(dados.Pix2);
                valortotalpix = valorpix + valorpix2;


                lblValorDinheiro.Text = Convert.ToString(valortotaldinheiro);
                lblValorDebito.Text = Convert.ToString(valortotaldebito);
                lblValorCredito.Text = Convert.ToString(valortotalcredito);
                lblPixValor.Text = Convert.ToString(valortotalpix);

                valortotal = valortotaldinheiro + valortotaldebito + valortotalcredito + valortotalpix;

                /*ValorDinheiro = Convert.ToDecimal(lblValorDinheiro.Text);
               ValorDebito = Convert.ToDecimal(lblValorDebito.Text);
               ValorCredito = Convert.ToDecimal(lblValorCredito.Text);
               ValorPix = Convert.ToDecimal(lblPixValor.Text);
               ValorTotal = ValorDinheiro + ValorDebito + ValorCredito + ValorPix;*/

               lblValorTotal.Text = valortotal.ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Contate o Suporte \r\n " + ex.ToString(),
                       "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
