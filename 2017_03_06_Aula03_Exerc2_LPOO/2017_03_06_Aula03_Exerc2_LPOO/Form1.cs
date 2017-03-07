using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_03_06_Aula03_Exerc2_LPOO
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        int cont = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Intervalo do Timer
            t.Interval = 1000; // em milisegundos

            lbHoras.Text = "00:00:00";

            if (cont == 2)
            {
                t.Tick += new EventHandler(this.t_Tick);
                t.Start();
            }


            if (cont == 1)
            {
                t.Tick += new EventHandler(this.tt_Tick);
                t.Start();
            }
        }

        private void tt_Tick(object sender, EventArgs e)
        {
            int hh = 0;
            int mm = 0;
            int ss = 0;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            lbHoras.Text = time;

            hh++;
            mm++;
            ss++;
        }

        // timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            cont = 2;

            // get tempo atual
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            // TIME
            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            lbHoras.Text = time;
            }

        private void btReset_Click_1(object sender, EventArgs e)
        {
            cont = 1;

            Form1_Load(sender, e);
        }
        }
    }

