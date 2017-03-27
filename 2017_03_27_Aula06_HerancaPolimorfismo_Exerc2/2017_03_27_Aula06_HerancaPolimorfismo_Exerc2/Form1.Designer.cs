namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc2
{
    partial class fmIR
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
            this.btConfirmar = new System.Windows.Forms.Button();
            this.lbImpostoNum = new System.Windows.Forms.Label();
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(134, 11);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(156, 23);
            this.btConfirmar.TabIndex = 0;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // lbImpostoNum
            // 
            this.lbImpostoNum.AutoSize = true;
            this.lbImpostoNum.Location = new System.Drawing.Point(8, 56);
            this.lbImpostoNum.Name = "lbImpostoNum";
            this.lbImpostoNum.Size = new System.Drawing.Size(67, 13);
            this.lbImpostoNum.TabIndex = 4;
            this.lbImpostoNum.Text = "Imposto: R$ ";
            // 
            // cbLista
            // 
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Location = new System.Drawing.Point(85, 11);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(39, 21);
            this.cbLista.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Index contrib.:";
            // 
            // fmIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 79);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLista);
            this.Controls.Add(this.lbImpostoNum);
            this.Controls.Add(this.btConfirmar);
            this.Name = "fmIR";
            this.Text = "Imposto de Renda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label lbImpostoNum;
        private System.Windows.Forms.ComboBox cbLista;
        private System.Windows.Forms.Label label1;
    }
}

