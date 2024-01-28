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
            groupBox1 = new GroupBox();
            buttonNovo = new Button();
            buttonEditar = new Button();
            buttonApagar = new Button();
            labelQuantidadeTotalValor = new Label();
            labelQuantidadeTotal = new Label();
            labelQuantidade = new Label();
            comboBoxQuantidade = new ComboBox();
            labelOrdem = new Label();
            comboBoxOrdem = new ComboBox();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonPesquisar = new Button();
            buttonLimparFiltros = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(18, 92);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowTemplate.Height = 25;
            dataGridViewProdutos.Size = new Size(418, 227);
            dataGridViewProdutos.TabIndex = 0;
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
            // buttonNovo
            // 
            buttonNovo.Location = new Point(6, 22);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 23);
            buttonNovo.TabIndex = 0;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
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
            // buttonApagar
            // 
            buttonApagar.Location = new Point(6, 80);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 2;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
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
            comboBoxQuantidade.Location = new Point(18, 27);
            comboBoxQuantidade.Name = "comboBoxQuantidade";
            comboBoxQuantidade.Size = new Size(115, 23);
            comboBoxQuantidade.TabIndex = 5;
            // 
            // labelOrdem
            // 
            labelOrdem.AutoSize = true;
            labelOrdem.Location = new Point(139, 9);
            labelOrdem.Name = "labelOrdem";
            labelOrdem.Size = new Size(44, 15);
            labelOrdem.TabIndex = 6;
            labelOrdem.Text = "Ordem";
            // 
            // comboBoxOrdem
            // 
            comboBoxOrdem.FormattingEnabled = true;
            comboBoxOrdem.Location = new Point(139, 27);
            comboBoxOrdem.Name = "comboBoxOrdem";
            comboBoxOrdem.Size = new Size(121, 23);
            comboBoxOrdem.TabIndex = 7;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(266, 8);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(53, 15);
            labelPesquisa.TabIndex = 8;
            labelPesquisa.Text = "Pesquisa";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(266, 26);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(170, 23);
            textBoxPesquisa.TabIndex = 9;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(361, 55);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(75, 23);
            buttonPesquisar.TabIndex = 10;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparFiltros
            // 
            buttonLimparFiltros.Location = new Point(266, 55);
            buttonLimparFiltros.Name = "buttonLimparFiltros";
            buttonLimparFiltros.Size = new Size(88, 23);
            buttonLimparFiltros.TabIndex = 11;
            buttonLimparFiltros.TabStop = false;
            buttonLimparFiltros.Text = "Limpar Filtros";
            buttonLimparFiltros.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelQuantidade);
            groupBox2.Controls.Add(labelQuantidadeTotal);
            groupBox2.Controls.Add(labelQuantidadeTotalValor);
            groupBox2.Location = new Point(12, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 356);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // ProdutoListaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 374);
            Controls.Add(buttonLimparFiltros);
            Controls.Add(buttonPesquisar);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            Controls.Add(comboBoxOrdem);
            Controls.Add(labelOrdem);
            Controls.Add(comboBoxQuantidade);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            Name = "ProdutoListaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Produtos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label labelOrdem;
        private ComboBox comboBoxOrdem;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Button buttonPesquisar;
        private Button buttonLimparFiltros;
        private GroupBox groupBox2;
    }
}