using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private double valor1;
        private double valor2;
       
        private double resultado;

        private int operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //boton C
            tbDisplay.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //0
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //1
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //2
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //3
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //4
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //5
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //6
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //7
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //8
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //9
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //boton igual
            valor2 = Convert.ToDouble(tbDisplay.Text);
            resultado = valor1 + valor2;
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2: 
                        resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1* valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }
            tbDisplay.Text = resultado.ToString();

           
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            //boton suma
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion= 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //boton multiplicar
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //boton dividir
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }
    }
}
