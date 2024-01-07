using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm
{
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void buttonCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3;

            try
            {
                nota1 = Convert.ToDouble(textBoxNota1.Text);
                if(nota1 < 0 || nota1 >10)
                {
                    MessageBox.Show("A nota 1 deve ser um valor numérico de 0 a 10.");
                    textBoxNota1.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A nota 1 deve ser um valor numérico de 0 a 10.");
                textBoxNota1.Focus();
                return;
            }

            try
            {
                nota2 = Convert.ToDouble(textBoxNota2.Text);
                if (nota2 < 0 || nota2 > 10)
                {
                    MessageBox.Show("A nota 2 deve ser um valor numérico de 0 a 10.");
                    textBoxNota2.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A nota 2 deve ser um valor numérico de 0 a 10.");
                textBoxNota2.Focus();
                return;
            }

            try
            {
                nota3 = Convert.ToDouble(textBoxNota3.Text);
                if (nota3 < 0 || nota3 > 10)
                {
                    MessageBox.Show("A nota 3 deve ser um valor numérico de 0 a 10.");
                    textBoxNota3.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A nota 3 deve ser um valor numérico de 0 a 10.");
                textBoxNota3.Focus();
                return;
            }

            double media = (nota1 + nota2 + nota3) / 3.0;
            string situacao = "";

            if(media < 6.75)
            {
                situacao = "Reprovado";
            }
            else if (media >= 6.75)
            {
                situacao = "Aprovado";
            }

            textBoxMedia.Text = media.ToString();
            textSituacao.Text = situacao;

            Limpar();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            textBoxMedia.Clear();
            textSituacao.Clear();
        }

        public void Limpar()
        {
            textBoxNota1.Clear();
            textBoxNota2.Clear();
            textBoxNota3.Clear();
        }
    }
}
