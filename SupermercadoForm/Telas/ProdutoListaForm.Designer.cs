namespace SupermercadoForm.Telas
{
    partial class ProdutoListaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProdutos = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            buttonApagar = new Button();
            buttonEditar = new Button();
            buttonNovo = new Button();
            labelQuantidadeTotalValor = new Label();
            labelQuantidadeTotal = new Label();
            labelQuantidade = new Label();
            comboBoxQuantidade = new ComboBox();
            labelExibir = new Label();
            comboBoxOrdemColuna = new ComboBox();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonPesquisar = new Button();
            buttonLimparFiltros = new Button();
            groupBox2 = new GroupBox();
            labelOrdenar = new Label();
            comboBoxOrdenar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AllowUserToDeleteRows = false;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCategoria, ColumnPrecoUnitario });
            dataGridViewProdutos.Location = new Point(6, 84);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.RowTemplate.Height = 25;
            dataGridViewProdutos.Size = new Size(438, 227);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            // 
            // ColumnPrecoUnitario
            // 
            ColumnPrecoUnitario.HeaderText = "Preço Unitário";
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonApagar);
            groupBox1.Controls.Add(buttonEditar);
            groupBox1.Controls.Add(buttonNovo);
            groupBox1.Location = new Point(468, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(89, 110);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(6, 80);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 2;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(6, 51);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(6, 22);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 23);
            buttonNovo.TabIndex = 0;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // labelQuantidadeTotalValor
            // 
            labelQuantidadeTotalValor.AutoSize = true;
            labelQuantidadeTotalValor.Location = new Point(392, 314);
            labelQuantidadeTotalValor.Name = "labelQuantidadeTotalValor";
            labelQuantidadeTotalValor.Size = new Size(32, 15);
            labelQuantidadeTotalValor.TabIndex = 2;
            labelQuantidadeTotalValor.Text = "Total";
            // 
            // labelQuantidadeTotal
            // 
            labelQuantidadeTotal.AutoSize = true;
            labelQuantidadeTotal.Location = new Point(220, 314);
            labelQuantidadeTotal.Name = "labelQuantidadeTotal";
            labelQuantidadeTotal.Size = new Size(163, 15);
            labelQuantidadeTotal.TabIndex = 3;
            labelQuantidadeTotal.Text = "Quantidade total de Produtos";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(6, 1);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 4;
            labelQuantidade.Text = "Quantidade";
            // 
            // comboBoxQuantidade
            // 
            comboBoxQuantidade.FormattingEnabled = true;
            comboBoxQuantidade.Items.AddRange(new object[] { "10 itens", "25 itens", "50 itens", "100 itens" });
            comboBoxQuantidade.Location = new Point(18, 27);
            comboBoxQuantidade.Name = "comboBoxQuantidade";
            comboBoxQuantidade.Size = new Size(72, 23);
            comboBoxQuantidade.TabIndex = 5;
            // 
            // labelExibir
            // 
            labelExibir.AutoSize = true;
            labelExibir.Location = new Point(84, 0);
            labelExibir.Name = "labelExibir";
            labelExibir.Size = new Size(36, 15);
            labelExibir.TabIndex = 6;
            labelExibir.Text = "Exibir";
            // 
            // comboBoxOrdemColuna
            // 
            comboBoxOrdemColuna.FormattingEnabled = true;
            comboBoxOrdemColuna.Items.AddRange(new object[] { "Código", "Nome", "Categoria", "Preço Unitário" });
            comboBoxOrdemColuna.Location = new Point(84, 19);
            comboBoxOrdemColuna.Name = "comboBoxOrdemColuna";
            comboBoxOrdemColuna.Size = new Size(89, 23);
            comboBoxOrdemColuna.TabIndex = 7;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(274, 0);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(53, 15);
            labelPesquisa.TabIndex = 8;
            labelPesquisa.Text = "Pesquisa";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(274, 19);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(167, 23);
            textBoxPesquisa.TabIndex = 9;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(369, 47);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(75, 23);
            buttonPesquisar.TabIndex = 10;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparFiltros
            // 
            buttonLimparFiltros.Location = new Point(274, 47);
            buttonLimparFiltros.Name = "buttonLimparFiltros";
            buttonLimparFiltros.Size = new Size(88, 23);
            buttonLimparFiltros.TabIndex = 11;
            buttonLimparFiltros.TabStop = false;
            buttonLimparFiltros.Text = "Limpar Filtros";
            buttonLimparFiltros.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelOrdenar);
            groupBox2.Controls.Add(comboBoxOrdenar);
            groupBox2.Controls.Add(labelPesquisa);
            groupBox2.Controls.Add(dataGridViewProdutos);
            groupBox2.Controls.Add(buttonLimparFiltros);
            groupBox2.Controls.Add(labelQuantidade);
            groupBox2.Controls.Add(buttonPesquisar);
            groupBox2.Controls.Add(labelQuantidadeTotal);
            groupBox2.Controls.Add(textBoxPesquisa);
            groupBox2.Controls.Add(labelQuantidadeTotalValor);
            groupBox2.Controls.Add(labelExibir);
            groupBox2.Controls.Add(comboBoxOrdemColuna);
            groupBox2.Location = new Point(12, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 356);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // labelOrdenar
            // 
            labelOrdenar.AutoSize = true;
            labelOrdenar.Location = new Point(179, 1);
            labelOrdenar.Name = "labelOrdenar";
            labelOrdenar.Size = new Size(50, 15);
            labelOrdenar.TabIndex = 13;
            labelOrdenar.Text = "Ordenar";
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Items.AddRange(new object[] { "A-Z", "Z-A" });
            comboBoxOrdenar.Location = new Point(179, 19);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(89, 23);
            comboBoxOrdenar.TabIndex = 12;
            // 
            // ProdutoListaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 374);
            Controls.Add(comboBoxQuantidade);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            Name = "ProdutoListaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Produtos";
            Load += ProdutoListaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProdutos;
        private GroupBox groupBox1;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonNovo;
        private Label labelQuantidadeTotalValor;
        private Label labelQuantidadeTotal;
        private Label labelQuantidade;
        private ComboBox comboBoxQuantidade;
        private Label labelExibir;
        private ComboBox comboBoxOrdemColuna;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Button buttonPesquisar;
        private Button buttonLimparFiltros;
        private GroupBox groupBox2;
        private ComboBox comboBoxOrdenar;
        private Label labelOrdenar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
    }
}