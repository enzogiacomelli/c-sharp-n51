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
            CarregaProdutosNoComboBox();
        }

        private void CarregaProdutosNoComboBox()
        {
            comboBoxProdutos.Items.Clear();

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
            var produto = (Produto)comboBoxProdutos.SelectedItem;
            var estoque = new Estoque();

            estoque.Quantidade = Convert.ToDecimal(domainUpDownQuantidade.Text);
            estoque.Produto = produto;

            var estoqueRepositorio = new EstoqueRepositorio();
            estoqueRepositorio.Cadastrar(estoque);

            AtualizarTela();               
        }

        private void AtualizarTela()
        {
            domainUpDownQuantidade.Text = string.Empty;
            comboBoxProdutos.SelectedItem = null;
        }
    }
}
