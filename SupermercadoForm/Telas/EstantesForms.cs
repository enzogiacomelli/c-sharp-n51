using SupermercadoForm.Entidades;
using SupermercadoForm.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class EstantesForms : Form
    {
        private int IdParaEditar = -1; //isso vai definir se o botão salvar vai usar modo de cadastro ou de salvar novo registro
        private IEstanteRepositorio repositorio;

        public EstantesForms()
        {
            repositorio = new EstanteRepositorio();
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

            var estante = new Estante();
            estante.Nome = nome;
            estante.Sigla = sigla;

            repositorio.Cadastrar(estante);

            MessageBox.Show("Estante salva com sucesso!");
            textBoxNome.Clear();
            maskedTextBoxSigla.Clear();
            ListarEstantes();
            LimparCampos();
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
        private void EditarEstante() //quando clica em editar, esse metodo joga os valores para os campos da tela
        {
            //pegar a linha selecionada
            DataGridViewRow linhaSelecionada = dataGridViewEstantes.SelectedRows[0];
            //pegar o id da linha selecionada
            IdParaEditar = Convert.ToInt32(linhaSelecionada.Cells[0].Value); //aqui é alterado o IdParaEditar. Isso vai impactar no clique do botão de Cadastrar
            var estante = repositorio.ObterPorId(IdParaEditar);
            LimparCampos();

            textBoxNome.Text = estante.Nome;
            maskedTextBoxSigla.Text = estante.Sigla;
        }

        private void AtualizarEstante()//Atualiza o registro. Só cai aqui se teve clique no botão editar, se não o metodo usado no botão de cadastro vai ser o CadastrarEstante
        {
            //obtendo nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            var estante = new Estante();
            estante.Nome = nome;
            estante.Sigla = sigla;
            estante.Id = IdParaEditar;

            repositorio.Atualizar(estante);

            ListarEstantes();
            LimparCampos();
           MessageBox.Show("Estante alterada com sucesso!");
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            ListarEstantes();
        }

        public void ListarEstantes()//listar estantes no grid
        {
            string pesquisa = textBoxPesquisar.Text.Trim();
            dataGridViewEstantes.Rows.Clear();
            var estantes = repositorio.ObterTodos(pesquisa);

            foreach ( var estante in estantes )
            {
                dataGridViewEstantes.Rows.Add(new object[] 
                {
                    estante.Id, estante.Nome, estante.Sigla,
                });
            }
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
            int idParaApagar = Convert.ToInt32(linhaSelecionada.Cells[0].Value);//0 pq a primeira coluna do dataGridView é o id
            string nome = linhaSelecionada.Cells[1].Value.ToString();

            //vericiando se realmente deseja excluir o registro
            DialogResult resultadoQuestionamento =  MessageBox.Show("Deseja realmente apagar " + nome + "?", "AVISO", MessageBoxButtons.YesNo);
            if(resultadoQuestionamento == DialogResult.No)
            {
                return;
            }
            else
            {
                repositorio.Apagar(idParaApagar);
            }

            MessageBox.Show("Exclusão realizada com sucesso!");
            ListarEstantes();
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
                ListarEstantes();
            }
        }
    }
}
