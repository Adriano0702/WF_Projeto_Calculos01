using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Projeto_Calculos
{
    public partial class frmCalculoRadio : Form
    {
        public frmCalculoRadio()
        {
            InitializeComponent();
        }

        private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "+";          
        }

        private void rdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
        }

        private void rdbDividir_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "/";
        }

        private void rdbMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "*";
        }

        private void rdbPotenciacao_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "pot";
        }

        private void Calcular_if_else_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbSomar.Checked)
                {
                    double a = double.Parse(txtn1.Text);
                    double b = double.Parse(txtn2.Text);

                    //Calculando a soma
                    double r = a + b;

                    //Mostrando o Resultado
                    lblResultado.Text = r.ToString();
                }
                else if (rdbSubtrair.Checked)
                {
                    double a = double.Parse(txtn1.Text);
                    double b = double.Parse(txtn2.Text);

                    //Calculando a subtração
                    double r = a - b;

                    //Mostrando o Resultado
                    lblResultado.Text = r.ToString();
                }
                else if (rdbDividir.Checked)
                {
                    double a = double.Parse(txtn1.Text);
                    double b = double.Parse(txtn2.Text);

                    //Calculando a subtração
                    double r = a / b;

                    //Mostrando o Resultado
                    lblResultado.Text = r.ToString();
                }
                else if (rdbMultiplicar.Checked)
                {
                    double a = double.Parse(txtn1.Text);
                    double b = double.Parse(txtn2.Text);

                    //Calculando a subtração
                    double r = a * b;

                    //Mostrando o Resultado
                    lblResultado.Text = r.ToString();
                }
                else if (rdbPotenciacao.Checked)
                {
                    double a = double.Parse(txtn1.Text);
                    double b = double.Parse(txtn2.Text);

                    //Calculando a subtração
                    double r = Math.Pow(a, b);

                    //Mostrando o Resultado
                    lblResultado.Text = r.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "Resultado";
            txtn1.Focus();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Calcular_Swit_Case_Click(object sender, EventArgs e)
        {

            switch (lblSinal.Text)
            {
                case "+":
                { 
                    double a = double.Parse(txtn1.Text);
                    double b = double.Parse(txtn2.Text);

                    //Calculando a soma
                    double r = a + b;

                    //Mostrando o Resultado
                    lblResultado.Text = r.ToString();
                    break;
                 }
                case "-":
                {
                    double a = double.Parse(txtn1.Text);
                    double b = double.Parse(txtn2.Text);

                    //Calculando a subtração
                    double r = a - b;

                    //Mostrando o Resultado
                    lblResultado.Text = r.ToString();
                    break;
                }
                case "/":
                    {
                        double a = double.Parse(txtn1.Text);
                        double b = double.Parse(txtn2.Text);

                        //Calculando a subtração
                        double r = a / b;

                        //Mostrando o Resultado
                        lblResultado.Text = r.ToString();
                        break;
                    }
                case "*":
                    {
                        double a = double.Parse(txtn1.Text);
                        double b = double.Parse(txtn2.Text);

                        //Calculando a subtração
                        double r = a * b;

                        //Mostrando o Resultado
                        lblResultado.Text = r.ToString();
                        break;
                    }
                case "pot":
                    {
                        double a = double.Parse(txtn1.Text);
                        double b = double.Parse(txtn2.Text);

                        //Calculando a subtração
                        double r = Math.Pow(a,b);

                        //Mostrando o Resultado
                        lblResultado.Text = r.ToString();
                        break;
                    }
            }
        }
    }
}
