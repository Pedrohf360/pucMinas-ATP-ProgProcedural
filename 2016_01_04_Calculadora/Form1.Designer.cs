namespace _2016_01_04_Calculadora
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
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btIgualdade = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.btDividi = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMultiplica = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btSubtrai = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(37, 59);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(251, 20);
            this.tbResultado.TabIndex = 0;
            // 
            // btIgualdade
            // 
            this.btIgualdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgualdade.Location = new System.Drawing.Point(199, 257);
            this.btIgualdade.Name = "btIgualdade";
            this.btIgualdade.Size = new System.Drawing.Size(47, 30);
            this.btIgualdade.TabIndex = 1;
            this.btIgualdade.Text = "=";
            this.btIgualdade.UseVisualStyleBackColor = true;
            this.btIgualdade.Click += new System.EventHandler(this.btIgualdade_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(199, 107);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(47, 30);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.BtNumero);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(120, 107);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(47, 30);
            this.bt8.TabIndex = 5;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.BtNumero);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(37, 107);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(47, 30);
            this.bt7.TabIndex = 6;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.BtNumero);
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(272, 111);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(29, 22);
            this.btSoma.TabIndex = 7;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.BtOperador);
            // 
            // btDividi
            // 
            this.btDividi.Location = new System.Drawing.Point(272, 209);
            this.btDividi.Name = "btDividi";
            this.btDividi.Size = new System.Drawing.Size(29, 22);
            this.btDividi.TabIndex = 11;
            this.btDividi.Text = "/";
            this.btDividi.UseVisualStyleBackColor = true;
            this.btDividi.Click += new System.EventHandler(this.BtOperador);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(37, 205);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(47, 30);
            this.bt1.TabIndex = 10;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.BtNumero);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(120, 205);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(47, 30);
            this.bt2.TabIndex = 9;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.BtNumero);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(199, 205);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(47, 30);
            this.bt3.TabIndex = 8;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.BtNumero);
            // 
            // btMultiplica
            // 
            this.btMultiplica.Location = new System.Drawing.Point(272, 261);
            this.btMultiplica.Name = "btMultiplica";
            this.btMultiplica.Size = new System.Drawing.Size(29, 22);
            this.btMultiplica.TabIndex = 15;
            this.btMultiplica.Text = "*";
            this.btMultiplica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMultiplica.UseVisualStyleBackColor = true;
            this.btMultiplica.Click += new System.EventHandler(this.BtOperador);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(37, 257);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(47, 30);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(120, 257);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(47, 30);
            this.bt0.TabIndex = 13;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.BtNumero);
            // 
            // btSubtrai
            // 
            this.btSubtrai.Location = new System.Drawing.Point(272, 158);
            this.btSubtrai.Name = "btSubtrai";
            this.btSubtrai.Size = new System.Drawing.Size(29, 22);
            this.btSubtrai.TabIndex = 19;
            this.btSubtrai.Text = "-";
            this.btSubtrai.UseVisualStyleBackColor = true;
            this.btSubtrai.Click += new System.EventHandler(this.BtOperador);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(37, 154);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(47, 30);
            this.bt4.TabIndex = 18;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.BtNumero);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(120, 154);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(47, 30);
            this.bt5.TabIndex = 17;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.BtNumero);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(199, 154);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(47, 30);
            this.bt6.TabIndex = 16;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.BtNumero);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 337);
            this.Controls.Add(this.btSubtrai);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.btMultiplica);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btDividi);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btIgualdade);
            this.Controls.Add(this.tbResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btIgualdade;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btDividi;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btMultiplica;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btSubtrai;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
    }
}

