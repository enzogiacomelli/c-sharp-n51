using SupermercadoForm.Entidades;
using SupermercadoForm.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class CategoriaForm : Form
    {

        private CategoriaRepositorio repositorio; //criando o repositorio

        public CategoriaForm()
        {
            InitializeComponent();
            repositorio = new CategoriaRepositorio(); //instanciando repositorio
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
            var categoria = new Categoria();
            categoria.Nome = nomeCategoria;

            repositorio.Cadastrar(categoria);

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
            //limpando o campo antes de atualizar
            richTextBoxCategorias.Clear();

            var categorias = repositorio.ObterTodos();

            //percorrer cada um dos registros da consulta na tabela de categorias
            for(int i = 0; i < categorias.Count; i++)
            {
                var categoria = categorias[i];
                //listando categorias
                richTextBoxCategorias.AppendText("\nCódigo: " + categoria.Id + "\nCategoria: " + categoria.Nome + "\n");
            }
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

            var codigoParaApagar = Convert.ToInt32(textBoxCodigoApagar.Text);
            repositorio.Apagar(codigoParaApagar);

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
            int codigoParaAlterar = Convert.ToInt32(textBoxCodigoParaAlterar.Text);
            string nome = textBoxNomeParaAlterar.Text;

            var categoria = new Categoria();
            categoria.Id = codigoParaAlterar;
            categoria.Nome = nome;

            repositorio.Atualizar(categoria);

            /*if (quantidadeRegistrosApagados == 0)
            {
                MessageBox.Show("Código informado é inexistente!");
                textBoxCodigoParaAlterar.Focus();
                return;
            }*/

            textBoxNomeParaAlterar.Clear();
            textBoxCodigoParaAlterar.Clear();

            MessageBox.Show("Categoria atualizada com sucesso!");
            ListarCategorias();
        }
    }
}
