namespace SysPecNSDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Teste");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Length > 0)
            {
                btnConfima.Enabled = true;
            }
            else
            {
                btnConfima.Enabled = false;
            }
        }


        private void btnConfima_Click(object sender, EventArgs e)
        {

            /*int numero = txtNumero1.Text;
            for (int i = 0; i < 10; i++)
            {
                lstResultado.Items.Add($"{numero} x {i + 1} = {numero * i}");
            }
            */
            string operacao = cmbOperacao.Text;
            int posicaoOperacao = cmbOperacao.SelectedIndex;

            double numero1 = 0;
            if (txtNumero1.Text != string.Empty)
            {
                numero1 = Convert.ToDouble(txtNumero1.Text);
            }

            double numero2 = 0;
            if (posicaoOperacao < 5)
            {
                if (txtNumero2.Text != string.Empty)
                {
                    numero2 = Convert.ToDouble(txtNumero2.Text);
                }
            }


            double resultado = 0;


            switch (posicaoOperacao)
            {
                case 0:
                    resultado = numero1 * numero2;
                    break;
                case 1:
                    resultado = numero1 / numero2;
                    break;
                case 2:
                    resultado = numero1 + numero2;
                    break;
                case 3:
                    resultado = numero1 - numero2;
                    break;
                case 4:
                    resultado = Math.Pow(numero1, numero2);
                    break;
                case 5:
                    resultado = Math.Sqrt(numero1);
                    break;
                case 6:
                    resultado = Math.Log(numero1);
                    break;
                default:
                    break;

            }
            //if (cmbOperacao.SelectedIndex = TextBox)


            lstResultado.Items.Add($"{operacao} - {posicaoOperacao} = {resultado}");
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperacao.Focus();

            /*
            if (posicaoOperacao == 0)
            {
                resultado = (double)numero1 * numero2;
            }
            else if (posicaoOperacao == 1)
            {
                resultado = numero1 / numero2;
            }
            */

        }
        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbOperacao.SelectedIndex > 4)
            {
                txtNumero2.Enabled = false;
            }
            else
            {
                txtNumero2.Enabled = true;
            }
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
            btnConfima.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero2.Text.Length > 0)
            {
                btnConfima.Enabled = true;
            }
            else
            {
                btnConfima.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Nivel nivel = new Nivel(textBox1.Text, textBox2.Text);
            //nivel.Inserir();
            //MessageBox.Show("Nivel gravado com Sucesso");
            //button1.Enabled = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}