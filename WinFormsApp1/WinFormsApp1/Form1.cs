namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama;
            int numPalabras = 0;
            double coste;

            // Leo el telegrama 
            textoTelegrama = txtTelegrama.Text;

            // telegrama urgente?
            tipoTelegrama = chkUrgente.Checked ? 'u' : 'o';

            // Obtengo el número de palabras que forma el telegrama 
            numPalabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Calcular el coste
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else // Si el telegrama es urgente
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            // Mostrar el coste en el TextBox
            txtPrecio.Text = coste.ToString("F2") + " euros";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}

