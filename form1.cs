using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAuE
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataAdapter adaptador;
        private DataTable tabelacontatos;
        


        public Form1()
        {
            InitializeComponent();
            string stringConexao = "datasource=localhost;username=root;password=;database=aueolucoes";
            conexao = new MySqlConnection(stringConexao);
            comando = new MySqlCommand();
            adaptador = new MySqlDataAdapter(comando);
            tabelacontatos = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string nome;
            string sexo = checkBox1.Checked ? "Masculino" : "Feminino";
            string cidade;
            DateTime data_nascimento;


            nome = textBox1.Text;
            cidade = textBox2.Text;
            data_nascimento = dateTimePicker1.Value;




            listBox1.Items.Add("Nome: " + nome);
            listBox1.Items.Add("Cidade: " + cidade);
            listBox1.Items.Add("Data: " + data_nascimento);

            IncluirUsuario(nome, sexo, cidade, data_nascimento);


        }



        private void IncluirUsuario(string nome, string sexo, string cidade, DateTime data_nascimento)
        {
            try
            {
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO tabelacontatos (nome, sexo, cidade, data_nascimento) VALUES (@nome, @sexo, @cidade, @dataNascimento)";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@sexo", sexo);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@dataNascimento", data_nascimento);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir usuário: " + ex.Message);
            }
            finally
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string sexo = checkBox1.Text;
            string cidade = textBox2.Text;
            DateTime dataNascimento = dateTimePicker1.Value;

            string query = "UPDATE tabelacontatos SET sexo = @sexo, cidade = @cidade, data_nascimento = @dataNascimento WHERE nome = @nome";

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@sexo", sexo);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);

                listBox1.Items.Add("Nome: " + nome);
                listBox1.Items.Add("Cidade: " + cidade);
                listBox1.Items.Add("Data: " + dataNascimento);
                listBox1.Items.Add("Sexo: " + sexo);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi alterado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;

            try
            {
                conexao.Open();
                string query = "DELETE FROM tabelacontatos WHERE nome = @Nome";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@Nome", nome);
                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Dados excluídos com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum dado foi excluído.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados: " + ex.Message);
            }
            finally
            {
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;username=root;password=;database=aueolucoes";
            string query = "SELECT COUNT(*), cidade, data FROM tabelacontatos GROUP BY cidade, data";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    StringBuilder result = new StringBuilder();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        int quantidade = Convert.ToInt32(row[0]);
                        string cidade = row[1].ToString();
                        DateTime data = Convert.ToDateTime(row[2]);

                        result.AppendLine($"Quantidade: {quantidade}");
                        result.AppendLine($"Cidade: {cidade}");
                        result.AppendLine($"Data: {data}");
                        result.AppendLine("------------------------");
                    }

                    
                    listBox2.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                }
            }

            Console.ReadLine();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
