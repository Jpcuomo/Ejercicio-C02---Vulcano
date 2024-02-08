using UnidadesDeTemperatura;
namespace Forms
{
    public partial class FrmConversorTemp : Form
    {
        Fahrenheit f;
        Celsius c;
        Kelvin k;

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


        private void tbxFahrenheit_TextChanged(object sender, EventArgs e)
        {
            double temperatura;

            if (ValidarTemperatura(tbxFahrenheit, tbxFahrenheitACelsius, tbxFahrenheitAFahrenheit, tbxFahrenheitAKelvin, out temperatura))
            {
                // Conversion de Fahrenheit a Celsius
                f = new Fahrenheit(temperatura);
                c = (Celsius)f;
                tbxFahrenheitACelsius.Text = c.Temperatura.ToString("F4");

                // Conversión de Fahrenheit a Fahrenheit
                tbxFahrenheitAFahrenheit.Text = f.Temperatura.ToString("F4");

                // Conversión de Fahrenheit a Kelvin
                k = (Kelvin)f;
                tbxFahrenheitAKelvin.Text = k.Temperatura.ToString("F4");
            }
        }


        private void tbxCelsius_TextChanged(object sender, EventArgs e)
        {
            double temperatura;

            if (ValidarTemperatura(tbxCelsius, tbxCelsiusAFahrenheit, tbxCelsiusACelsius, tbxCelsiusAKelvin, out temperatura))
            {
                // Conversion de Celsius a Fahrenheit
                c = new Celsius(temperatura);
                f = (Fahrenheit)c;
                tbxCelsiusAFahrenheit.Text = f.Temperatura.ToString("F4");

                // Conversion de Celsius a Celsius
                tbxCelsiusACelsius.Text = c.Temperatura.ToString("F4");

                // Conversion de Celsius a Kelvin
                k = (Kelvin)c;
                tbxCelsiusAKelvin.Text = k.Temperatura.ToString("F4");
            }
        }

        private void tbxKelvin_TextChanged(object sender, EventArgs e)
        {
            double temperatura;

            if (ValidarTemperatura(tbxKelvin, tbxKelvinAFahrenheit, tbxKelvinAKelvin, tbxKelvinACelsius, out temperatura))
            {
                // Conversion de Kelvin a Fahrenheit
                k = new Kelvin(temperatura);
                f = (Fahrenheit)k;
                tbxKelvinAFahrenheit.Text = f.Temperatura.ToString("F4");

                // Conversion de Kelvin a Kelvin
                tbxKelvinAKelvin.Text = k.Temperatura.ToString("F4");
            
                // Conversion de Kelvin a Celsius
                c = (Celsius)k;
                tbxKelvinACelsius.Text = c.Temperatura.ToString("F4");
            }
        }


        // Valida el valor de temperatura ingresado y maneja el comportamiento de los textBoxes
        public static bool ValidarTemperatura(TextBox temp, TextBox tbxTempATemp1, TextBox tbxTempATemp2, TextBox tbxTempATemp3, out double temperatura)
        {
            if (string.IsNullOrEmpty(temp.Text))
            {
                tbxTempATemp1.Clear();
                tbxTempATemp2.Clear();
                tbxTempATemp3.Clear();
                temp.BackColor = Color.White;
                temp.Clear();
            }
            else if (double.TryParse(temp.Text, out temperatura)
                && temperatura >= double.MinValue && temperatura <= double.MaxValue)
            {
                temp.BackColor = Color.White;
                return true;
            }
            else
            {
                temp.BackColor = Color.OrangeRed;
                tbxTempATemp1.Text = "Error";
                tbxTempATemp2.Text = "Error";
                tbxTempATemp3.Text = "Error";
            }
            temperatura = 0;
            return false;
        }
    }
}


    
