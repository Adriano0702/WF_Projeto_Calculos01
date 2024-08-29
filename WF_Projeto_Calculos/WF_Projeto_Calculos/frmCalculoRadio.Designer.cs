namespace WF_Projeto_Calculos
{
    partial class frmCalculoRadio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grupoCalc = new System.Windows.Forms.GroupBox();
            this.rdbPotenciacao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblIgualdade = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.Calcular_if_else = new System.Windows.Forms.Button();
            this.Calcular_Swit_Case = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.grupoCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoCalc
            // 
            this.grupoCalc.Controls.Add(this.rdbPotenciacao);
            this.grupoCalc.Controls.Add(this.rdbMultiplicar);
            this.grupoCalc.Controls.Add(this.rdbDividir);
            this.grupoCalc.Controls.Add(this.rdbSubtrair);
            this.grupoCalc.Controls.Add(this.rdbSomar);
            this.grupoCalc.Location = new System.Drawing.Point(23, 23);
            this.grupoCalc.Name = "grupoCalc";
            this.grupoCalc.Size = new System.Drawing.Size(200, 210);
            this.grupoCalc.TabIndex = 0;
            this.grupoCalc.TabStop = false;
            this.grupoCalc.Text = "Calculos";
            // 
            // rdbPotenciacao
            // 
            this.rdbPotenciacao.AutoSize = true;
            this.rdbPotenciacao.Location = new System.Drawing.Point(6, 168);
            this.rdbPotenciacao.Name = "rdbPotenciacao";
            this.rdbPotenciacao.Size = new System.Drawing.Size(85, 17);
            this.rdbPotenciacao.TabIndex = 4;
            this.rdbPotenciacao.Text = "Potenciação";
            this.rdbPotenciacao.UseVisualStyleBackColor = true;
            this.rdbPotenciacao.CheckedChanged += new System.EventHandler(this.rdbPotenciacao_CheckedChanged);
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdbMultiplicar.Location = new System.Drawing.Point(6, 133);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rdbMultiplicar.TabIndex = 3;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            this.rdbMultiplicar.CheckedChanged += new System.EventHandler(this.rdbMultiplicar_CheckedChanged);
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(6, 97);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(54, 17);
            this.rdbDividir.TabIndex = 2;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            this.rdbDividir.CheckedChanged += new System.EventHandler(this.rdbDividir_CheckedChanged);
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(6, 63);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdbSubtrair.TabIndex = 1;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            this.rdbSubtrair.CheckedChanged += new System.EventHandler(this.rdbSubtrair_CheckedChanged);
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(7, 31);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(55, 17);
            this.rdbSomar.TabIndex = 0;
            this.rdbSomar.Text = "Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            this.rdbSomar.CheckedChanged += new System.EventHandler(this.rdbSomar_CheckedChanged);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(324, 39);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 1;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(324, 86);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 2;
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Location = new System.Drawing.Point(269, 68);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(13, 13);
            this.lblSinal.TabIndex = 3;
            this.lblSinal.Text = "?";
            // 
            // lblIgualdade
            // 
            this.lblIgualdade.AutoSize = true;
            this.lblIgualdade.Location = new System.Drawing.Point(355, 124);
            this.lblIgualdade.Name = "lblIgualdade";
            this.lblIgualdade.Size = new System.Drawing.Size(13, 13);
            this.lblIgualdade.TabIndex = 4;
            this.lblIgualdade.Text = "=";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(346, 158);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // Calcular_if_else
            // 
            this.Calcular_if_else.Location = new System.Drawing.Point(39, 284);
            this.Calcular_if_else.Name = "Calcular_if_else";
            this.Calcular_if_else.Size = new System.Drawing.Size(120, 23);
            this.Calcular_if_else.TabIndex = 6;
            this.Calcular_if_else.Text = "Calcular(if...else)";
            this.Calcular_if_else.UseVisualStyleBackColor = true;
            this.Calcular_if_else.Click += new System.EventHandler(this.Calcular_if_else_Click);
            // 
            // Calcular_Swit_Case
            // 
            this.Calcular_Swit_Case.Location = new System.Drawing.Point(39, 338);
            this.Calcular_Swit_Case.Name = "Calcular_Swit_Case";
            this.Calcular_Swit_Case.Size = new System.Drawing.Size(120, 23);
            this.Calcular_Swit_Case.TabIndex = 7;
            this.Calcular_Swit_Case.Text = "Calcular(swit...case)";
            this.Calcular_Swit_Case.UseVisualStyleBackColor = true;
            this.Calcular_Swit_Case.Click += new System.EventHandler(this.Calcular_Swit_Case_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(207, 279);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(207, 333);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 32);
            this.btnfechar.TabIndex = 9;
            this.btnfechar.Text = "fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // frmCalculoRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.Calcular_Swit_Case);
            this.Controls.Add(this.Calcular_if_else);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblIgualdade);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.grupoCalc);
            this.Name = "frmCalculoRadio";
            this.Text = "frmCalculoRadio";
            this.grupoCalc.ResumeLayout(false);
            this.grupoCalc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoCalc;
        private System.Windows.Forms.RadioButton rdbPotenciacao;
        private System.Windows.Forms.RadioButton rdbMultiplicar;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbSomar;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblIgualdade;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button Calcular_if_else;
        private System.Windows.Forms.Button Calcular_Swit_Case;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnfechar;
    }
}