using System.Data;
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
            comando.CommandText = "INSERT INTO estantes (NOME, SIGLA) VALUES ('" + nome + "', '" + sigla + "')";

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

            richTextBoxEstantes.Clear();

            
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //obter o id e o nome do registro percorrido
                DataRow registro = tabelaEmMemoria.Rows[i];
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();
                string sigla = registro["sigla"].ToString();
                //listando categorias
                richTextBoxEstantes.AppendText("Código: " + id + "\nEstante: " + nome + "(" + sigla + ")\n");
            }
            conexao.Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            ExcluirEstante();
        }
        public void ExcluirEstante()
        {
            string idExclusao = textBoxCodigoParaExcluir.Text;
            if(idExclusao == String.Empty)
            {
                MessageBox.Show("Informe o Código para exclusão!");
                textBoxCodigoParaExcluir.Focus();
                return;
            }

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM estantes where id = " + idExclusao;

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Exclusão realizada com sucesso!");
                textBoxCodigoParaExcluir.Clear();
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
