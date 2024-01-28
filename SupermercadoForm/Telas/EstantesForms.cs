using System.Data;
using System.Data.SqlClient;

namespace SupermercadoForm.Telas
{
    public partial class EstantesForms : Form
    {

        public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\egiac\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
        private int IdParaEditar = -1; //isso vai definir se o botão salvar vai usar modo de cadastro ou de salvar novo registro


        public EstantesForms()
        {
            InitializeComponent();
        }

        private void labelSigla_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if(IdParaEditar == -1) //ao usar o botão editar, no metodo de editar, esse valor é alterado para o id do registro da linha selecionada
            {
                CadastrarEstante();//cadastra um registro novo
            }
            else 
            {
                AtualizarEstante();//atualiza um registro existente
            }
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
                MessageBox.Show("Estante salva com sucesso!");
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

        private void LimparCampos()
        {
            textBoxNome.Clear();
            maskedTextBoxSigla.Clear();
            IdParaEditar = -1;
            textBoxNome.Focus();
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
            //pegar a linha selecionada
            DataGridViewRow linhaSelecionada = dataGridViewEstantes.SelectedRows[0];
            //pegar o id da linha selecionada
            IdParaEditar = Convert.ToInt32(linhaSelecionada.Cells[0].Value); //aqui é alterado o IdParaEditar. Isso vai impactar no clique do botão de Cadastrar

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //criando comando
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", IdParaEditar);

            //criando tabela em memoria e populando com os dados lidos do banco
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //pegando primeira linha da tabela. a tabela em memoria so tem uma linha aqui pois foi populada com um select filtrado por um id especifico, que so retornou um registro.
            DataRow registro = tabelaEmMemoria.Rows[0];

            string nome = registro["nome"].ToString();
            string sigla = registro["sigla"].ToString();

            textBoxNome.Text = nome;
            maskedTextBoxSigla.Text = sigla;

            conexao.Close();
        }

        private void AtualizarEstante()//Atualiza o registro. Só cai aqui se teve clique no botão editar, se não o metodo usado no botão de cadastro vai ser o CadastrarEstante
        {
            //obtendo nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            //conectar banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE estantes SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("SIGLA", sigla);
            comando.Parameters.AddWithValue("ID", IdParaEditar); //id para editar é pego no metodo de EditarEstante.

            //executar o update armazenando a quantidade de registros afetados
            int quantidadeDeRegistrosAfetados = comando.ExecuteNonQuery();

            if(quantidadeDeRegistrosAfetados > 0)
            {
                ListarEstantes();
                LimparCampos();
                MessageBox.Show("Estante alterada com sucesso!");
            }
            conexao.Close();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarEstantes();
        }

        public void ListarEstantes()//listar estantes no grid
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

        private void textBoxPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void labelPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisar_KeyDown(object sender, KeyEventArgs e)//pesquisa por um registro especifico, via nome
        {
            if(e.KeyCode == Keys.Enter)
            {
                string nomePesquisa = textBoxPesquisar.Text;
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = ConnectionString;
                conexao.Open();

                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE nome LIKE @NOME";
                comando.Parameters.AddWithValue("@NOME", nomePesquisa);


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
        }
    }
}
