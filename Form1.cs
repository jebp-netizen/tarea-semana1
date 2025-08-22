using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appControl2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intentoRestantes = 3;

        private void btLogin_Click(object sender, EventArgs e)
        {
            string usuario = ctUsuario.Text;
            string contraseña = ctPass.Text;

            if (usuario == "admin" && contraseña == "123qwe")
            {
                MessageBox.Show("Inicio de sesión exitoso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                intentoRestantes--;
                MessageBox.Show("Usuario o contraseña incorrectos. Intentos restantes: " + intentoRestantes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctUsuario.Clear();
                ctPass.Clear();

                if (intentoRestantes == 0)
                {
                    MessageBox.Show("Ha excedido el número máximo de intentos", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ctUsuario.Enabled = false;
                    ctPass.Enabled = false;
                    btLogin.Enabled = false;
                    Close();
                }
            }
        }

        private void ctFarenheit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir borrar, retroceder
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir números
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Permitir un punto decimal
            if (e.KeyChar == '.' && !ctFahrenheit1.Text.Contains("."))
            {
                return;
            }

            // Si llega aquí, significa que es un carácter no permitido
            e.Handled = true;
        }

        private void ctCelsius1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && !ctCelsius1.Text.Contains("."))
            {
                return;
            }

            e.Handled = true;
        }

        private void btFaC_Click(object sender, EventArgs e)
        {
            decimal fahrenheit;
                
            //TryParse convierte una cadena de texto en una variable decimal
            if (decimal.TryParse(ctFahrenheit1.Text, out fahrenheit))
            {
                decimal celsius = (fahrenheit - 32) * 5 / 9;

                ctCelsius2.Text = celsius.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor válido en Fahrenheit.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btCaF_Click(object sender, EventArgs e)
        {
            decimal celsius;

            if (decimal.TryParse(ctCelsius1.Text, out celsius))
            {
                decimal fahrenheit = (celsius * 9 / 5) + 32;

                ctFahrenheit2.Text = fahrenheit.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor válido en Celsius.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        int clicks = 0;

        private void click_panel_MouseClick(object sender, MouseEventArgs e)
        {
            clicks++;
            lClicks.Text = "__" + clicks + "__";
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            decimal pesoLb, alturaCm;

            if (decimal.TryParse(ctPeso.Text, out pesoLb) && decimal.TryParse(ctAltura.Text, out alturaCm))
            {
                // Conversión a kilogramos y metros
                decimal pesoKg = pesoLb * 0.453592m;
                decimal alturaM = alturaCm / 100;

                // Calcular IMC
                decimal imc = pesoKg / (alturaM * alturaM);

                IMC.Text = "IMC: " + imc.ToString("0.00");

                if (imc < 18.5m)
                    lClasificacion.Text = "Bajo peso";

                else if (imc >= 18.5m && imc <= 24.9m)
                    lClasificacion.Text = "Peso normal";

                else if (imc >= 25 && imc <= 29.9m)
                    lClasificacion.Text = "Sobrepeso";

                else
                    lClasificacion.Text = "Obesidad";           
               
            }
            else
            {
                MessageBox.Show("Por favor ingresa valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctPeso_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (char.IsControl(e.KeyChar))
                {
                    return;
                }

            if (char.IsDigit(e.KeyChar))
                {
                    return;
                }

            if (e.KeyChar == '.' && !ctPeso.Text.Contains("."))
                {
                    return;
                }

            e.Handled = true;   
        }

        private void ctAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && !ctAltura.Text.Contains("."))
            {
                return;
            }

            e.Handled = true;
        }
    }
}
