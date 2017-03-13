namespace _2017_06_03_Aula03_Exerc3_LPOO
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
            this.lbVolume = new System.Windows.Forms.Label();
            this.lbVolumeNum = new System.Windows.Forms.Label();
            this.btLigaDesl = new System.Windows.Forms.Button();
            this.tbLigDesl = new System.Windows.Forms.TextBox();
            this.btSomaVolume = new System.Windows.Forms.Button();
            this.btSubtraiVolume = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVolume
            // 
            this.lbVolume.AutoSize = true;
            this.lbVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolume.Location = new System.Drawing.Point(185, 65);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(76, 24);
            this.lbVolume.TabIndex = 0;
            this.lbVolume.Text = "Volume";
            // 
            // lbVolumeNum
            // 
            this.lbVolumeNum.AutoSize = true;
            this.lbVolumeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolumeNum.Location = new System.Drawing.Point(266, 67);
            this.lbVolumeNum.Name = "lbVolumeNum";
            this.lbVolumeNum.Size = new System.Drawing.Size(20, 24);
            this.lbVolumeNum.TabIndex = 1;
            this.lbVolumeNum.Text = "0";
            // 
            // btLigaDesl
            // 
            this.btLigaDesl.Location = new System.Drawing.Point(12, 64);
            this.btLigaDesl.Name = "btLigaDesl";
            this.btLigaDesl.Size = new System.Drawing.Size(73, 52);
            this.btLigaDesl.TabIndex = 2;
            this.btLigaDesl.Text = "LIGAR";
            this.btLigaDesl.UseVisualStyleBackColor = true;
            this.btLigaDesl.Click += new System.EventHandler(this.btLigaDesl_Click_1);
            // 
            // tbLigDesl
            // 
            this.tbLigDesl.Location = new System.Drawing.Point(12, 29);
            this.tbLigDesl.Name = "tbLigDesl";
            this.tbLigDesl.Size = new System.Drawing.Size(318, 20);
            this.tbLigDesl.TabIndex = 3;
            this.tbLigDesl.Text = "LIGADO";
            // 
            // btSomaVolume
            // 
            this.btSomaVolume.Location = new System.Drawing.Point(188, 93);
            this.btSomaVolume.Name = "btSomaVolume";
            this.btSomaVolume.Size = new System.Drawing.Size(32, 23);
            this.btSomaVolume.TabIndex = 4;
            this.btSomaVolume.Text = "+";
            this.btSomaVolume.UseVisualStyleBackColor = true;
            this.btSomaVolume.Click += new System.EventHandler(this.btSomaVolume_Click);
            // 
            // btSubtraiVolume
            // 
            this.btSubtraiVolume.Location = new System.Drawing.Point(226, 93);
            this.btSubtraiVolume.Name = "btSubtraiVolume";
            this.btSubtraiVolume.Size = new System.Drawing.Size(32, 23);
            this.btSubtraiVolume.TabIndex = 5;
            this.btSubtraiVolume.Text = "-";
            this.btSubtraiVolume.UseVisualStyleBackColor = true;
            this.btSubtraiVolume.Click += new System.EventHandler(this.btSubtraiVolume_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "DESLIGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSubtraiVolume);
            this.Controls.Add(this.btSomaVolume);
            this.Controls.Add(this.tbLigDesl);
            this.Controls.Add(this.btLigaDesl);
            this.Controls.Add(this.lbVolumeNum);
            this.Controls.Add(this.lbVolume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.Label lbVolumeNum;
        private System.Windows.Forms.Button btLigaDesl;
        private System.Windows.Forms.TextBox tbLigDesl;
        private System.Windows.Forms.Button btSomaVolume;
        private System.Windows.Forms.Button btSubtraiVolume;
        private System.Windows.Forms.Button button1;
    }
}

