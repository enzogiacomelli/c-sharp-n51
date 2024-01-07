namespace SupermercadoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxOperacao.SelectedItem = "Somar";//o campo vem preenchido por padrão
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;

            if(nome.Length > 15)
            {
                MessageBox.Show("O nome deve conter no máximo 15 caracteres");
                return;//encerra a execução, se não passa para o resto do codigo.
            }
            if(nome.Length < 2)
            {
                MessageBox.Show("O nome deve conter no mínimo 2 caracteres");
                return;
            }
            if (sobrenome.Length > 50)
            {
                MessageBox.Show("O sobrenome deve conter no máximo 50 caracteres");
                return;//encerra a execução, se não passa para o resto do codigo.
            }
            if (sobrenome.Length < 2)
            {
                MessageBox.Show("O sobrenome deve conter no mínimo 2 caracteres");
                return;
            }
            string nomeCompleto = nome + " " + sobrenome;
            MessageBox.Show(nomeCompleto);
        }

        private void botaoCalcular_Click(object sender, EventArgs e)
        {
            string operacaoEscolhida = comboBoxOperacao.SelectedItem.ToString();
            int numero1 = 0;
            int numero2 = 0;

            try
            {
                numero1 = Convert.ToInt32(textBoxNumero01.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Numero 1 deve ser inteiro.");
                return;
            }

            try
            {
                numero2 = Convert.ToInt32(textBoxNumero02.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numero 2 deve ser inteiro.");
                return;
            }

            int resultado = 0;
            char simbolo = ' ';
            if(operacaoEscolhida == "Somar")
            {
                resultado = numero1 + numero2;
                simbolo = '+';
            }
            else if(operacaoEscolhida == "Subtrair")
            {
                resultado = numero1 - numero2;
                simbolo = '-';
            }
            else if(operacaoEscolhida == "Dividir")
            {
                if(numero2 == 0)
                {
                    MessageBox.Show("Numero 2 não pode ser 0 em uma divisão.");
                    return;
                }
                resultado = numero1 / numero2;
                simbolo = '/';
            }
            else if(operacaoEscolhida == "Multiplicar")
            {
                resultado = numero1 * numero2;
                simbolo = '*';
            }

            DateTime dataHoraAtual = DateTime.Now;
            string dataHoraFormatada = dataHoraAtual.ToShortDateString() + " " + dataHoraAtual.ToLongTimeString();

            string texto = dataHoraFormatada + " | " + numero1 + simbolo + numero2 + " = " + resultado + "\n";

            richTextBoxHistorico.AppendText(texto);
            LimparCampos();
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            richTextBoxHistorico.Clear();
        }

        private void LimparCampos()
        {
            textBoxNumero01.Clear();
            textBoxNumero02.Clear();
            comboBoxOperacao.SelectedIndex = 2;
            textBoxNumero01.Focus();
        }
    }
}