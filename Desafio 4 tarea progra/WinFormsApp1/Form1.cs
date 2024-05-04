namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double tasaInteresAnual = Convert.ToDouble(txtTasaInteres.Text) / 100;
            int periodoAnos = Convert.ToInt32(txtPeriodoAnos.Text);

            double capitalFinal = montoInicial * Math.Pow(1 + tasaInteresAnual, periodoAnos);

           
            lblCapitalFinal.Text = $"Capital Final: {capitalFinal.ToString("C")}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
        