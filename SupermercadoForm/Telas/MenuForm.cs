namespace SupermercadoForm.Telas
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            Form form = new CategoriaForm();
            form.ShowDialog();
        }

        private void buttonEstantes_Click(object sender, EventArgs e)
        {
            Form form = new EstantesForms();
            form.ShowDialog();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            var form = new ProdutoListaForm();
            form.ShowDialog();
        }

        private void buttonEstoque_Click(object sender, EventArgs e)
        {
            var form = new EstoqueListaForm();
            form.ShowDialog();
        }
    }
}
