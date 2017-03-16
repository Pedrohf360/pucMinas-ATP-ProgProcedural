using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_03_13_Aula04_Exerc3
{
    public partial class fmTelaIMCVerCadastro : Form
    {
        public fmTelaIMCVerCadastro()
        {
            InitializeComponent();
        }

        private void fmTelaIMCVerCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btVoltarMenu_Click(object sender, EventArgs e)
        {
            fmTelaIMC retornarForm = new fmTelaIMC();

            retornarForm.Close();

            retornarForm.Show();
        }
    }
}
