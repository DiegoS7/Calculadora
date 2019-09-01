using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double primero, segundo, resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bot0_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "0";
        }

        private void Bot1_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "1";
        }

        private void Bot2_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "2";
        }

        private void Bot3_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "3";
        }

        private void Bot4_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "4";
        }

        private void Bot5_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "5";
        }

        private void Bot6_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "6";
        }

        private void Bot7_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "7";
        }

        private void Bot8_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "8";
        }

        private void Bot9_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "9";
        }

        private void Botpunto_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + ".";
        }

        private void Botsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(textbox.Text);
            textbox.Clear();
        }

        private void Botresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(textbox.Text);
            textbox.Clear();
        }
        private void Botdividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(textbox.Text);
            textbox.Clear();
        }

        private void Botmultiplicar_Click(object sender, EventArgs e)
        {
            operacion = "X";
            primero = double.Parse(textbox.Text);
            textbox.Clear();
        }

        private void Botporcentaje_Click(object sender, EventArgs e)
        {
            operacion = "%";
            primero = double.Parse(textbox.Text);
            textbox.Clear();
        }

        private void Botc_Click(object sender, EventArgs e)
        {
            textbox.Clear();
        }

        private void Botigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textbox.Text);
            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    textbox.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    textbox.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    textbox.Text = resultado.ToString();
                    break;

                case "X":
                    resultado = primero * segundo;
                    textbox.Text = resultado.ToString();
                    break;

                case "%":
                    resultado = primero / 100 * segundo;
                    textbox.Text = resultado.ToString();
                    break;
            }

        }
        private void Botce_Click(object sender, EventArgs e)
        {
            if (textbox.Text.Length == 1)
            {
                textbox.Text = "";
            }
            else
            {
                textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
            }

        }
    }
}
