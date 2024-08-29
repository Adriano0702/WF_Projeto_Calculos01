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
    public partial class main__menu : Form
    {
        public main__menu()
        {
            InitializeComponent();
        }
        //abre uma nova janela dentro da janela principal
        private void janelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form obj
            frmCalculosBotoes objCalcBot = new frmCalculosBotoes(); //atribui formulario a variavel objCalcBot
            objCalcBot.MdiParent = this; //objCalcBot vira filho
            objCalcBot.Show(); //formulario é exibido dentro desta janela principal
        }

        private void main__menu_Load(object sender, EventArgs e)
        {

        }

        private void comRadiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculoRadio objCalcBot = new frmCalculoRadio();
            objCalcBot.MdiParent = this;
            objCalcBot.Show();
        }

        private void calculadoraSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcSuper objCalcBot = new frmCalcSuper();
            objCalcBot.MdiParent = this;
            objCalcBot.Show();
        }
    }
}
