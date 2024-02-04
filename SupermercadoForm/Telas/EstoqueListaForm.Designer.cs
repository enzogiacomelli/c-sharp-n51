namespace SupermercadoForm.Telas
{
    partial class EstoqueListaForm
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
            dataGridViewEstoques = new DataGridView();
            ColumnIdEstoque = new DataGridViewTextBoxColumn();
            ColumnIdProduto = new DataGridViewTextBoxColumn();
            ColumnNomeProduto = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            buttonNovo = new Button();
            buttonAtualizar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoques).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewEstoques);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estoque";
            // 
            // dataGridViewEstoques
            // 
            dataGridViewEstoques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstoques.Columns.AddRange(new DataGridViewColumn[] { ColumnIdEstoque, ColumnIdProduto, ColumnNomeProduto, ColumnQuantidade });
            dataGridViewEstoques.Location = new Point(6, 22);
            dataGridViewEstoques.Name = "dataGridViewEstoques";
            dataGridViewEstoques.RowTemplate.Height = 25;
            dataGridViewEstoques.Size = new Size(443, 264);
            dataGridViewEstoques.TabIndex = 0;
            // 
            // ColumnIdEstoque
            // 
            ColumnIdEstoque.HeaderText = "Código";
            ColumnIdEstoque.Name = "ColumnIdEstoque";
            // 
            // ColumnIdProduto
            // 
            ColumnIdProduto.HeaderText = "Código do Produto";
            ColumnIdProduto.Name = "ColumnIdProduto";
            ColumnIdProduto.ReadOnly = true;
            // 
            // ColumnNomeProduto
            // 
            ColumnNomeProduto.HeaderText = "Produto";
            ColumnNomeProduto.Name = "ColumnNomeProduto";
            // 
            // ColumnQuantidade
            // 
            ColumnQuantidade.HeaderText = "Quantidade";
            ColumnQuantidade.Name = "ColumnQuantidade";
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(475, 34);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 23);
            buttonNovo.TabIndex = 1;
            buttonNovo.Text = "Cadastrar";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(475, 63);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(75, 23);
            buttonAtualizar.TabIndex = 2;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // EstoqueListaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 316);
            Controls.Add(buttonAtualizar);
            Controls.Add(buttonNovo);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "EstoqueListaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EstoqueListaForm";
            Load += EstoqueListaForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoques).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewEstoques;
        private DataGridViewTextBoxColumn ColumnIdEstoque;
        private DataGridViewTextBoxColumn ColumnIdProduto;
        private DataGridViewTextBoxColumn ColumnNomeProduto;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private Button buttonNovo;
        private Button buttonAtualizar;
    }
}