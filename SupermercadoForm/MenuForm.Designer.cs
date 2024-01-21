namespace SupermercadoForm
{
    partial class MenuForm
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
            this.buttonCategorias = new System.Windows.Forms.Button();
            this.buttonEstantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCategorias
            // 
            this.buttonCategorias.Location = new System.Drawing.Point(12, 12);
            this.buttonCategorias.Name = "buttonCategorias";
            this.buttonCategorias.Size = new System.Drawing.Size(75, 23);
            this.buttonCategorias.TabIndex = 0;
            this.buttonCategorias.Text = "Categorias";
            this.buttonCategorias.UseVisualStyleBackColor = true;
            this.buttonCategorias.Click += new System.EventHandler(this.buttonCategorias_Click);
            // 
            // buttonEstantes
            // 
            this.buttonEstantes.Location = new System.Drawing.Point(93, 12);
            this.buttonEstantes.Name = "buttonEstantes";
            this.buttonEstantes.Size = new System.Drawing.Size(75, 23);
            this.buttonEstantes.TabIndex = 1;
            this.buttonEstantes.Text = "Estantes";
            this.buttonEstantes.UseVisualStyleBackColor = true;
            this.buttonEstantes.Click += new System.EventHandler(this.buttonEstantes_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 198);
            this.Controls.Add(this.buttonEstantes);
            this.Controls.Add(this.buttonCategorias);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Do Supermercado";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCategorias;
        private Button buttonEstantes;
    }
}