﻿using System.Data;
using System.Data.SqlClient;

namespace SupermercadoForm
{
    public partial class EstantesForms : Form
    {

        public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\egiac\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

        public EstantesForms()
        {
            InitializeComponent();
        }

        private void labelSigla_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarEstante();
        }

        public void CadastrarEstante()
        {
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            if(nome == String.Empty || sigla == String.Empty)
            {
                MessageBox.Show("Informe os campos necessários para realizar o cadastro");
                return;
            }

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO estantes (NOME, SIGLA) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@SIGLA", sigla);

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Estante cadastrada com sucesso!");
                textBoxNome.Clear();
                maskedTextBoxSigla.Clear();
                ListarEstantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o cadastro: " + ex.Message);
                return;
            }
            conexao.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarEstante();
        }
        private void EditarEstante()
        {
            string sigla = textBoxSiglaParaEditar.Text;
            string nome = textBoxNomeParaEditar.Text;
            string id = textBoxCodigoParaEditar.Text;

            if(sigla == String.Empty || nome == String.Empty || id == String.Empty)
            {
                MessageBox.Show("Informe todos os campos para realizar a edição!");
                return;
            }

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE estantes SET nome = '" + nome + "' , sigla = '" + sigla + "' WHERE id = " + id;

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Edição bem sucedida!");
                textBoxCodigoParaEditar.Clear();
                textBoxNomeParaEditar.Clear();
                textBoxSiglaParaEditar.Clear();
                ListarEstantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a edição: " + ex.Message);
                return;
            }
            conexao.Close();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarEstantes();
        }

        public void ListarEstantes()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select id, nome, sigla from estantes";

            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            dataGridViewEstantes.Rows.Clear();
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //obter o id e o nome do registro percorrido
                DataRow registro = tabelaEmMemoria.Rows[i];
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();
                string sigla = registro["sigla"].ToString();
                //listando categorias
                //adicionando as linhas da tabela em memoria para o datagrid, passando como objeto
                dataGridViewEstantes.Rows.Add(new object[] { id, nome, sigla });
            }
            conexao.Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            ExcluirEstante();
        }
        public void ExcluirEstante()
        {
            //verificando se tem alguma linha selecionada antes de tentar executar a exclusão
            if(dataGridViewEstantes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma estante cadastrada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //pegando a linha selecionada
            DataGridViewRow linhaSelecionada = dataGridViewEstantes.SelectedRows[0];
            //pegando o id da linha selecionada
            int id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);//0 pq a primeira coluna do dataGridView é o id
            string nome = linhaSelecionada.Cells[1].Value.ToString();

            //vericiando se realmente deseja excluir o registro
            DialogResult resultadoQuestionamento =  MessageBox.Show("Deseja realmente apagar " + nome + "?", "AVISO", MessageBoxButtons.YesNo);
            if(resultadoQuestionamento == DialogResult.No)
            {
                return;
            }

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM estantes where id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Exclusão realizada com sucesso!");
                ListarEstantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar realizar a exclusão: " + ex.Message);
                return;
            }
            conexao.Close();
        }
        private void EstantesForms_Load(object sender, EventArgs e)
        {
            ListarEstantes();
        }
    }
}
