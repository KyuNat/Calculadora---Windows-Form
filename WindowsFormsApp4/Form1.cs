using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        private NumberStyles cultureInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")

            {
         
                    valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                    if (operacao == "SOMA")
                    {
                        txtResultado.Text = Convert.ToString(valor1 + valor2);

                    }
                    else if (operacao == "MENOS")
                    {

                        txtResultado.Text = Convert.ToString(valor1 - valor2);
                    }
                    else if (operacao == "DIV")
                    {

                        try
                        {
                            txtResultado.Text = Convert.ToString(valor1 / valor2);
                            if (valor2 == 0 || valor1 == 0)
                            {
                                {
                                    throw new DivideByZeroException();

                                }
                            }
                        }
                        catch (DivideByZeroException)
                        {


                            MessageBox.Show("Não é possivel dividir por zero");
                            txtResultado.Text = "";
                            lblOperacao.Text = "";
                            valor1 = 0;
                            valor2 = 0;

                        };


                    }
                    else if (operacao == "MULT")
                    {
                        txtResultado.Text = Convert.ToString(valor1 * valor2);

                    }

                operacao = "";
                lblOperacao.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
           
            txtResultado.Text = "";
        }

        private void lbloperacao_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                if (operacao == "")
                {
                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    txtResultado.Text = "";
                    operacao = "MENOS";
                    lblOperacao.Text = "-";
                }
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                if (operacao == "")
                {
                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    txtResultado.Text = "";
                    operacao = "DIV";
                    lblOperacao.Text = "/";
                }
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                if (operacao == "")
                {
                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    txtResultado.Text = "";
                    operacao = "MULT";
                    lblOperacao.Text = " X ";
                }
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            operacao = "";
            txtResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                double numero = double.Parse(txtResultado.Text);
                double resultado = Math.Sqrt(numero);
                txtResultado.Text = resultado.ToString();
            } else
            {
                MessageBox.Show("Digite um valor antes de pressionar √ ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                double valor = double.Parse(txtResultado.Text);
                valor *= 0.01;
                txtResultado.Text = valor.ToString();
            } else
            {
                MessageBox.Show("Adicione um valor antes de clicar na %");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtResultado.Text);
            valor = Math.Pow(valor, 2);
            txtResultado.Text = valor.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Double PI = 3.14159265359;
            txtResultado.Text = PI.ToString();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                if (operacao == "")
                {

                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    txtResultado.Text = "";
                    operacao = "SOMA";
                    lblOperacao.Text = " + ";
                }
            }
        }
    }
}
