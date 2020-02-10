using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntgrupo_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtFibonacci.Text), A = 0, B = 1, SM, i;
            string Answer1 = "";
            for (i = 0; i < N; i++)
            {
                SM = A;
                A = B;
                B = SM + A;
                Answer1 += "LA SUMATORIA DE  " + A + " ES " + B + "\n";
                lblFibonacci.Text = Answer1;
                txtFibonacci.Text = "";
            }
        }

       

       

      

        private void btnplay_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);
            bool esprimo = true;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esprimo = false;
                    i = numero;
                }
            }
            if (esprimo)
            {
                MessageBox.Show("el numero es primo");
            }
            else
            {
                MessageBox.Show("el numero no es primo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    }


