namespace _2017_03_13_Aula04_Exerc3
{
    partial class fmTelaIMC
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.mtbAltura = new System.Windows.Forms.MaskedTextBox();
            this.lbAlturaIndicador = new System.Windows.Forms.Label();
            this.mtbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lbPesoIndicador = new System.Windows.Forms.Label();
            this.lbIdadeAtualIndicador = new System.Windows.Forms.Label();
            this.ltbCadastros = new System.Windows.Forms.ListBox();
            this.btVerCadastros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(197, 74);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(226, 42);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(391, 13);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(75, 20);
            this.tbPeso.TabIndex = 13;
            // 
            // mtbAltura
            // 
            this.mtbAltura.Location = new System.Drawing.Point(245, 48);
            this.mtbAltura.Mask = "0.00";
            this.mtbAltura.Name = "mtbAltura";
            this.mtbAltura.Size = new System.Drawing.Size(75, 20);
            this.mtbAltura.TabIndex = 12;
            // 
            // lbAlturaIndicador
            // 
            this.lbAlturaIndicador.AutoSize = true;
            this.lbAlturaIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlturaIndicador.Location = new System.Drawing.Point(140, 48);
            this.lbAlturaIndicador.Name = "lbAlturaIndicador";
            this.lbAlturaIndicador.Size = new System.Drawing.Size(62, 20);
            this.lbAlturaIndicador.TabIndex = 11;
            this.lbAlturaIndicador.Text = "Altura:";
            // 
            // mtbDataNasc
            // 
            this.mtbDataNasc.Location = new System.Drawing.Point(245, 13);
            this.mtbDataNasc.Mask = "00/00/0000";
            this.mtbDataNasc.Name = "mtbDataNasc";
            this.mtbDataNasc.Size = new System.Drawing.Size(75, 20);
            this.mtbDataNasc.TabIndex = 10;
            // 
            // lbPesoIndicador
            // 
            this.lbPesoIndicador.AutoSize = true;
            this.lbPesoIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoIndicador.Location = new System.Drawing.Point(337, 12);
            this.lbPesoIndicador.Name = "lbPesoIndicador";
            this.lbPesoIndicador.Size = new System.Drawing.Size(54, 20);
            this.lbPesoIndicador.TabIndex = 9;
            this.lbPesoIndicador.Text = "Peso:";
            // 
            // lbIdadeAtualIndicador
            // 
            this.lbIdadeAtualIndicador.AutoSize = true;
            this.lbIdadeAtualIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdadeAtualIndicador.Location = new System.Drawing.Point(140, 11);
            this.lbIdadeAtualIndicador.Name = "lbIdadeAtualIndicador";
            this.lbIdadeAtualIndicador.Size = new System.Drawing.Size(103, 20);
            this.lbIdadeAtualIndicador.TabIndex = 8;
            this.lbIdadeAtualIndicador.Text = "Data Nasc.:";
            // 
            // ltbCadastros
            // 
            this.ltbCadastros.FormattingEnabled = true;
            this.ltbCadastros.Location = new System.Drawing.Point(12, 169);
            this.ltbCadastros.Name = "ltbCadastros";
            this.ltbCadastros.Size = new System.Drawing.Size(609, 82);
            this.ltbCadastros.TabIndex = 14;
            // 
            // btVerCadastros
            // 
            this.btVerCadastros.BackColor = System.Drawing.Color.Aquamarine;
            this.btVerCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerCadastros.Location = new System.Drawing.Point(29, 121);
            this.btVerCadastros.Name = "btVerCadastros";
            this.btVerCadastros.Size = new System.Drawing.Size(569, 42);
            this.btVerCadastros.TabIndex = 15;
            this.btVerCadastros.Text = "Ver cadastros";
            this.btVerCadastros.UseVisualStyleBackColor = false;
            this.btVerCadastros.Click += new System.EventHandler(this.btVerCadastros_Click_1);
            // 
            // fmTelaIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 261);
            this.Controls.Add(this.btVerCadastros);
            this.Controls.Add(this.ltbCadastros);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.mtbAltura);
            this.Controls.Add(this.lbAlturaIndicador);
            this.Controls.Add(this.mtbDataNasc);
            this.Controls.Add(this.lbPesoIndicador);
            this.Controls.Add(this.lbIdadeAtualIndicador);
            this.Controls.Add(this.btCadastrar);
            this.Name = "fmTelaIMC";
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.MaskedTextBox mtbAltura;
        private System.Windows.Forms.Label lbAlturaIndicador;
        private System.Windows.Forms.MaskedTextBox mtbDataNasc;
        private System.Windows.Forms.Label lbPesoIndicador;
        private System.Windows.Forms.Label lbIdadeAtualIndicador;
        private System.Windows.Forms.ListBox ltbCadastros;
        private System.Windows.Forms.Button btVerCadastros;
    }
}

