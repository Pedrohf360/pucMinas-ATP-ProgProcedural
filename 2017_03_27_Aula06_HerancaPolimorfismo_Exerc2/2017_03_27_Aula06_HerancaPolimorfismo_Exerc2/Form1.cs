using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc2
{
    public partial class fmIR : Form
    {
        Contribuinte[] listaContribuintes;

        public fmIR()
        {
            InitializeComponent();

            cbLista.Items.Add("1");
            cbLista.Items.Add("2");
            cbLista.Items.Add("3");
            cbLista.Items.Add("4");
            cbLista.Items.Add("5");
            cbLista.Items.Add("6");

            cbLista.SelectedItem = "1";

            listaContribuintes = Contribuinte.listaContr();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            lbImpostoNum.Text = "Imposto: R$ ";

            lbImpostoNum.Text += String.Format("{0:n2}", listaContribuintes[cbLista.SelectedIndex].calcImposto());
        }

        



    }
}
