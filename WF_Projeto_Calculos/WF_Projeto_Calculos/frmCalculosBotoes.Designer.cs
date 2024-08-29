
namespace WF_Projeto_Calculos
{
    partial class frmCalculosBotoes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnPontenciação = new System.Windows.Forms.Button();
            this.btnParInpar = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.BackColor = System.Drawing.SystemColors.Menu;
            this.txtn1.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn1.Location = new System.Drawing.Point(40, 28);
            this.txtn1.Margin = new System.Windows.Forms.Padding(2);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(131, 33);
            this.txtn1.TabIndex = 0;
            this.txtn1.TextChanged += new System.EventHandler(this.txtn1_TextChanged);
            // 
            // txtn2
            // 
            this.txtn2.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn2.Location = new System.Drawing.Point(40, 83);
            this.txtn2.Margin = new System.Windows.Forms.Padding(2);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(131, 33);
            this.txtn2.TabIndex = 1;
            this.txtn2.TextChanged += new System.EventHandler(this.txtn2_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(8, 121);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(300, 26);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "________________________";
            this.lbl.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(58, 166);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(22, 26);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "?";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click_1);
            // 
            // btnSomar
            // 
            this.btnSomar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSomar.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(398, 143);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(167, 40);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "&somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpar.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(19, 244);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 40);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(191, 244);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(117, 40);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSubtrair.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(398, 11);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(167, 40);
            this.btnSubtrair.TabIndex = 8;
            this.btnSubtrair.Text = "&subitrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.subtrair);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMultiplicar.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(398, 187);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(167, 40);
            this.btnMultiplicar.TabIndex = 9;
            this.btnMultiplicar.Text = "&multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDividir.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(398, 55);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(2);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(167, 40);
            this.btnDividir.TabIndex = 11;
            this.btnDividir.Text = "&Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnPontenciação
            // 
            this.btnPontenciação.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPontenciação.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPontenciação.Location = new System.Drawing.Point(398, 275);
            this.btnPontenciação.Margin = new System.Windows.Forms.Padding(2);
            this.btnPontenciação.Name = "btnPontenciação";
            this.btnPontenciação.Size = new System.Drawing.Size(167, 40);
            this.btnPontenciação.TabIndex = 12;
            this.btnPontenciação.Text = "&potenciação";
            this.btnPontenciação.UseVisualStyleBackColor = true;
            this.btnPontenciação.Click += new System.EventHandler(this.btnPontenciação_Click);
            // 
            // btnParInpar
            // 
            this.btnParInpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnParInpar.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParInpar.Location = new System.Drawing.Point(398, 99);
            this.btnParInpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnParInpar.Name = "btnParInpar";
            this.btnParInpar.Size = new System.Drawing.Size(167, 40);
            this.btnParInpar.TabIndex = 13;
            this.btnParInpar.Text = "&par impar";
            this.btnParInpar.UseVisualStyleBackColor = true;
            this.btnParInpar.Click += new System.EventHandler(this.btnParInpar_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnComparar.Font = new System.Drawing.Font("Maiandra GD", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(398, 231);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(167, 40);
            this.btnComparar.TabIndex = 14;
            this.btnComparar.Text = "&comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // frmCalculosBotoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(598, 348);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnParInpar);
            this.Controls.Add(this.btnPontenciação);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCalculosBotoes";
            this.Text = "cálculo com Botões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnPontenciação;
        private System.Windows.Forms.Button btnParInpar;
        private System.Windows.Forms.Button btnComparar;
    }
}

