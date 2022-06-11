using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double number1 = 0, number2 = 0;
        char operator1;
        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber(object sender, EventArgs e)
        {
            var buttonPulse = ((Button)sender);

            if (textResult.Text == "0")
                textResult.Text = "";

            textResult.Text += buttonPulse.Text;
        }

        private void Button_result_Click (object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textResult.Text);

            if (operator1 == '+')
            {
                textResult.Text = (number1 + number2).ToString();
                number1 = Convert.ToDouble(textResult.Text);
            }
            else if (operator1 == '-')
            {
                textResult.Text = (number1 - number2).ToString();
                number1 = Convert.ToDouble(textResult.Text);
            }
            else if (operator1 == 'x')
            {
                textResult.Text = (number1 * number2).ToString();
                number1 = Convert.ToDouble(textResult.Text);
            }
            else if (operator1 == '÷')
            {
                if (textResult.Text != "0")
                {
                    textResult.Text = (number1 / number2).ToString();
                    number1 = Convert.ToDouble(textResult.Text);
                }
                else
                {
                    MessageBox.Show("Error, no se puede dividir entre 0!!");
                }
            }

        }

        private void buttonDeleteOne_Click(object sender, EventArgs e)
        {
            if (textResult.Text.Length > 1)
            {
                textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);
            }
            else
            {
                textResult.Text = "0";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operator1 = '\0';
            textResult.Text = "0";
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (!textResult.Text.Contains(","))
            {
                textResult.Text += ",";
            }
        }

        private void buttonSigne_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textResult.Text);
            number1 *= -1;
            textResult.Text = number1.ToString();
        }

        private void Click_Operator(object sender, EventArgs e)
        {
            var buttonPulse = ((Button)sender);

            number1 = Convert.ToDouble(textResult.Text);
            operator1 = Convert.ToChar(buttonPulse.Tag);

            if (operator1 == 'ѵ')
            {
                number1 = Math.Sqrt(number1);
                textResult.Text = number1.ToString();
            }
            else if (operator1 == '%')
            {
                textResult.Text = (number1 / 100).ToString();
                number1 = Convert.ToDouble(textResult.Text);
            }
            else
            {
                textResult.Text = "0";
            }
            
        }
    }
}
