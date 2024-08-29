using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Projeto_Calculos
{
    public partial class frmCalculosBotoes : Form
    {
        public frmCalculosBotoes()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            { 
                label3.Text = "+";
                //pegando número das textBox
           
                double a = double.Parse(txtn1.Text);
                double b = double.Parse(txtn2.Text);

                //Calculando a soma
                double r = a + b;

                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            lblResultado.Text = "?";
            txtn1.Focus();
        }

        private void txtn2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtn1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void subtrair(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "-";
                //pegando número das textBox

                double a = double.Parse(txtn1.Text);
                double b = double.Parse(txtn2.Text);

                //Calculando a subtração
                double r = a - b;

                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "*";
                //pegando número das textBox

                double a = double.Parse(txtn1.Text);
                double b = double.Parse(txtn2.Text);

                //Calculando a multiplicação
                double r = a * b;

                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "/";
                //pegando número das textBox

                double a = double.Parse(txtn1.Text);
                double b = double.Parse(txtn2.Text);

                //Calculando a divisão
                double r = a / b;

                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnPontenciação_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "a^b";
                //pegando número das textBox

                double a = double.Parse(txtn1.Text);
                double b = double.Parse(txtn2.Text);

                //Calculando potenciação
                double r = Math.Pow(a,b);

                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnParInpar_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "Par/Impar";

                //pegando número das textBox
                double a = double.Parse(txtn1.Text);
                double b = double.Parse(txtn2.Text);

                //verificando se a é par ou impar               
                if(a % 2 == 0 & b % 2 == 0)
                {
                    lblResultado.Text = a + " e " + b + " são um números pares ";
                }
                else if(a % 2 == 0 )
                {
                    lblResultado.Text = a + " é par e" + b + " é impar";
                }
                else if(b % 2 == 0)
                {
                    lblResultado.Text = b + " é par e " + a + " é impar";
                }
                else 
                {
                    lblResultado.Text = a + " e " + b + " são um números impares ";
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }


        }

        private void lblResultado_Click_1(object sender, EventArgs e)
        {

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "Comparar";
                //pegando número das textBox

                double a = double.Parse(txtn1.Text);
                double b = double.Parse(txtn2.Text);

                if(a > b)
                {
                    lblResultado.Text = a + " é maior que " + b;
                }
                else if(b > a)
                {
                    lblResultado.Text = b + " é maior que " + a;
                }
                else
                {
                    lblResultado.Text = b + " é igual a " + a;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }
    }
}
