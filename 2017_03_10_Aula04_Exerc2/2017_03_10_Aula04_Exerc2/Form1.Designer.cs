namespace _2017_03_10_Aula04_Exerc2
{
    partial class Form1
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
            this.lbSaldoIndicador = new System.Windows.Forms.Label();
            this.lbSaldoCifrao = new System.Windows.Forms.Label();
            this.lbSaldoNumero = new System.Windows.Forms.Label();
            this.btDepositar = new System.Windows.Forms.Button();
            this.btSacar = new System.Windows.Forms.Button();
            this.tbValorOperacao = new System.Windows.Forms.TextBox();
            this.lbAgenciaIndicador = new System.Windows.Forms.Label();
            this.lbNumContaIndicador = new System.Windows.Forms.Label();
            this.lbAgenciaNumero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumContaNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSaldoIndicador
            // 
            this.lbSaldoIndicador.AutoSize = true;
            this.lbSaldoIndicador.Location = new System.Drawing.Point(14, 21);
            this.lbSaldoIndicador.Name = "lbSaldoIndicador";
            this.lbSaldoIndicador.Size = new System.Drawing.Size(37, 13);
            this.lbSaldoIndicador.TabIndex = 0;
            this.lbSaldoIndicador.Text = "Saldo:";
            // 
            // lbSaldoCifrao
            // 
            this.lbSaldoCifrao.AutoSize = true;
            this.lbSaldoCifrao.Location = new System.Drawing.Point(117, 21);
            this.lbSaldoCifrao.Name = "lbSaldoCifrao";
            this.lbSaldoCifrao.Size = new System.Drawing.Size(21, 13);
            this.lbSaldoCifrao.TabIndex = 1;
            this.lbSaldoCifrao.Text = "R$";
            // 
            // lbSaldoNumero
            // 
            this.lbSaldoNumero.AutoSize = true;
            this.lbSaldoNumero.Location = new System.Drawing.Point(138, 21);
            this.lbSaldoNumero.Name = "lbSaldoNumero";
            this.lbSaldoNumero.Size = new System.Drawing.Size(0, 13);
            this.lbSaldoNumero.TabIndex = 2;
            // 
            // btDepositar
            // 
            this.btDepositar.Location = new System.Drawing.Point(10, 122);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(75, 23);
            this.btDepositar.TabIndex = 3;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(91, 122);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(75, 23);
            this.btSacar.TabIndex = 4;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // tbValorOperacao
            // 
            this.tbValorOperacao.Location = new System.Drawing.Point(176, 124);
            this.tbValorOperacao.Name = "tbValorOperacao";
            this.tbValorOperacao.Size = new System.Drawing.Size(49, 20);
            this.tbValorOperacao.TabIndex = 5;
            // 
            // lbAgenciaIndicador
            // 
            this.lbAgenciaIndicador.AutoSize = true;
            this.lbAgenciaIndicador.Location = new System.Drawing.Point(14, 52);
            this.lbAgenciaIndicador.Name = "lbAgenciaIndicador";
            this.lbAgenciaIndicador.Size = new System.Drawing.Size(49, 13);
            this.lbAgenciaIndicador.TabIndex = 6;
            this.lbAgenciaIndicador.Text = "Agência:";
            // 
            // lbNumContaIndicador
            // 
            this.lbNumContaIndicador.AutoSize = true;
            this.lbNumContaIndicador.Location = new System.Drawing.Point(14, 85);
            this.lbNumContaIndicador.Name = "lbNumContaIndicador";
            this.lbNumContaIndicador.Size = new System.Drawing.Size(77, 13);
            this.lbNumContaIndicador.TabIndex = 7;
            this.lbNumContaIndicador.Text = "Número conta:";
            // 
            // lbAgenciaNumero
            // 
            this.lbAgenciaNumero.AutoSize = true;
            this.lbAgenciaNumero.Location = new System.Drawing.Point(139, 52);
            this.lbAgenciaNumero.Name = "lbAgenciaNumero";
            this.lbAgenciaNumero.Size = new System.Drawing.Size(0, 13);
            this.lbAgenciaNumero.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // lbNumContaNumero
            // 
            this.lbNumContaNumero.AutoSize = true;
            this.lbNumContaNumero.Location = new System.Drawing.Point(139, 85);
            this.lbNumContaNumero.Name = "lbNumContaNumero";
            this.lbNumContaNumero.Size = new System.Drawing.Size(0, 13);
            this.lbNumContaNumero.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 161);
            this.Controls.Add(this.lbNumContaNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAgenciaNumero);
            this.Controls.Add(this.lbNumContaIndicador);
            this.Controls.Add(this.lbAgenciaIndicador);
            this.Controls.Add(this.tbValorOperacao);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.lbSaldoNumero);
            this.Controls.Add(this.lbSaldoCifrao);
            this.Controls.Add(this.lbSaldoIndicador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSaldoIndicador;
        private System.Windows.Forms.Label lbSaldoCifrao;
        private System.Windows.Forms.Label lbSaldoNumero;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.TextBox tbValorOperacao;
        private System.Windows.Forms.Label lbAgenciaIndicador;
        private System.Windows.Forms.Label lbNumContaIndicador;
        private System.Windows.Forms.Label lbAgenciaNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNumContaNumero;
    }
}

