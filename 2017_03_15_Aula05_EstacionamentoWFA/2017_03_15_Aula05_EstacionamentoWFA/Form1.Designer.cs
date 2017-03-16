namespace _2017_03_15_Aula05_EstacionamentoWFA
{
    partial class frmControleEstacionamento
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
            this.btCalcularValores = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.btEntrada = new System.Windows.Forms.Button();
            this.lbCarros = new System.Windows.Forms.ListBox();
            this.lbVagas = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btCalcularValores
            // 
            this.btCalcularValores.BackColor = System.Drawing.Color.LightCyan;
            this.btCalcularValores.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularValores.Location = new System.Drawing.Point(341, 126);
            this.btCalcularValores.Margin = new System.Windows.Forms.Padding(2);
            this.btCalcularValores.Name = "btCalcularValores";
            this.btCalcularValores.Size = new System.Drawing.Size(157, 35);
            this.btCalcularValores.TabIndex = 10;
            this.btCalcularValores.Text = "Verificar Valores";
            this.btCalcularValores.UseVisualStyleBackColor = false;
            this.btCalcularValores.Click += new System.EventHandler(this.btnCalcularValores);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.Lime;
            this.btListar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.Location = new System.Drawing.Point(341, 71);
            this.btListar.Margin = new System.Windows.Forms.Padding(2);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(157, 38);
            this.btListar.TabIndex = 9;
            this.btListar.Text = "Listar Carros";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar);
            // 
            // btEntrada
            // 
            this.btEntrada.BackColor = System.Drawing.Color.Orange;
            this.btEntrada.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrada.Location = new System.Drawing.Point(341, 14);
            this.btEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(157, 44);
            this.btEntrada.TabIndex = 8;
            this.btEntrada.Text = "Registrar Entrada";
            this.btEntrada.UseVisualStyleBackColor = false;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada);
            // 
            // lbCarros
            // 
            this.lbCarros.FormattingEnabled = true;
            this.lbCarros.Location = new System.Drawing.Point(12, 72);
            this.lbCarros.Name = "lbCarros";
            this.lbCarros.Size = new System.Drawing.Size(311, 95);
            this.lbCarros.TabIndex = 11;
            // 
            // lbVagas
            // 
            this.lbVagas.AutoSize = true;
            this.lbVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVagas.Location = new System.Drawing.Point(9, 14);
            this.lbVagas.Name = "lbVagas";
            this.lbVagas.Size = new System.Drawing.Size(157, 16);
            this.lbVagas.TabIndex = 12;
            this.lbVagas.Text = "Carros Estacionados:";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(149, 42);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(42, 16);
            this.lbHora.TabIndex = 13;
            this.lbHora.Text = "Hora";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.Location = new System.Drawing.Point(9, 42);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(48, 16);
            this.lbPlaca.TabIndex = 14;
            this.lbPlaca.Text = "Placa";
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Location = new System.Drawing.Point(63, 41);
            this.mtbPlaca.Mask = "LLL-0000";
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.Size = new System.Drawing.Size(60, 20);
            this.mtbPlaca.TabIndex = 15;
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(197, 41);
            this.mtbHora.Mask = "00:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(43, 20);
            this.mtbHora.TabIndex = 16;
            // 
            // frmControleEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 180);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.mtbPlaca);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lbVagas);
            this.Controls.Add(this.lbCarros);
            this.Controls.Add(this.btCalcularValores);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btEntrada);
            this.Name = "frmControleEstacionamento";
            this.Text = "Controle Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcularValores;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btEntrada;
        private System.Windows.Forms.ListBox lbCarros;
        private System.Windows.Forms.Label lbVagas;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.MaskedTextBox mtbPlaca;
        private System.Windows.Forms.MaskedTextBox mtbHora;
    }
}

