using SupermercadoRepositorios.Entidades;
using SupermercadoRepositorios.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class ProdutoCadastroForm : Form
    {
        int IdProdutoEditar = -1;
        public ProdutoCadastroForm()
        {
            InitializeComponent();
            PreencherDadosCategorias();
        }

        public ProdutoCadastroForm(Produto produto)//sobrecarga
        {//abre a tela de cadastro com informações de produtos no campo, usado para edição de produtos
            InitializeComponent();
            PreencherDadosCategorias();

            IdProdutoEditar = produto.Id;
            textBoxNome.Text = produto.Nome;
            textBoxPrecoUnitario.Text = produto.PrecoUnitario.ToString();

            //selecionar a categoria do produto no combobox categoria
            foreach(var item in comboBoxCategoria.Items)//para cada item na coleção de items do combobox
            {
                var categoria = (Categoria)item;//pega a categoria na coleção do combobox
                var categoriaId = categoria.Id;//pega o id dessa categoria
                if(categoriaId == produto.Categoria.Id)//compara com o id da categoria do objeto produto
                {
                    comboBoxCategoria.SelectedItem = categoria;
                    break;
                }
            }
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
            //var idCategoria = categoria.Id;

            var repositorio = new ProdutoRepositorio();

            Produto produto;

            if(IdProdutoEditar == -1)
            {
                produto = new Produto()
                {
                    Nome = nome,
                    PrecoUnitario = precoUnitario,
                    Categoria = categoria
                };
                repositorio.Cadastrar(produto);
                MessageBox.Show("Produto cadastrado com sucesso!");
                return;
            }

            produto = repositorio.ObterPorId(IdProdutoEditar);
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Categoria = categoria;

            repositorio.Atualizar(produto);
            MessageBox.Show("Produto atualizado com sucesso");
        }
    }
}
