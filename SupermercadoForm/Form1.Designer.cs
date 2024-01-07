namespace SupermercadoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPrimeiraTela = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.comboBoxOperacao = new System.Windows.Forms.ComboBox();
            this.labelNum01 = new System.Windows.Forms.Label();
            this.textBoxNumero01 = new System.Windows.Forms.TextBox();
            this.labelNum02 = new System.Windows.Forms.Label();
            this.textBoxNumero02 = new System.Windows.Forms.TextBox();
            this.richTextBoxHistorico = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrimeiraTela
            // 
            this.labelPrimeiraTela.AutoSize = true;
            this.labelPrimeiraTela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrimeiraTela.Location = new System.Drawing.Point(11, 6);
            this.labelPrimeiraTela.Name = "labelPrimeiraTela";
            this.labelPrimeiraTela.Size = new System.Drawing.Size(100, 18);
            this.labelPrimeiraTela.TabIndex = 0;
            this.labelPrimeiraTela.Text = "Primeira Tela";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Concatenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(11, 39);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Location = new System.Drawing.Point(11, 97);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(68, 15);
            this.labelSobrenome.TabIndex = 3;
            this.labelSobrenome.Text = "Sobrenome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(11, 57);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(208, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(11, 115);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(208, 23);
            this.textBoxSobrenome.TabIndex = 5;
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.Location = new System.Drawing.Point(265, 39);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(58, 15);
            this.labelOperacao.TabIndex = 6;
            this.labelOperacao.Text = "Operação";
            // 
            // comboBoxOperacao
            // 
            this.comboBoxOperacao.FormattingEnabled = true;
            this.comboBoxOperacao.Items.AddRange(new object[] {
            "Dividir",
            "Multiplicar",
            "Somar",
            "Subtrair"});
            this.comboBoxOperacao.Location = new System.Drawing.Point(265, 57);
            this.comboBoxOperacao.Name = "comboBoxOperacao";
            this.comboBoxOperacao.Size = new System.Drawing.Size(208, 23);
            this.comboBoxOperacao.TabIndex = 7;
            // 
            // labelNum01
            // 
            this.labelNum01.AutoSize = true;
            this.labelNum01.Location = new System.Drawing.Point(265, 97);
            this.labelNum01.Name = "labelNum01";
            this.labelNum01.Size = new System.Drawing.Size(66, 15);
            this.labelNum01.TabIndex = 8;
            this.labelNum01.Text = "Número 01";
            // 
            // textBoxNumero01
            // 
            this.textBoxNumero01.Location = new System.Drawing.Point(265, 115);
            this.textBoxNumero01.Name = "textBoxNumero01";
            this.textBoxNumero01.Size = new System.Drawing.Size(97, 23);
            this.textBoxNumero01.TabIndex = 9;
            // 
            // labelNum02
            // 
            this.labelNum02.AutoSize = true;
            this.labelNum02.Location = new System.Drawing.Point(376, 97);
            this.labelNum02.Name = "labelNum02";
            this.labelNum02.Size = new System.Drawing.Size(66, 15);
            this.labelNum02.TabIndex = 10;
            this.labelNum02.Text = "Número 02";
            // 
            // textBoxNumero02
            // 
            this.textBoxNumero02.Location = new System.Drawing.Point(376, 115);
            this.textBoxNumero02.Name = "textBoxNumero02";
            this.textBoxNumero02.Size = new System.Drawing.Size(97, 23);
            this.textBoxNumero02.TabIndex = 11;
            // 
            // richTextBoxHistorico
            // 
            this.richTextBoxHistorico.Location = new System.Drawing.Point(265, 173);
            this.richTextBoxHistorico.Name = "richTextBoxHistorico";
            this.richTextBoxHistorico.Size = new System.Drawing.Size(208, 96);
            this.richTextBoxHistorico.TabIndex = 12;
            this.richTextBoxHistorico.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Histórico";
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.Location = new System.Drawing.Point(392, 275);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(81, 23);
            this.botaoCalcular.TabIndex = 14;
            this.botaoCalcular.Text = "Calcular";
            this.botaoCalcular.UseVisualStyleBackColor = true;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(265, 275);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(81, 23);
            this.botaoLimpar.TabIndex = 15;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 403);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBoxHistorico);
            this.Controls.Add(this.textBoxNumero02);
            this.Controls.Add(this.labelNum02);
            this.Controls.Add(this.textBoxNumero01);
            this.Controls.Add(this.labelNum01);
            this.Controls.Add(this.comboBoxOperacao);
            this.Controls.Add(this.labelOperacao);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPrimeiraTela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPrimeiraTela;
        private Button button1;
        private Label labelNome;
        private Label labelSobrenome;
        private TextBox textBoxNome;
        private TextBox textBoxSobrenome;
        private Label labelOperacao;
        private ComboBox comboBoxOperacao;
        private Label labelNum01;
        private TextBox textBoxNumero01;
        private Label labelNum02;
        private TextBox textBoxNumero02;
        private RichTextBox richTextBoxHistorico;
        private Label label7;
        private Button botaoCalcular;
        private Button botaoLimpar;
    }
}