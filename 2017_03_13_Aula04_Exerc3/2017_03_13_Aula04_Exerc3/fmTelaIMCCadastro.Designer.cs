namespace _2017_03_13_Aula04_Exerc3
{
    partial class fmTelaIMCCadastro
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
            this.btEnviarCadastro = new System.Windows.Forms.Button();
            this.lbIdadeAtualIndicador = new System.Windows.Forms.Label();
            this.lbPesoIndicador = new System.Windows.Forms.Label();
            this.mtbIdadeAtualNum = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbAlturaIndicador = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btEnviarCadastro
            // 
            this.btEnviarCadastro.BackColor = System.Drawing.Color.LightGreen;
            this.btEnviarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviarCadastro.Location = new System.Drawing.Point(52, 151);
            this.btEnviarCadastro.Name = "btEnviarCadastro";
            this.btEnviarCadastro.Size = new System.Drawing.Size(182, 83);
            this.btEnviarCadastro.TabIndex = 0;
            this.btEnviarCadastro.Text = "Confirmar";
            this.btEnviarCadastro.UseVisualStyleBackColor = false;
            this.btEnviarCadastro.Click += new System.EventHandler(this.btEnviarCadastro_Click);
            // 
            // lbIdadeAtualIndicador
            // 
            this.lbIdadeAtualIndicador.AutoSize = true;
            this.lbIdadeAtualIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdadeAtualIndicador.Location = new System.Drawing.Point(12, 33);
            this.lbIdadeAtualIndicador.Name = "lbIdadeAtualIndicador";
            this.lbIdadeAtualIndicador.Size = new System.Drawing.Size(103, 20);
            this.lbIdadeAtualIndicador.TabIndex = 1;
            this.lbIdadeAtualIndicador.Text = "Data Nasc.:";
            // 
            // lbPesoIndicador
            // 
            this.lbPesoIndicador.AutoSize = true;
            this.lbPesoIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoIndicador.Location = new System.Drawing.Point(12, 69);
            this.lbPesoIndicador.Name = "lbPesoIndicador";
            this.lbPesoIndicador.Size = new System.Drawing.Size(54, 20);
            this.lbPesoIndicador.TabIndex = 2;
            this.lbPesoIndicador.Text = "Peso:";
            // 
            // mtbIdadeAtualNum
            // 
            this.mtbIdadeAtualNum.Location = new System.Drawing.Point(124, 35);
            this.mtbIdadeAtualNum.Mask = "00/00/0000";
            this.mtbIdadeAtualNum.Name = "mtbIdadeAtualNum";
            this.mtbIdadeAtualNum.Size = new System.Drawing.Size(75, 20);
            this.mtbIdadeAtualNum.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(124, 103);
            this.maskedTextBox1.Mask = "0.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // lbAlturaIndicador
            // 
            this.lbAlturaIndicador.AutoSize = true;
            this.lbAlturaIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlturaIndicador.Location = new System.Drawing.Point(12, 104);
            this.lbAlturaIndicador.Name = "lbAlturaIndicador";
            this.lbAlturaIndicador.Size = new System.Drawing.Size(62, 20);
            this.lbAlturaIndicador.TabIndex = 5;
            this.lbAlturaIndicador.Text = "Altura:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 7;
            // 
            // fmTelaIMCCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lbAlturaIndicador);
            this.Controls.Add(this.mtbIdadeAtualNum);
            this.Controls.Add(this.lbPesoIndicador);
            this.Controls.Add(this.lbIdadeAtualIndicador);
            this.Controls.Add(this.btEnviarCadastro);
            this.Name = "fmTelaIMCCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.fmTelaIMCCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEnviarCadastro;
        private System.Windows.Forms.Label lbIdadeAtualIndicador;
        private System.Windows.Forms.Label lbPesoIndicador;
        private System.Windows.Forms.MaskedTextBox mtbIdadeAtualNum;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lbAlturaIndicador;
        private System.Windows.Forms.TextBox textBox1;
    }
}