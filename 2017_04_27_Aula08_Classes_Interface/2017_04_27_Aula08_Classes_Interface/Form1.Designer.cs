namespace _2017_04_27_Aula08_Classes_Interface
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
            this.lbOperacao = new System.Windows.Forms.Label();
            this.lbMeses = new System.Windows.Forms.Label();
            this.lbJuros = new System.Windows.Forms.Label();
            this.lbDeposito = new System.Windows.Forms.Label();
            this.cbxOperacao = new System.Windows.Forms.ComboBox();
            this.tbxDeposito = new System.Windows.Forms.TextBox();
            this.tbxJuros = new System.Windows.Forms.TextBox();
            this.tbxMeses = new System.Windows.Forms.TextBox();
            this.btSimular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOperacao
            // 
            this.lbOperacao.AutoSize = true;
            this.lbOperacao.Location = new System.Drawing.Point(47, 23);
            this.lbOperacao.Name = "lbOperacao";
            this.lbOperacao.Size = new System.Drawing.Size(114, 13);
            this.lbOperacao.TabIndex = 0;
            this.lbOperacao.Text = "Selecione a operação:";
            // 
            // lbMeses
            // 
            this.lbMeses.AutoSize = true;
            this.lbMeses.Location = new System.Drawing.Point(326, 74);
            this.lbMeses.Name = "lbMeses";
            this.lbMeses.Size = new System.Drawing.Size(38, 13);
            this.lbMeses.TabIndex = 1;
            this.lbMeses.Text = "Meses";
            // 
            // lbJuros
            // 
            this.lbJuros.AutoSize = true;
            this.lbJuros.Location = new System.Drawing.Point(173, 74);
            this.lbJuros.Name = "lbJuros";
            this.lbJuros.Size = new System.Drawing.Size(32, 13);
            this.lbJuros.TabIndex = 2;
            this.lbJuros.Text = "Juros";
            // 
            // lbDeposito
            // 
            this.lbDeposito.AutoSize = true;
            this.lbDeposito.Location = new System.Drawing.Point(10, 74);
            this.lbDeposito.Name = "lbDeposito";
            this.lbDeposito.Size = new System.Drawing.Size(49, 13);
            this.lbDeposito.TabIndex = 3;
            this.lbDeposito.Text = "Depósito";
            // 
            // cbxOperacao
            // 
            this.cbxOperacao.FormattingEnabled = true;
            this.cbxOperacao.Location = new System.Drawing.Point(164, 20);
            this.cbxOperacao.Name = "cbxOperacao";
            this.cbxOperacao.Size = new System.Drawing.Size(121, 21);
            this.cbxOperacao.TabIndex = 4;
            // 
            // tbxDeposito
            // 
            this.tbxDeposito.Location = new System.Drawing.Point(60, 71);
            this.tbxDeposito.Name = "tbxDeposito";
            this.tbxDeposito.Size = new System.Drawing.Size(100, 20);
            this.tbxDeposito.TabIndex = 5;
            // 
            // tbxJuros
            // 
            this.tbxJuros.Location = new System.Drawing.Point(207, 71);
            this.tbxJuros.Name = "tbxJuros";
            this.tbxJuros.Size = new System.Drawing.Size(100, 20);
            this.tbxJuros.TabIndex = 6;
            // 
            // tbxMeses
            // 
            this.tbxMeses.Location = new System.Drawing.Point(366, 71);
            this.tbxMeses.Name = "tbxMeses";
            this.tbxMeses.Size = new System.Drawing.Size(100, 20);
            this.tbxMeses.TabIndex = 7;
            // 
            // btSimular
            // 
            this.btSimular.Location = new System.Drawing.Point(171, 116);
            this.btSimular.Name = "btSimular";
            this.btSimular.Size = new System.Drawing.Size(75, 23);
            this.btSimular.TabIndex = 8;
            this.btSimular.Text = "Simular";
            this.btSimular.UseVisualStyleBackColor = true;
            this.btSimular.Click += new System.EventHandler(this.btSimular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 154);
            this.Controls.Add(this.btSimular);
            this.Controls.Add(this.tbxMeses);
            this.Controls.Add(this.tbxJuros);
            this.Controls.Add(this.tbxDeposito);
            this.Controls.Add(this.cbxOperacao);
            this.Controls.Add(this.lbDeposito);
            this.Controls.Add(this.lbJuros);
            this.Controls.Add(this.lbMeses);
            this.Controls.Add(this.lbOperacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOperacao;
        private System.Windows.Forms.Label lbMeses;
        private System.Windows.Forms.Label lbJuros;
        private System.Windows.Forms.Label lbDeposito;
        private System.Windows.Forms.ComboBox cbxOperacao;
        private System.Windows.Forms.TextBox tbxDeposito;
        private System.Windows.Forms.TextBox tbxJuros;
        private System.Windows.Forms.TextBox tbxMeses;
        private System.Windows.Forms.Button btSimular;
    }
}

