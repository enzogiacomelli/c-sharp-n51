using System.Data;
using System.Data.SqlClient;

namespace SupermercadoForm.Telas
{
    public partial class CategoriaForm : Form
    {
        public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\egiac\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

        public CategoriaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarCategoria();
        }


        private void CriarCategoria()
        {
            string nomeCategoria = textBoxNome.Text;
            if(nomeCategoria.Length < 3)
            {
                MessageBox.Show("Nome da categoria deve conter no minimo 3 caracteres");
                return;
            }

            SqlConnection conexao = new SqlConnection(); //cria conexão
            conexao.ConnectionString = ConnectionString; //define a conexão com o caminho onde esta o banco
            conexao.Open(); //abre a conexão

            SqlCommand comando = conexao.CreateCommand(); //cria um comando sql
            comando.CommandText = "INSERT INTO categorias (nome) VALUES ('" + nomeCategoria +"')"; //define o comando que vai rodar
            comando.ExecuteNonQuery(); //executa o comando no bando
            conexao.Close(); //fecha a conexão

            textBoxNome.Clear();
            MessageBox.Show("Categoria criada com sucesso!");
            ListarCategorias();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarCategorias();
        }

        private void ListarCategorias()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString; //define a conexão com o caminho onde esta o banco
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome FROM categorias";

            //criando uma tabela em memoria para carregar os dados retornados do select
            DataTable tabelaEmMemoria = new DataTable();
            //carregando os dados da consulta select na tabela em memoria
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //limpando o campo antes de atualizar
            richTextBoxCategorias.Clear();

            //percorrer cada um dos registros da consulta na tabela de categorias
            for(int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //obter o id e o nome do registro percorrido
                DataRow registro = tabelaEmMemoria.Rows[i];
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();
                //listando categorias
                richTextBoxCategorias.AppendText("\nCódigo: " + id + "\nCategoria: " + nome + "\n");
            }

            conexao.Close();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            ApagarCategoria();
        }

        private void ApagarCategoria()
        {
            if (textBoxCodigoApagar.Text == String.Empty)
            {
                MessageBox.Show("Informe o código!");
                textBoxCodigoApagar.Focus();
                return;
            }

            int codigoParaApagar = Convert.ToInt32(textBoxCodigoApagar.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString; //define a conexão com o caminho onde esta o banco
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM categorias where id = " + codigoParaApagar;
            int quantidadeRegistrosApagados = comando.ExecuteNonQuery(); //executeNonQuery retorna o numero de linhas afetadas

            if(quantidadeRegistrosApagados == 0)
            {
                MessageBox.Show("Código informado é inexistente!");
                textBoxCodigoApagar.Focus();
                return;
            }

            conexao.Close();

            textBoxCodigoApagar.Clear();
            MessageBox.Show("Registro apagado com sucesso!");
            ListarCategorias();
        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            ListarCategorias();
        }

        private void CategoriaForm_Shown(object sender, EventArgs e)
        {
            textBoxNome.Focus();
        }

        private void textBoxNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CriarCategoria();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            AlterarCategoria();
        }

        private void AlterarCategoria()
        {
            int codigoParaAlterar = Convert.ToInt32(textBoxCodigoParaAlterar);
            string nome = textBoxNomeParaAlterar.Text;

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString; //define a conexão com o caminho onde esta o banco
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE categorias SET nome = '" + nome + "' WHERE id = " + codigoParaAlterar;
            int quantidadeRegistrosApagados = comando.ExecuteNonQuery();

            if (quantidadeRegistrosApagados == 0)
            {
                MessageBox.Show("Código informado é inexistente!");
                textBoxCodigoParaAlterar.Focus();
                return;
            }

            textBoxNomeParaAlterar.Clear();
            textBoxCodigoParaAlterar.Clear();

            conexao.Close();
            MessageBox.Show("Categoria atualizada com sucesso!");
            ListarCategorias();
        }
    }
}
