namespace SupermercadoForm.Telas
{
    partial class CategoriaForm
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.textBoxCodigoApagar = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonListar = new System.Windows.Forms.Button();
            this.richTextBoxCategorias = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Código = new System.Windows.Forms.Label();
            this.textBoxCodigoParaAlterar = new System.Windows.Forms.TextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelNomeAlterar = new System.Windows.Forms.Label();
            this.textBoxNomeParaAlterar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(74, 66);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(6, 19);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(6, 37);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(141, 23);
            this.textBoxNome.TabIndex = 2;
            this.textBoxNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNome_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNomeParaAlterar);
            this.groupBox1.Controls.Add(this.labelNomeAlterar);
            this.groupBox1.Controls.Add(this.buttonAlterar);
            this.groupBox1.Controls.Add(this.textBoxCodigoParaAlterar);
            this.groupBox1.Controls.Add(this.Código);
            this.groupBox1.Controls.Add(this.buttonApagar);
            this.groupBox1.Controls.Add(this.textBoxCodigoApagar);
            this.groupBox1.Controls.Add(this.labelCodigo);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.buttonCadastrar);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 296);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(74, 139);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 5;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // textBoxCodigoApagar
            // 
            this.textBoxCodigoApagar.Location = new System.Drawing.Point(6, 110);
            this.textBoxCodigoApagar.Name = "textBoxCodigoApagar";
            this.textBoxCodigoApagar.Size = new System.Drawing.Size(141, 23);
            this.textBoxCodigoApagar.TabIndex = 4;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(8, 92);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(46, 15);
            this.labelCodigo.TabIndex = 3;
            this.labelCodigo.Text = "Código";
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(281, 267);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 3;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // richTextBoxCategorias
            // 
            this.richTextBoxCategorias.Location = new System.Drawing.Point(6, 22);
            this.richTextBoxCategorias.Name = "richTextBoxCategorias";
            this.richTextBoxCategorias.ReadOnly = true;
            this.richTextBoxCategorias.Size = new System.Drawing.Size(350, 243);
            this.richTextBoxCategorias.TabIndex = 4;
            this.richTextBoxCategorias.TabStop = false;
            this.richTextBoxCategorias.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonListar);
            this.groupBox2.Controls.Add(this.richTextBoxCategorias);
            this.groupBox2.Location = new System.Drawing.Point(173, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 296);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias Cadastradas";
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(9, 167);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(46, 15);
            this.Código.TabIndex = 6;
            this.Código.Text = "Código";
            // 
            // textBoxCodigoParaAlterar
            // 
            this.textBoxCodigoParaAlterar.Location = new System.Drawing.Point(6, 185);
            this.textBoxCodigoParaAlterar.Name = "textBoxCodigoParaAlterar";
            this.textBoxCodigoParaAlterar.Size = new System.Drawing.Size(141, 23);
            this.textBoxCodigoParaAlterar.TabIndex = 7;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(74, 258);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 8;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // labelNomeAlterar
            // 
            this.labelNomeAlterar.AutoSize = true;
            this.labelNomeAlterar.Location = new System.Drawing.Point(9, 211);
            this.labelNomeAlterar.Name = "labelNomeAlterar";
            this.labelNomeAlterar.Size = new System.Drawing.Size(40, 15);
            this.labelNomeAlterar.TabIndex = 9;
            this.labelNomeAlterar.Text = "Nome";
            // 
            // textBoxNomeParaAlterar
            // 
            this.textBoxNomeParaAlterar.Location = new System.Drawing.Point(6, 229);
            this.textBoxNomeParaAlterar.Name = "textBoxNomeParaAlterar";
            this.textBoxNomeParaAlterar.Size = new System.Drawing.Size(141, 23);
            this.textBoxNomeParaAlterar.TabIndex = 10;
            // 
            // CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.CategoriaForm_Load);
            this.Shown += new System.EventHandler(this.CategoriaForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastrar;
        private Label labelNome;
        private TextBox textBoxNome;
        private GroupBox groupBox1;
        private Button buttonListar;
        private RichTextBox richTextBoxCategorias;
        private GroupBox groupBox2;
        private Button buttonApagar;
        private TextBox textBoxCodigoApagar;
        private Label labelCodigo;
        private Button buttonAlterar;
        private TextBox textBoxCodigoParaAlterar;
        private Label Código;
        private TextBox textBoxNomeParaAlterar;
        private Label labelNomeAlterar;
    }
}