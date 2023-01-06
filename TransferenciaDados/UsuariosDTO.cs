using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace para acesso ao banco de dados

using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;

namespace TransferenciaDados
{
    public class UsuariosDTO
    {
        //Atributos
        public int id { get; set; }
        public string nome { get; set; }

        public string senha { get; set; }

        public string email { get; set; }

        public string cpf { get; set; }

        public string statusfuncionario { get; set; }

        public string funcao { get; set; }

        public string datanascimento { get; set; }

        public string datacontratacao { get; set; }

        public string fone { get; set; }

        public string mensagens { get; set; }

    }

    public class LoginSistema
    {
        public static int id { get; set; }
        public static string nome { get; set; }
        //mais pra frente ira entrar tipoPerfil (ADm ou funcionario)
    }





    public class ValidarUsuario
    {
        public void VerificarUsuario(UsuariosDTO dados)
        {
            //tratamento das exceções
            try
            {
                //definir comando para execução 
                MySqlCommand cmd = new MySqlCommand("spLoginFuncionario", Conexao.obterConexao());


                //Definir como storedProcedure 
                cmd.CommandType = CommandType.StoredProcedure;

                //paramentros de entrada (input)
                cmd.Parameters.AddWithValue("@pEmail", dados.email);
                cmd.Parameters.AddWithValue("@pSenha", dados.senha);

                //executar os comandos sql
                MySqlDataReader dr = cmd.ExecuteReader();



                if (dr.HasRows)
                {
                    //Pecorrer os registros
                    while (dr.Read())
                    {
                        //Popular com o resultado
                        LoginSistema.id = Convert.ToInt32(dr.GetValue(0).ToString());

                        LoginSistema.nome = (dr.GetValue(1).ToString());

                    }
                }
                dr.Close();
                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {

                dados.mensagens = "Erro - ValidarUsuario - VerificarUsuarios \r\n " + e.Message.ToString();
            }




        }




    }








    public class SalvarUsuario
    {

        public void UsuarioIncluir(UsuariosDTO dados)
        {
            try
            {

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spIncluirFuncionarios", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Popular o parametro


                cmd.Parameters.AddWithValue("@pnome", dados.nome);
                cmd.Parameters.AddWithValue("@psenha", dados.senha);
                cmd.Parameters.AddWithValue("@pemail", dados.email);
                cmd.Parameters.AddWithValue("@pcpf", dados.cpf);
                cmd.Parameters.AddWithValue("@pstatusFuncionario", dados.statusfuncionario);
                cmd.Parameters.AddWithValue("@pfuncao", dados.funcao);
                cmd.Parameters.AddWithValue("@pdataNascimento", dados.datanascimento);
                cmd.Parameters.AddWithValue("@pdataContratacao", dados.datacontratacao);
                cmd.Parameters.AddWithValue("@pfone", dados.fone);

                //Executar os comandos SQL
                //Tabela temporaria
                MySqlDataReader dr = cmd.ExecuteReader();

                //Verificar a existencia de registros
                if (dr.HasRows)
                {
                    //Percorre os registros
                    while (dr.Read())
                    {
                        dados.id = Convert.ToInt32(dr.GetValue(0).ToString());
                    }
                }
                dr.Close();

                /*
                int registrosinseridos = cmd.ExecuteNonQuery();
                //verificar se os registros foram inseridos
                switch (registrosinseridos)
                {
                    case 2:
                        dados.mensagens = "Registros inseridos com sucesso";
                        break;

                    default:
                        dados.mensagens = "Não foi possivel inserir registros";
                        break;
                }

                */

                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {

                dados.mensagens = "Erro - SalvarUsuario - UsuariosIncluir" + e.Message.ToString();

            }
        }

        /*public void LoginFuncionario(UsuariosDTO dados)
        {
            try
            {
                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spLoginFuncionario", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                // Popular o parametro
                cmd.Parameters.AddWithValue("pNome", dados.nome);
                cmd.Parameters.AddWithValue("pSenha", dados.senha);
                int login = cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dataTable);

                foreach (DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                        switch (login)
                        {
                            case 2:
                                dados.mensagens = "Bem-vindo ao sistema!";
                                break;

                            default:
                                dados.mensagens = "Usuário ou senha incorretos!";
                                break;
                        }
                    }

                }
            }
            catch (MySqlException e)
            {
                dados.mensagens = "Erro - SalvarUsuario - UsuariosIncluir " + e.Message.ToString();
            }
            Conexao.fecharConexao();
        }*/



    }


        public class Consultarfuncionarios
        {


            public DataTable FuncionariosDataTable { get; private set; }

            public void ListarFuncionarios(UsuariosDTO dados)
            {
                try
                {
                    //Definir comando para execução 
                    MySqlCommand cmd = new MySqlCommand("spConsultarFuncionarios", Conexao.obterConexao());

                    //Definir como Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Parâmetros de entrada (input)
                    cmd.Parameters.AddWithValue("@pnome", dados.nome);

                    //instanciar o DataAdapter
                    //dataAdapter representa i, conjunto de comandos sql e uma conexao de banco de dados
                    //que sao usados para preencher o DataSet e atualizar a fonte de dados.
                    MySqlDataAdapter FuncionariosDataAdapter = new MySqlDataAdapter();

                    //obter a intrução Transact-SQL
                    FuncionariosDataAdapter.SelectCommand = cmd;

                    //instaciar o dataTable
                    //dataTable é como um container que podemps isar para armazenar 
                    //dados de praticamente qualquer fonte de dados, sendo composto 
                    //por uma coleçao de linhas(rows) e colunas (columns)
                    FuncionariosDataTable = new DataTable();


                    //Ppopukar o dataTable 
                    FuncionariosDataAdapter.Fill(FuncionariosDataTable);
                }
                catch (MySqlException e)
                {
                    dados.mensagens = "Erro - ConsultarCategorias - ListarCategorias \r\n " + e.Message.ToString();
                }
            }
        }

    public class AtualizarUsuario
    {

        public void UsuarioAtualizar(UsuariosDTO dados)
        {
            try
            {

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spAtualizarFuncionarios", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //Popular o parametro

                cmd.Parameters.AddWithValue("@pid", dados.id);
                cmd.Parameters.AddWithValue("@pnome", dados.nome);
                cmd.Parameters.AddWithValue("@psenha", dados.senha);
                cmd.Parameters.AddWithValue("@pemail", dados.email);
                cmd.Parameters.AddWithValue("@pcpf", dados.cpf);
                cmd.Parameters.AddWithValue("@pstatusFuncionario", dados.statusfuncionario);
                cmd.Parameters.AddWithValue("@pfuncao", dados.funcao);
                cmd.Parameters.AddWithValue("@pdataNascimento", dados.datanascimento);
                cmd.Parameters.AddWithValue("@pdataContratacao", dados.datacontratacao);
                cmd.Parameters.AddWithValue("@pfone", dados.fone);

                //Executar os comandos SQL
                //Tabela temporaria
                MySqlDataReader dr = cmd.ExecuteReader();

                //Verificar a existencia de registros
                if (dr.HasRows)
                {
                    //Percorre os registros
                    while (dr.Read())
                    {
                        dados.id = Convert.ToInt32(dr.GetValue(0).ToString());
                    }
                }
                dr.Close();

                
                int registrosinseridos = cmd.ExecuteNonQuery();
                //verificar se os registros foram inseridos
                switch (registrosinseridos)
                {
                    case 2:
                        dados.mensagens = "Registros inseridos com sucesso";
                        break;

                    default:
                        dados.mensagens = "Não foi possivel inserir registros";
                        break;
                }

                

                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {

                dados.mensagens = "Erro - SalvarUsuario - UsuariosIncluir" + e.Message.ToString();

            }
        }
    }


    }


