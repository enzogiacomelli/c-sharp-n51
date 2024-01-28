using SupermercadoForm.Repositorios;


namespace SupermercadoForm.Telas
{
    public partial class ProdutoCadastroForm : Form
    {
        public ProdutoCadastroForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);
            //var idCategoria = comboBoxCategoria.SelectedIndex;
            var idCategoria = 10;

            var repositorio = new ProdutoRepositorio();
            repositorio.Cadastrar(nome, idCategoria, precoUnitario);
            MessageBox.Show("Produto cadastrado com sucesso!");
        }
    }
}
