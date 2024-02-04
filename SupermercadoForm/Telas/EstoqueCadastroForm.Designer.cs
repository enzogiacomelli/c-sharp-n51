namespace SupermercadoForm.Telas
{
    partial class EstoqueCadastroForm
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
            groupBox1 = new GroupBox();
            buttonSalvar = new Button();
            button1 = new Button();
            comboBoxProdutos = new ComboBox();
            domainUpDownQuantidade = new DomainUpDown();
            labelProduto = new Label();
            labelQuantidade = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSalvar);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBoxProdutos);
            groupBox1.Controls.Add(domainUpDownQuantidade);
            groupBox1.Controls.Add(labelProduto);
            groupBox1.Controls.Add(labelQuantidade);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Estoque";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(91, 140);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 140);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxProdutos
            // 
            comboBoxProdutos.DisplayMember = "Nome";
            comboBoxProdutos.FormattingEnabled = true;
            comboBoxProdutos.Location = new Point(6, 100);
            comboBoxProdutos.Name = "comboBoxProdutos";
            comboBoxProdutos.Size = new Size(160, 23);
            comboBoxProdutos.TabIndex = 4;
            comboBoxProdutos.ValueMember = "Nome";
            // 
            // domainUpDownQuantidade
            // 
            domainUpDownQuantidade.Location = new Point(6, 37);
            domainUpDownQuantidade.Name = "domainUpDownQuantidade";
            domainUpDownQuantidade.Size = new Size(160, 23);
            domainUpDownQuantidade.TabIndex = 3;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(6, 82);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(50, 15);
            labelProduto.TabIndex = 1;
            labelProduto.Text = "Produto";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(6, 19);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 0;
            labelQuantidade.Text = "Quantidade";
            // 
            // EstoqueCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(203, 200);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "EstoqueCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += EstoqueCadastroForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelProduto;
        private Label labelQuantidade;
        private DomainUpDown domainUpDownQuantidade;
        private Button buttonSalvar;
        private Button button1;
        private ComboBox comboBoxProdutos;
    }
}