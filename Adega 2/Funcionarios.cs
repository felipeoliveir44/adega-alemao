using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaDados;


namespace Adega_2
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string StatusFuncionario { get; set; }
        public string Funcao { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataContratacao { get; set; }
        public string Fone { get; set; }

        public static DataTable GetFuncionarios(bool Nome)
        {
            var dt = new DataTable();

            var select = "select * from tbfuncionarios";

            try
            {
                TestarDTO testarConexao = new TestarDTO();
                testarConexao.Verificar();

                var da = new MySqlDataAdapter(select, testarConexao.conectar);

                da.Fill(dt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

    }
}
