
namespace Conversor_de_Temperaturas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValor = new System.Windows.Forms.Label();
            this.rbCelsius1 = new System.Windows.Forms.RadioButton();
            this.rbKelvin1 = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit1 = new System.Windows.Forms.RadioButton();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.rbCelsius2 = new System.Windows.Forms.RadioButton();
            this.rbKelvin2 = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit2 = new System.Windows.Forms.RadioButton();
            this.gbEntrada.SuspendLayout();
            this.gbSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(12, 26);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(58, 26);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // rbCelsius1
            // 
            this.rbCelsius1.AutoSize = true;
            this.rbCelsius1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius1.Location = new System.Drawing.Point(95, 0);
            this.rbCelsius1.Name = "rbCelsius1";
            this.rbCelsius1.Size = new System.Drawing.Size(89, 30);
            this.rbCelsius1.TabIndex = 2;
            this.rbCelsius1.TabStop = true;
            this.rbCelsius1.Text = "Celsius";
            this.rbCelsius1.UseVisualStyleBackColor = true;
            // 
            // rbKelvin1
            // 
            this.rbKelvin1.AutoSize = true;
            this.rbKelvin1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin1.Location = new System.Drawing.Point(95, 36);
            this.rbKelvin1.Name = "rbKelvin1";
            this.rbKelvin1.Size = new System.Drawing.Size(85, 30);
            this.rbKelvin1.TabIndex = 2;
            this.rbKelvin1.TabStop = true;
            this.rbKelvin1.Text = "Kelvin";
            this.rbKelvin1.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit1
            // 
            this.rbFahrenheit1.AutoSize = true;
            this.rbFahrenheit1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit1.Location = new System.Drawing.Point(95, 72);
            this.rbFahrenheit1.Name = "rbFahrenheit1";
            this.rbFahrenheit1.Size = new System.Drawing.Size(122, 30);
            this.rbFahrenheit1.TabIndex = 2;
            this.rbFahrenheit1.TabStop = true;
            this.rbFahrenheit1.Text = "Fahrenheit";
            this.rbFahrenheit1.UseVisualStyleBackColor = true;
            this.rbFahrenheit1.CheckedChanged += new System.EventHandler(this.rbFahrenheit_CheckedChanged);
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbCelsius1);
            this.gbEntrada.Controls.Add(this.rbKelvin1);
            this.gbEntrada.Controls.Add(this.rbFahrenheit1);
            this.gbEntrada.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntrada.Location = new System.Drawing.Point(30, 76);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(226, 117);
            this.gbEntrada.TabIndex = 1;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(166, 305);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(116, 35);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(406, 305);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 35);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(112, 22);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(522, 30);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 224);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(94, 26);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(112, 220);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(531, 30);
            this.txtResultado.TabIndex = 5;
            // 
            // gbSaida
            // 
            this.gbSaida.Controls.Add(this.rbCelsius2);
            this.gbSaida.Controls.Add(this.rbKelvin2);
            this.gbSaida.Controls.Add(this.rbFahrenheit2);
            this.gbSaida.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaida.Location = new System.Drawing.Point(406, 76);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(228, 117);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saída";
            // 
            // rbCelsius2
            // 
            this.rbCelsius2.AutoSize = true;
            this.rbCelsius2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius2.Location = new System.Drawing.Point(81, 0);
            this.rbCelsius2.Name = "rbCelsius2";
            this.rbCelsius2.Size = new System.Drawing.Size(89, 30);
            this.rbCelsius2.TabIndex = 2;
            this.rbCelsius2.TabStop = true;
            this.rbCelsius2.Text = "Celsius";
            this.rbCelsius2.UseVisualStyleBackColor = true;
            // 
            // rbKelvin2
            // 
            this.rbKelvin2.AutoSize = true;
            this.rbKelvin2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin2.Location = new System.Drawing.Point(81, 36);
            this.rbKelvin2.Name = "rbKelvin2";
            this.rbKelvin2.Size = new System.Drawing.Size(85, 30);
            this.rbKelvin2.TabIndex = 2;
            this.rbKelvin2.TabStop = true;
            this.rbKelvin2.Text = "Kelvin";
            this.rbKelvin2.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit2
            // 
            this.rbFahrenheit2.AutoSize = true;
            this.rbFahrenheit2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit2.Location = new System.Drawing.Point(81, 72);
            this.rbFahrenheit2.Name = "rbFahrenheit2";
            this.rbFahrenheit2.Size = new System.Drawing.Size(122, 30);
            this.rbFahrenheit2.TabIndex = 2;
            this.rbFahrenheit2.TabStop = true;
            this.rbFahrenheit2.Text = "Fahrenheit";
            this.rbFahrenheit2.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 376);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.gbSaida);
            this.Controls.Add(this.gbEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.RadioButton rbCelsius1;
        private System.Windows.Forms.RadioButton rbKelvin1;
        private System.Windows.Forms.RadioButton rbFahrenheit1;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox gbSaida;
        private System.Windows.Forms.RadioButton rbCelsius2;
        private System.Windows.Forms.RadioButton rbKelvin2;
        private System.Windows.Forms.RadioButton rbFahrenheit2;
    }
}

