namespace _2017_03_10_Aula04_Exerc2
{
    partial class fmTelaCadastro
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
            this.btDepositar = new System.Windows.Forms.Button();
            this.btSacar = new System.Windows.Forms.Button();
            this.tbValorOperacao = new System.Windows.Forms.TextBox();
            this.lbAgenciaIndicador = new System.Windows.Forms.Label();
            this.lbNumContaIndicador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.lbNomeIndicador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSaldoNum = new System.Windows.Forms.Label();
            this.lbAgenciaNum = new System.Windows.Forms.Label();
            this.lbContaNum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSaldoIndicador
            // 
            this.lbSaldoIndicador.AutoSize = true;
            this.lbSaldoIndicador.Location = new System.Drawing.Point(14, 55);
            this.lbSaldoIndicador.Name = "lbSaldoIndicador";
            this.lbSaldoIndicador.Size = new System.Drawing.Size(37, 13);
            this.lbSaldoIndicador.TabIndex = 0;
            this.lbSaldoIndicador.Text = "Saldo:";
            // 
            // btDepositar
            // 
            this.btDepositar.Location = new System.Drawing.Point(10, 156);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(75, 23);
            this.btDepositar.TabIndex = 3;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(91, 156);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(75, 23);
            this.btSacar.TabIndex = 4;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // tbValorOperacao
            // 
            this.tbValorOperacao.Location = new System.Drawing.Point(176, 158);
            this.tbValorOperacao.Name = "tbValorOperacao";
            this.tbValorOperacao.Size = new System.Drawing.Size(49, 20);
            this.tbValorOperacao.TabIndex = 5;
            // 
            // lbAgenciaIndicador
            // 
            this.lbAgenciaIndicador.AutoSize = true;
            this.lbAgenciaIndicador.Location = new System.Drawing.Point(14, 86);
            this.lbAgenciaIndicador.Name = "lbAgenciaIndicador";
            this.lbAgenciaIndicador.Size = new System.Drawing.Size(49, 13);
            this.lbAgenciaIndicador.TabIndex = 6;
            this.lbAgenciaIndicador.Text = "Agência:";
            // 
            // lbNumContaIndicador
            // 
            this.lbNumContaIndicador.AutoSize = true;
            this.lbNumContaIndicador.Location = new System.Drawing.Point(14, 119);
            this.lbNumContaIndicador.Name = "lbNumContaIndicador";
            this.lbNumContaIndicador.Size = new System.Drawing.Size(77, 13);
            this.lbNumContaIndicador.TabIndex = 7;
            this.lbNumContaIndicador.Text = "Número conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(58, 21);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(129, 20);
            this.tbNomeCliente.TabIndex = 10;
            // 
            // lbNomeIndicador
            // 
            this.lbNomeIndicador.AutoSize = true;
            this.lbNomeIndicador.Location = new System.Drawing.Point(14, 24);
            this.lbNomeIndicador.Name = "lbNomeIndicador";
            this.lbNomeIndicador.Size = new System.Drawing.Size(38, 13);
            this.lbNomeIndicador.TabIndex = 11;
            this.lbNomeIndicador.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(193, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.VerificarNomeCliente);
            // 
            // lbSaldoNum
            // 
            this.lbSaldoNum.AutoSize = true;
            this.lbSaldoNum.Location = new System.Drawing.Point(15, 10);
            this.lbSaldoNum.Name = "lbSaldoNum";
            this.lbSaldoNum.Size = new System.Drawing.Size(24, 13);
            this.lbSaldoNum.TabIndex = 12;
            this.lbSaldoNum.Text = "R$ ";
            // 
            // lbAgenciaNum
            // 
            this.lbAgenciaNum.AutoSize = true;
            this.lbAgenciaNum.Location = new System.Drawing.Point(19, 41);
            this.lbAgenciaNum.Name = "lbAgenciaNum";
            this.lbAgenciaNum.Size = new System.Drawing.Size(16, 13);
            this.lbAgenciaNum.TabIndex = 13;
            this.lbAgenciaNum.Text = "- -";
            // 
            // lbContaNum
            // 
            this.lbContaNum.AutoSize = true;
            this.lbContaNum.Location = new System.Drawing.Point(19, 74);
            this.lbContaNum.Name = "lbContaNum";
            this.lbContaNum.Size = new System.Drawing.Size(16, 13);
            this.lbContaNum.TabIndex = 14;
            this.lbContaNum.Text = "- -";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbContaNum);
            this.groupBox1.Controls.Add(this.lbAgenciaNum);
            this.groupBox1.Controls.Add(this.lbSaldoNum);
            this.groupBox1.Location = new System.Drawing.Point(112, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 96);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // fmTelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 190);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNomeIndicador);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNumContaIndicador);
            this.Controls.Add(this.lbAgenciaIndicador);
            this.Controls.Add(this.tbValorOperacao);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.lbSaldoIndicador);
            this.Name = "fmTelaCadastro";
            this.Text = "Cadastro P. Física";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSaldoIndicador;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.TextBox tbValorOperacao;
        private System.Windows.Forms.Label lbAgenciaIndicador;
        private System.Windows.Forms.Label lbNumContaIndicador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label lbNomeIndicador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbSaldoNum;
        private System.Windows.Forms.Label lbAgenciaNum;
        private System.Windows.Forms.Label lbContaNum;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

