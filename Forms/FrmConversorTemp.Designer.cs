namespace Forms
{
    partial class FrmConversorTemp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConversorTemp));
            lblFahrenheit1 = new Label();
            lblCelsius1 = new Label();
            lblKelvin1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnFahrenheit = new Button();
            imgIconos = new ImageList(components);
            btnCelsius = new Button();
            btnKelvin = new Button();
            label1 = new Label();
            tbxKelvinAFahrenheit = new TextBox();
            tbxCelsiusAFahrenheit = new TextBox();
            tbxFahrenheitAFahrenheit = new TextBox();
            tbxKelvinACelsius = new TextBox();
            tbxCelsiusACelsius = new TextBox();
            tbxFahrenheitACelsius = new TextBox();
            tbxKelvinAKelvin = new TextBox();
            tbxCelsiusAKelvin = new TextBox();
            tbxFahrenheitAKelvin = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblFahrenheit1
            // 
            lblFahrenheit1.AutoSize = true;
            lblFahrenheit1.Location = new Point(11, 31);
            lblFahrenheit1.Name = "lblFahrenheit1";
            lblFahrenheit1.Size = new Size(77, 20);
            lblFahrenheit1.TabIndex = 0;
            lblFahrenheit1.Text = "Fahrenheit";
            // 
            // lblCelsius1
            // 
            lblCelsius1.AutoSize = true;
            lblCelsius1.Location = new Point(11, 61);
            lblCelsius1.Name = "lblCelsius1";
            lblCelsius1.Size = new Size(54, 20);
            lblCelsius1.TabIndex = 1;
            lblCelsius1.Text = "Celsius";
            // 
            // lblKelvin1
            // 
            lblKelvin1.AutoSize = true;
            lblKelvin1.Location = new Point(11, 94);
            lblKelvin1.Name = "lblKelvin1";
            lblKelvin1.Size = new Size(49, 20);
            lblKelvin1.TabIndex = 2;
            lblKelvin1.Text = "Kelvin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(94, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // btnFahrenheit
            // 
            btnFahrenheit.ImageIndex = 1;
            btnFahrenheit.ImageList = imgIconos;
            btnFahrenheit.Location = new Point(225, 30);
            btnFahrenheit.Name = "btnFahrenheit";
            btnFahrenheit.Size = new Size(94, 29);
            btnFahrenheit.TabIndex = 6;
            btnFahrenheit.UseVisualStyleBackColor = true;
            // 
            // imgIconos
            // 
            imgIconos.ColorDepth = ColorDepth.Depth32Bit;
            imgIconos.ImageStream = (ImageListStreamer)resources.GetObject("imgIconos.ImageStream");
            imgIconos.TransparentColor = Color.Transparent;
            imgIconos.Images.SetKeyName(0, "276.png");
            imgIconos.Images.SetKeyName(1, "281.png");
            imgIconos.Images.SetKeyName(2, "291.png");
            // 
            // btnCelsius
            // 
            btnCelsius.ImageIndex = 1;
            btnCelsius.ImageList = imgIconos;
            btnCelsius.Location = new Point(225, 63);
            btnCelsius.Name = "btnCelsius";
            btnCelsius.Size = new Size(94, 29);
            btnCelsius.TabIndex = 7;
            btnCelsius.UseVisualStyleBackColor = true;
            // 
            // btnKelvin
            // 
            btnKelvin.ImageIndex = 1;
            btnKelvin.ImageList = imgIconos;
            btnKelvin.Location = new Point(225, 97);
            btnKelvin.Name = "btnKelvin";
            btnKelvin.Size = new Size(94, 29);
            btnKelvin.TabIndex = 8;
            btnKelvin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 8);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 9;
            label1.Text = "Fahrenheit";
            // 
            // tbxKelvinAFahrenheit
            // 
            tbxKelvinAFahrenheit.Location = new Point(325, 97);
            tbxKelvinAFahrenheit.Name = "tbxKelvinAFahrenheit";
            tbxKelvinAFahrenheit.Size = new Size(125, 27);
            tbxKelvinAFahrenheit.TabIndex = 12;
            // 
            // tbxCelsiusAFahrenheit
            // 
            tbxCelsiusAFahrenheit.Location = new Point(325, 64);
            tbxCelsiusAFahrenheit.Name = "tbxCelsiusAFahrenheit";
            tbxCelsiusAFahrenheit.Size = new Size(125, 27);
            tbxCelsiusAFahrenheit.TabIndex = 11;
            // 
            // tbxFahrenheitAFahrenheit
            // 
            tbxFahrenheitAFahrenheit.Location = new Point(325, 31);
            tbxFahrenheitAFahrenheit.Name = "tbxFahrenheitAFahrenheit";
            tbxFahrenheitAFahrenheit.Size = new Size(125, 27);
            tbxFahrenheitAFahrenheit.TabIndex = 10;
            // 
            // tbxKelvinACelsius
            // 
            tbxKelvinACelsius.Location = new Point(456, 97);
            tbxKelvinACelsius.Name = "tbxKelvinACelsius";
            tbxKelvinACelsius.Size = new Size(125, 27);
            tbxKelvinACelsius.TabIndex = 15;
            // 
            // tbxCelsiusACelsius
            // 
            tbxCelsiusACelsius.Location = new Point(456, 64);
            tbxCelsiusACelsius.Name = "tbxCelsiusACelsius";
            tbxCelsiusACelsius.Size = new Size(125, 27);
            tbxCelsiusACelsius.TabIndex = 14;
            // 
            // tbxFahrenheitACelsius
            // 
            tbxFahrenheitACelsius.Location = new Point(456, 31);
            tbxFahrenheitACelsius.Name = "tbxFahrenheitACelsius";
            tbxFahrenheitACelsius.Size = new Size(125, 27);
            tbxFahrenheitACelsius.TabIndex = 13;
            // 
            // tbxKelvinAKelvin
            // 
            tbxKelvinAKelvin.Location = new Point(587, 96);
            tbxKelvinAKelvin.Name = "tbxKelvinAKelvin";
            tbxKelvinAKelvin.Size = new Size(125, 27);
            tbxKelvinAKelvin.TabIndex = 18;
            // 
            // tbxCelsiusAKelvin
            // 
            tbxCelsiusAKelvin.Location = new Point(587, 63);
            tbxCelsiusAKelvin.Name = "tbxCelsiusAKelvin";
            tbxCelsiusAKelvin.Size = new Size(125, 27);
            tbxCelsiusAKelvin.TabIndex = 17;
            // 
            // tbxFahrenheitAKelvin
            // 
            tbxFahrenheitAKelvin.Location = new Point(587, 30);
            tbxFahrenheitAKelvin.Name = "tbxFahrenheitAKelvin";
            tbxFahrenheitAKelvin.Size = new Size(125, 27);
            tbxFahrenheitAKelvin.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 8);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 19;
            label2.Text = "Celsius";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 8);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 20;
            label3.Text = "Kelvin";
            // 
            // FrmConversorTemp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 137);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxKelvinAKelvin);
            Controls.Add(tbxCelsiusAKelvin);
            Controls.Add(tbxFahrenheitAKelvin);
            Controls.Add(tbxKelvinACelsius);
            Controls.Add(tbxCelsiusACelsius);
            Controls.Add(tbxFahrenheitACelsius);
            Controls.Add(tbxKelvinAFahrenheit);
            Controls.Add(tbxCelsiusAFahrenheit);
            Controls.Add(tbxFahrenheitAFahrenheit);
            Controls.Add(label1);
            Controls.Add(btnKelvin);
            Controls.Add(btnCelsius);
            Controls.Add(btnFahrenheit);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblKelvin1);
            Controls.Add(lblCelsius1);
            Controls.Add(lblFahrenheit1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConversorTemp";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de temperaturas";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFahrenheit1;
        private Label lblCelsius1;
        private Label lblKelvin1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnFahrenheit;
        private Button btnCelsius;
        private Button btnKelvin;
        private Label label1;
        private TextBox tbxKelvinAFahrenheit;
        private TextBox tbxCelsiusAFahrenheit;
        private TextBox tbxFahrenheitAFahrenheit;
        private TextBox tbxKelvinACelsius;
        private TextBox tbxCelsiusACelsius;
        private TextBox tbxFahrenheitACelsius;
        private TextBox tbxKelvinAKelvin;
        private TextBox tbxCelsiusAKelvin;
        private TextBox tbxFahrenheitAKelvin;
        private Label label2;
        private Label label3;
        private ImageList imgIconos;
    }
}
