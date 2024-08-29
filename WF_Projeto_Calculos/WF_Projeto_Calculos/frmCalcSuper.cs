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
    public partial class frmCalcSuper : Form
    {
        public frmCalcSuper()
        {
            InitializeComponent();
        }

        public void f_Numeros (object sender, EventArgs e)
        {
            
            if (lblvisor.Text == "0" && ((Button)sender).Text != ",")
                
                lblvisor.Text = "";

            if (((Button)sender).Text != "," || 
               (((Button)sender).Text == "," &&  // "||/ou" "!="diferente" "&&/e"  "!/NAO"
               !lblvisor.Text.Contains(","))) 

               {

                lblvisor.Text += ((Button)sender).Text;
            }

        }

        public void f_Operacoes(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
        
        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {

        }
    }
}
