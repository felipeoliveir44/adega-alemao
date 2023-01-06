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
    public partial class frmTesteAutoComplete : Form
    {
        public frmTesteAutoComplete()
        {
            InitializeComponent();
        }

        //Coleção para auto complete
        AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();



        //metodo para autocompletar

        private void AutoCompletar()
        {
            try
            {
                //Instaciar as classes
                ConsultarrCategorias consultarcategorias = new ConsultarrCategorias();
                categoriasDTO dados = new categoriasDTO();

                //Chamar o método para consulta
                consultarcategorias.ListarCategorias(dados);


                if (dados.mensagens == null)
                {
                    if(consultarcategorias.CategoriasDataTable.Rows.Count > 0)
                    {
                        //percorrer o DataTable
                        for (int i = 0; i < consultarcategorias.CategoriasDataTable.Rows.Count; i++)
                        {
                            //Preencher o array AutoComplete
                            autocomplete.Add(consultarcategorias.CategoriasDataTable.Rows[i]["nome_categoria"].ToString());

                        }

                        //definir as prpriedades para o autocomplete do textbox
                        txtNomeAuto.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txtNomeAuto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtNomeAuto.AutoCompleteCustomSource = autocomplete;


                    }
                }
                else
                {
                    MessageBox.Show(dados.mensagens);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
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
                cboCategoriasAuto.DataSource = null;
                cboCategoriasAuto.Items.Clear();

                //Popular o combobox
                //Alem do nome, sera armazenado tambem o codigo (este nao sera visivel)
                cboCategoriasAuto.ValueMember = "cod_categoria";
                cboCategoriasAuto.DisplayMember = "nome_categoria";

                //Associar a fonte de daos 
                cboCategoriasAuto.DataSource = consultarcategorias.CategoriasDataTable;

                //Posicionar no item em branco do combobox
                cboCategoriasAuto.SelectedIndex = -1;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
        }

        private void frmTesteAutoComplete_Load(object sender, EventArgs e)
        {
            ListarCategoria();
            AutoCompletar();
        }

        private void cboCategoriasAuto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Carregar o codigo da categoria no text box
            //txtNomeAuto.Text = cboCategoriasAuto.SelectedValue.ToString();
        }

        private void cboCategoriasAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carregar o nome da categoria no textbox
            txtNomeAuto.Text = cboCategoriasAuto.Text;
        }


    }
}
