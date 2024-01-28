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
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            labelOrdem = new Label();
            comboBoxOrdem = new ComboBox();
            buttonNovo = new Button();
            label1 = new Label();
            textBoxPrecoUnitario = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPrecoUnitario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonNovo);
            groupBox1.Controls.Add(comboBoxOrdem);
            groupBox1.Controls.Add(labelOrdem);
            groupBox1.Controls.Add(textBoxPesquisa);
            groupBox1.Controls.Add(labelPesquisa);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(6, 19);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(53, 15);
            labelPesquisa.TabIndex = 9;
            labelPesquisa.Text = "Pesquisa";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(6, 37);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(247, 23);
            textBoxPesquisa.TabIndex = 10;
            // 
            // labelOrdem
            // 
            labelOrdem.AutoSize = true;
            labelOrdem.Location = new Point(6, 75);
            labelOrdem.Name = "labelOrdem";
            labelOrdem.Size = new Size(44, 15);
            labelOrdem.TabIndex = 11;
            labelOrdem.Text = "Ordem";
            // 
            // comboBoxOrdem
            // 
            comboBoxOrdem.FormattingEnabled = true;
            comboBoxOrdem.Location = new Point(6, 93);
            comboBoxOrdem.Name = "comboBoxOrdem";
            comboBoxOrdem.Size = new Size(247, 23);
            comboBoxOrdem.TabIndex = 12;
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(178, 181);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 23);
            buttonNovo.TabIndex = 1;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
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
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(6, 152);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(247, 23);
            textBoxPrecoUnitario.TabIndex = 14;
            // 
            // ProdutoCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 234);
            Controls.Add(groupBox1);
            Name = "ProdutoCadastroForm";
            Text = "Cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Label labelOrdem;
        private ComboBox comboBoxOrdem;
        private Button buttonNovo;
        private TextBox textBoxPrecoUnitario;
        private Label label1;
    }
}