using SupermercadoForm.Entidades;
using SupermercadoForm.Repositorios;


namespace SupermercadoForm.Telas
{
    public partial class ProdutoCadastroForm : Form
    {
        public ProdutoCadastroForm()
        {
            InitializeComponent();
            PreencherDadosCategorias();
        }

        private void PreencherDadosCategorias()
        {
            //instanciando repositorio e obtendo a lista de categorias
            var categoriaRepositorio = new CategoriaRepositorio();
            var categorias = categoriaRepositorio.ObterTodos();

            //pegando cada categoria dentro da lista e adicionando no comboBoxCategoria
            for(int i = 0; i < categorias.Count; i++)
            {
                //separando a categoria especifica da lista
                var categoria = categorias[i];
                //adicionando essa categoria no comboBox
                comboBoxCategoria.Items.Add(categoria);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //obter a categoria selecionada
            var categoria = (Categoria)comboBoxCategoria.SelectedItem;//informando o tipo de objeto resgatado do comboBox

            var nome = textBoxNome.Text;
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);
            //var idCategoria = comboBoxCategoria.SelectedIndex;
            var idCategoria = categoria.Id;

            var repositorio = new ProdutoRepositorio();
            repositorio.Cadastrar(nome, idCategoria, precoUnitario);
            MessageBox.Show("Produto cadastrado com sucesso!");
        }
    }
}
