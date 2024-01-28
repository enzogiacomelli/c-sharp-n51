namespace SupermercadoForm.Telas
{
    partial class EstantesForms
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSigla = new System.Windows.Forms.Label();
            this.groupBoxEstantes = new System.Windows.Forms.GroupBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.maskedTextBoxSigla = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEstantes = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonListar = new System.Windows.Forms.Button();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.groupBoxEstantes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstantes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(6, 19);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelSigla
            // 
            this.labelSigla.AutoSize = true;
            this.labelSigla.Location = new System.Drawing.Point(150, 19);
            this.labelSigla.Name = "labelSigla";
            this.labelSigla.Size = new System.Drawing.Size(32, 15);
            this.labelSigla.TabIndex = 1;
            this.labelSigla.Text = "Sigla";
            this.labelSigla.Click += new System.EventHandler(this.labelSigla_Click);
            // 
            // groupBoxEstantes
            // 
            this.groupBoxEstantes.Controls.Add(this.buttonCadastrar);
            this.groupBoxEstantes.Controls.Add(this.maskedTextBoxSigla);
            this.groupBoxEstantes.Controls.Add(this.textBoxNome);
            this.groupBoxEstantes.Controls.Add(this.labelSigla);
            this.groupBoxEstantes.Controls.Add(this.labelNome);
            this.groupBoxEstantes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEstantes.Name = "groupBoxEstantes";
            this.groupBoxEstantes.Size = new System.Drawing.Size(233, 96);
            this.groupBoxEstantes.TabIndex = 2;
            this.groupBoxEstantes.TabStop = false;
            this.groupBoxEstantes.Text = "Nova Estante";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(150, 66);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(77, 23);
            this.buttonCadastrar.TabIndex = 3;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // maskedTextBoxSigla
            // 
            this.maskedTextBoxSigla.Location = new System.Drawing.Point(150, 37);
            this.maskedTextBoxSigla.Mask = "AAA";
            this.maskedTextBoxSigla.Name = "maskedTextBoxSigla";
            this.maskedTextBoxSigla.Size = new System.Drawing.Size(77, 23);
            this.maskedTextBoxSigla.TabIndex = 4;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(6, 37);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(138, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(110, 264);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(77, 23);
            this.buttonEditar.TabIndex = 6;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(193, 264);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(77, 23);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelPesquisar);
            this.groupBox3.Controls.Add(this.textBoxPesquisar);
            this.groupBox3.Controls.Add(this.buttonExcluir);
            this.groupBox3.Controls.Add(this.dataGridViewEstantes);
            this.groupBox3.Controls.Add(this.buttonListar);
            this.groupBox3.Controls.Add(this.buttonEditar);
            this.groupBox3.Location = new System.Drawing.Point(261, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 293);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estantes Cadastradas";
            // 
            // dataGridViewEstantes
            // 
            this.dataGridViewEstantes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewEstantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnSigla});
            this.dataGridViewEstantes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewEstantes.Location = new System.Drawing.Point(5, 45);
            this.dataGridViewEstantes.Name = "dataGridViewEstantes";
            this.dataGridViewEstantes.RowTemplate.Height = 25;
            this.dataGridViewEstantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstantes.Size = new System.Drawing.Size(346, 213);
            this.dataGridViewEstantes.TabIndex = 14;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Width = 50;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 200;
            // 
            // ColumnSigla
            // 
            this.ColumnSigla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSigla.HeaderText = "Sigla";
            this.ColumnSigla.Name = "ColumnSigla";
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(276, 264);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 1;
            this.buttonListar.Text = "Atualizar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Location = new System.Drawing.Point(193, 16);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(57, 15);
            this.labelPesquisar.TabIndex = 14;
            this.labelPesquisar.Text = "Pesquisar";
            this.labelPesquisar.Click += new System.EventHandler(this.labelPesquisar_Click);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(251, 16);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(100, 23);
            this.textBoxPesquisar.TabIndex = 15;
            this.textBoxPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPesquisar_KeyDown);
            this.textBoxPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisar_KeyPress);
            // 
            // EstantesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 313);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxEstantes);
            this.Name = "EstantesForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estantes";
            this.Load += new System.EventHandler(this.EstantesForms_Load);
            this.groupBoxEstantes.ResumeLayout(false);
            this.groupBoxEstantes.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelNome;
        private Label labelSigla;
        private GroupBox groupBoxEstantes;
        private TextBox textBoxNome;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private Button buttonExcluir;
        private GroupBox groupBox3;
        private Button buttonListar;
        private MaskedTextBox maskedTextBoxSigla;
        private DataGridView dataGridViewEstantes;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnSigla;
        private Label labelPesquisar;
        private TextBox textBoxPesquisar;
    }
}