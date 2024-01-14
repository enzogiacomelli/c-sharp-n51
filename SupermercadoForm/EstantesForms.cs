using System.Data;
using System.Data.SqlClient;

namespace SupermercadoForm
{
    public partial class EstantesForms : Form
    {
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
            string sigla = textBoxSigla.Text;

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\egiac\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO estantes (NOME, SIGLA) VALUES ('" + nome + "', '" + sigla + "')";
            comando.ExecuteNonQuery();
            conexao.Close();


            textBoxNome.Clear();
            textBoxSigla.Clear();
            MessageBox.Show("Estante cadastrada com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarEstantes();
        }

        public void ListarEstantes()
        {

        }
    }
}
