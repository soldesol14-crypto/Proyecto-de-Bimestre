using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el primer campo");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el segundo campo");
            }
            // checar si lo ingresado es un numero
            double num1, num2;

            if (!double.TryParse(textBox1.Text, out num1))
          
            {
                MessageBox.Show("ERROR, ingrese un numero valido en el primer campo");
                return;
            }
            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("ERROR, ingrese un numero valido en el segundo campo");
                return;
            }
            double SUMA = num1 + num2; 
            
            label3.Text = SUMA.ToString(); 
}
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el primer campo");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el segundo campo");

            }
            double num1, num2;

            if (!double.TryParse(textBox1.Text, out num1))

            {
                MessageBox.Show("ERROR, ingrese un numero valido en el primer campo");
                return;
            }
            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("ERROR, ingrese un numero valido en el segundo campo");
                return;
            }
            double RESTA = num1 - num2;

            label4.Text = RESTA.ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el primer campo");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el segundo campo");

            }
            double num1, num2;

            if (!double.TryParse(textBox1.Text, out num1))

            {
                MessageBox.Show("ERROR, ingrese un numero valido en el primer campo");
                return;
            }
            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("ERROR, ingrese un numero valido en el segundo campo");
                return;
            }
            double MULTIPLICACIÒN = num1 * num2;

            label5.Text = MULTIPLICACIÒN.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el primer campo");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el segundo campo");

            }
            double num1, num2;

            if (!double.TryParse(textBox1.Text, out num1))

            {
                MessageBox.Show("ERROR, ingrese un numero valido en el primer campo");
                return;
            }
            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("ERROR, ingrese un numero valido en el segundo campo");
                return;
            }
            double DIVISIÒN= num1 / num2;

            label6.Text = DIVISIÒN.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el primer campo");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el segundo campo");

            }
            double num1, num2;

            if (!double.TryParse(textBox1.Text, out num1))

            {
                MessageBox.Show("ERROR, ingrese un numero valido en el primer campo");
                return;
            }
            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("ERROR, ingrese un numero valido en el segundo campo");
                return;
            }
            double POTENCIA = Math.Pow(num1, num2);

            label7.Text =  POTENCIA.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el primer campo");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("ERROR, ingrese un numero en el segundo campo");

            }
            double num1, num2;

            if (!double.TryParse(textBox1.Text, out num1))

            {
                MessageBox.Show("ERROR, ingrese un numero valido en el primer campo");
                return;
            }
            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("ERROR, ingrese un numero valido en el segundo campo");
                return;
            }
            double RADICACIÒN = Math.Sqrt(num1);
            label8.Text = RADICACIÒN.ToString();
        }
    }
}
