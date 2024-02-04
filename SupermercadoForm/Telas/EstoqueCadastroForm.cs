using SupermercadoForm.Entidades;
using SupermercadoForm.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class EstoqueCadastroForm : Form
    {
        public EstoqueCadastroForm()
        {
            InitializeComponent();
        }

        private void EstoqueCadastroForm_Load(object sender, EventArgs e)
        {
            var produtoRepositorio = new ProdutoRepositorio();
            var produtos = produtoRepositorio.ObterTodos();

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];
                comboBoxProdutos.Items.Add(produto);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var estoque = new Estoque();
            var produto = (Produto)comboBoxProdutos.SelectedItem;

            estoque.Quantidade = Convert.ToDecimal(domainUpDownQuantidade.Text);
            estoque.Produto.Id = produto.Id;

            var estoqueRepositorio = new EstoqueRepositorio();
            estoqueRepositorio.Cadastrar(estoque);
        }
    }
}
