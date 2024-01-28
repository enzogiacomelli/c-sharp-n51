namespace SupermercadoForm.Telas
{
    partial class ProdutoCadastroForm
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
            textBoxPrecoUnitario = new TextBox();
            label1 = new Label();
            buttonSalvar = new Button();
            comboBoxCategoria = new ComboBox();
            labelCategoria = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPrecoUnitario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonSalvar);
            groupBox1.Controls.Add(comboBoxCategoria);
            groupBox1.Controls.Add(labelCategoria);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(labelNome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(6, 152);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(247, 23);
            textBoxPrecoUnitario.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 134);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 13;
            label1.Text = "Preço Unitário";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(178, 181);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 1;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(6, 93);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(247, 23);
            comboBoxCategoria.TabIndex = 12;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(6, 75);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(58, 15);
            labelCategoria.TabIndex = 11;
            labelCategoria.Text = "Categoria";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(6, 37);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(247, 23);
            textBoxNome.TabIndex = 10;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(6, 19);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 9;
            labelNome.Text = "Nome";
            // 
            // ProdutoCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 234);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "ProdutoCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelCategoria;
        private ComboBox comboBoxCategoria;
        private Button buttonSalvar;
        private TextBox textBoxPrecoUnitario;
        private Label label1;
    }
}