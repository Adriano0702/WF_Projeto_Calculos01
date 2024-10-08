﻿using System;
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

        bool vLimpa;
        decimal numAnt;
        string vOperacao;

        public void f_Numeros (object sender, EventArgs e)
        {
            // Se o visor estiver em zero eo botão acionado não for virgula, limpar ele para adicionar um novo número
            if (lblvisor.Text == "0" && ((Button)sender).Text != ",")
                
                lblvisor.Text = "";

            /* Se o botão não for uma virgula ou se o botão for uma virgula e o visor conter uma vigula 
             adicione o texto do botão*/
            if (((Button)sender).Text != "," || 
               (((Button)sender).Text == "," &&           // "||/ou" "!="diferente" "&&/e"  "!/NAO"
               !lblvisor.Text.Contains(","))) 
            {
                lblvisor.Text += ((Button)sender).Text;
            }

        }

        public void f_Operacoes(object sender, EventArgs e)
        {
            //Pega o nunmero do visor e armazena na variavel numAnt
            numAnt = decimal.Parse(lblvisor.Text); 
            
            //armazena operação selecionada
            vOperacao = ((Button)sender).Text;

            //
            vLimpa = true;

            // Atuliza o historico com número atual e a operação selecionada
            lblHistorico.Text += numAnt + " " + vOperacao+ "";

            //limpa o visor para proxima entrada
            lblvisor.Text = string.Empty;

            //Foca o visor, preparando para proxima entrada do usuario
            lblvisor.Focus();
        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            // Obtém o numero atual do visor 
            decimal numAtual = decimal.Parse(lblvisor.Text);
            decimal resultado = 0 ;

            // Calcula o resultado com base na operação armazenada
            switch (vOperacao)
            {
                case "+":
                    {
                        resultado = numAnt + numAtual;                                                  
                        break;
                    }
                case "-":
                    {
                        resultado = numAnt - numAtual;                        
                        break;
                    }
                case "x":
                    {
                        resultado = numAnt * numAtual;                        
                        break;
                    }
                case "/":
                    {
                        resultado = numAnt / numAtual;                        
                        break;                    
                    }
                case "%":
                    {
                        resultado = numAnt * (numAtual / 100);
                        
                        break;
                    }
            }
             lblvisor.Text = resultado.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            //limpar visor 
            lblvisor.Text = "0";


        }
    }
}
