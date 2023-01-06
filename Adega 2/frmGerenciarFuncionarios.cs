using MySql.Data.MySqlClient;
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
    public partial class frmGerenciarFuncionarios : Form
    {
        public frmGerenciarFuncionarios()
        {
            InitializeComponent();

            
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            // InsertDB();
            //tratamento dos campos - verificar se todos os campos foram preenchidos

            //Instanciar as classes
            SalvarUsuario salvarususario = new SalvarUsuario();
            UsuariosDTO dados = new UsuariosDTO();

            //Popular a classe
            dados.nome = txtCdtNome.Text;
            dados.senha = txtCdtSenha.Text;
            dados.email = txtCdtEmail.Text;
            dados.cpf = mskCdtCpf.Text;
            dados.statusfuncionario = cboCdtSttsFuncionario.Text;
            dados.funcao = cboCdtFuncaoFuncionario.Text;
            dados.datanascimento = mskCdtDataNascimento.Text;
            dados.datacontratacao = mskCdtDataContratacao.Text;
            dados.fone = mskCdtFone.Text;

            codigosGerais c = new codigosGerais();

            if (c.campoVazio(txtCdtNome) == true)
                return;

            if (c.campoVazio(txtCdtSenha))
                return;

            if (c.campoVazio(cboCdtFuncaoFuncionario))
                return;

            if (c.campoVazio(txtCdtEmail))
                return;

            if (c.campoVazio(cboCdtSttsFuncionario))
                return;

            if (c.campoVazio(mskCdtCpf))
                return;

            if (c.campoVazio(mskCdtDataContratacao))
                return;

            if (c.campoVazio(mskCdtDataNascimento))
                return;

            if (c.campoVazio(mskCdtFone))
                return;


            string tel = mskCdtFone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            //MessageBox.Show(tel);
            if (tel.Length == 11)
            {
                dados.fone = mskCdtFone.Text;
            }
            else
            {
                //Mensagem
                MessageBox.Show("Não é possível inserir campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCdtFone.Focus();
                return;
            }


            string cpf = mskCdtCpf.Text.Replace("-", "").Replace(".", "").Replace(" ", "");
            //MessageBox.Show(tel);
            if (cpf.Length == 11)
            {
                dados.cpf = mskCdtCpf.Text;
            }
            else
            {
                //Mensagem
                MessageBox.Show("Não é possível inserir campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCdtCpf.Focus();
                return;
            }


            string cont = mskCdtDataContratacao.Text.Replace("/", "");
            //MessageBox.Show(tel);
            if (cont.Length == 8)
            {
                dados.datacontratacao = mskCdtDataContratacao.Text;
            }
            else
            {
                //Mensagem
                MessageBox.Show("Não é possível inserir campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCdtDataContratacao.Focus();
                return;
            }


            string nasci = mskCdtDataNascimento.Text.Replace("/", "");
            //MessageBox.Show(tel);
            if (nasci.Length == 8)
            {
                dados.datanascimento = mskCdtDataNascimento.Text;

            }
            else
            {
                //Mensagem
                MessageBox.Show("Não é possível inserir campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCdtDataNascimento.Focus();
                return;
            }

            //chamar o metodo
            salvarususario.UsuarioIncluir(dados);

            //verifcar o resultado
            if (dados.mensagens == null)
            {
                if (dados.id > 0)
                {
                    txtCdtId.Text = dados.id.ToString();

                    MessageBox.Show("Registros inseridos com sucesso");

                }

                else
                {

                    MessageBox.Show("Não foi possivel inserir registros");

                }

            }

            else
            { 

                MessageBox.Show(dados.mensagens);
            }

        }

     

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciar as classes ConsultarProdutos
                Consultarfuncionarios consultarfuncionarios = new Consultarfuncionarios();

                UsuariosDTO dados = new UsuariosDTO();

                //popular a classe
                dados.nome = cbofuncionario.Text;

                //chamar o metodo para consultar
                consultarfuncionarios.ListarFuncionarios(dados);

                //Limpar o grid
                dgvListarFuncionarios.Rows.Clear();

                //verificar o retorno do metodo
                if (dados.mensagens == null)
                {
                    //Preencher o grid com os dados do DataTable
                    // se i (linha) for igual a 0 e rows count = quantidade de linhas
                    for (int i = 0; i < consultarfuncionarios.FuncionariosDataTable.Rows.Count; ++i)
                    {
                        dgvListarFuncionarios.Rows.Add(//consultarprodutos.ProdutosDataTable.Rows[i]["codproduto"],
                                           consultarfuncionarios.FuncionariosDataTable.Rows[i]["id"],
                                           consultarfuncionarios.FuncionariosDataTable.Rows[i]["nome"],
                                           consultarfuncionarios.FuncionariosDataTable.Rows[i]["email"],
                                            consultarfuncionarios.FuncionariosDataTable.Rows[i]["cpf"],
                                           consultarfuncionarios.FuncionariosDataTable.Rows[i]["status_funcionario"],
                                           consultarfuncionarios.FuncionariosDataTable.Rows[i]["funcao"],
                                            consultarfuncionarios.FuncionariosDataTable.Rows[i]["data_nascimento"],
                                           consultarfuncionarios.FuncionariosDataTable.Rows[i]["data_contratacao"],
                                           consultarfuncionarios.FuncionariosDataTable.Rows[i]["fone"]);


                        
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
            cbofuncionario.SelectedIndex = -1;
           
        }






        public void ListarFuncionarios()
        {
            try
            {
                //Instaciar as classes
                Consultarfuncionarios consultarfuncionarios = new Consultarfuncionarios();

                UsuariosDTO dados = new UsuariosDTO();

                //Chamar o método para consulta
                consultarfuncionarios.ListarFuncionarios(dados);

                //Limpar a fonte de dados
                cbofuncionario.DataSource = null;
                cbofuncionario.Items.Clear();

                //Popular o combobox
                //Alem do nome, sera armazenado tambem o codigo (este nao sera visivel)
                cbofuncionario.ValueMember = "id";
                cbofuncionario.DisplayMember = "nome";

                //Associar a fonte de daos 
                cbofuncionario.DataSource = consultarfuncionarios.FuncionariosDataTable;

                //Posicionar no item em branco do combobox
                cbofuncionario.SelectedIndex = -1;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
        }




        private void cbofuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbofuncionario.Text = cbofuncionario.Text;
        }

        private void frmGerenciarFuncionarios_Load(object sender, EventArgs e)
        {
            ListarFuncionarios();
        }

        private void dgvListarFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCdtId.Text = dgvListarFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCdtNome.Text = dgvListarFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCdtEmail.Text = dgvListarFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskCdtCpf.Text = dgvListarFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboCdtSttsFuncionario.Text = dgvListarFuncionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            cboCdtFuncaoFuncionario.Text = dgvListarFuncionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
            mskCdtDataNascimento.Text = dgvListarFuncionarios.Rows[e.RowIndex].Cells[6].Value.ToString(); ;
            mskCdtDataContratacao.Text = dgvListarFuncionarios.Rows[e.RowIndex].Cells[7].Value.ToString(); ;
            mskCdtFone.Text = dgvListarFuncionarios.Rows[e.RowIndex].Cells[8].Value.ToString(); ;
        }

        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            AtualizarUsuario atualizarusuario = new AtualizarUsuario();
            UsuariosDTO dados = new UsuariosDTO();

            //Popular a classe
            dados.id = Convert.ToInt32(txtCdtId.Text);
            dados.nome = txtCdtNome.Text;
            dados.senha = txtCdtSenha.Text;
            dados.email = txtCdtEmail.Text;
            dados.cpf = mskCdtCpf.Text;
            dados.statusfuncionario = cboCdtSttsFuncionario.Text;
            dados.funcao = cboCdtFuncaoFuncionario.Text;
            dados.datanascimento = mskCdtDataNascimento.Text;
            dados.datacontratacao = mskCdtDataContratacao.Text;
            dados.fone = mskCdtFone.Text;

            //chamar o metodo
            atualizarusuario.UsuarioAtualizar(dados);

            //verifcar o resultado
            MessageBox.Show(dados.mensagens);
        }
    }
}
