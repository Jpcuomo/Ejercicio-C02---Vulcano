namespace Forms
{
    public partial class FrmConversorTemp : Form
    {
        public FrmConversorTemp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxFahrenheitAFahrenheit.ReadOnly = true;
            tbxFahrenheitACelsius.ReadOnly = true;
            tbxFahrenheitAKelvin.ReadOnly = true;
            tbxCelsiusAFahrenheit.ReadOnly = true;
            tbxCelsiusACelsius.ReadOnly = true;
            tbxCelsiusAKelvin.ReadOnly = true;
            tbxKelvinAFahrenheit.ReadOnly = true;
            tbxKelvinACelsius.ReadOnly = true;
            tbxKelvinAKelvin.ReadOnly = true;
        }


    }
}
