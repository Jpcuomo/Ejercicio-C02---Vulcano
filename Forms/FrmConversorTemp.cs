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

            // Conversion de Fahrenheit a Celsius
            if (ValidarTemperatura(tbxFahrenheit, tbxFahrenheitACelsius, out temperatura))
            {
                f = new Fahrenheit(temperatura);
                c = (Celsius)f;
                tbxFahrenheitACelsius.Text = c.Temperatura.ToString("F4");
            }

            // Conversión de Fahrenheit a Fahrenheit
            if (ValidarTemperatura(tbxFahrenheit, tbxFahrenheitAFahrenheit, out temperatura))
            {
                tbxFahrenheitAFahrenheit.Text = f.Temperatura.ToString("F4");
            }

            // Conversión de Fahrenheit a Kelvin
            if (ValidarTemperatura(tbxFahrenheit, tbxFahrenheitAKelvin, out temperatura))
            {
                k = (Kelvin)f;
                tbxFahrenheitAKelvin.Text = k.Temperatura.ToString("F4");
            }
        }


        private void tbxCelsius_TextChanged(object sender, EventArgs e)
        {
            double temperatura;

            // Conversion de Celsius a Fahrenheit
            if (ValidarTemperatura(tbxCelsius, tbxCelsiusAFahrenheit, out temperatura))
            {
                c = new Celsius(temperatura);
                f = (Fahrenheit)c;
                tbxCelsiusAFahrenheit.Text = f.Temperatura.ToString("F4");
            }

            // Conversion de Celsius a Celsius
            if (ValidarTemperatura(tbxCelsius, tbxCelsiusACelsius, out temperatura))
            {
                tbxCelsiusACelsius.Text = c.Temperatura.ToString("F4");
            }

            // Conversion de Celsius a Kelvin
            if (ValidarTemperatura(tbxCelsius, tbxCelsiusAKelvin, out temperatura))
            {
                k = (Kelvin)c;
                tbxCelsiusAKelvin.Text = k.Temperatura.ToString("F4");
            }
        }

        private void tbxKelvin_TextChanged(object sender, EventArgs e)
        {
            double temperatura;

            // Conversion de Kelvin a Fahrenheit
            if (ValidarTemperatura(tbxKelvin, tbxKelvinAFahrenheit, out temperatura))
            {
                k = new Kelvin(temperatura);
                f = (Fahrenheit)k;
                tbxKelvinAFahrenheit.Text = f.Temperatura.ToString("F4");
            }

            // Conversion de Kelvin a Kelvin
            if (ValidarTemperatura(tbxKelvin, tbxKelvinAKelvin, out temperatura))
            {
                tbxKelvinAKelvin.Text = k.Temperatura.ToString("F4");
            }

            // Conversion de Kelvin a Celsius
            if (ValidarTemperatura(tbxKelvin, tbxKelvinACelsius, out temperatura))
            {
                c = (Celsius)k;
                tbxKelvinACelsius.Text = c.Temperatura.ToString("F4");
            }
        }


        // Valida el valor de temperatura ingresado y maneja el comportamiento de los textBoxes
        public static bool ValidarTemperatura(TextBox temp, TextBox tbxTempATemp, out double temperatura)
        {
            if (string.IsNullOrEmpty(temp.Text))
            {
                tbxTempATemp.Clear();
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
                tbxTempATemp.Text = "Error";
            }
            temperatura = 0;
            return false;
        }
    }
}


    
