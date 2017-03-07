using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_04_Aula03_Exerc1_LPOO
{
    class Data
    {
        private int dia, mes, ano;

        public static int[] diasMeses;

        private void Init(int d, int m, int a)
        {
            this.dia = d;
            this.mes = m;
            this.ano = a;
        }

        public Data()
        {
            Init(1, 1, 2001);
        }

        public Data(int d, int m, int a)
        {
            Init(d, m, a);
        }

        public static bool VerificarData(int[] diasMeses, int d, int m, int a)
        {
            if ((d < 1 || d > diasMeses[m - 1]) || (m < 1 || m > 12) || (a < 1)) return false;

            return true;
        }

        public static int[] VerificaAnoBissexto(int ano)
        {
            int[] anoComum, anoBissexto;

            anoComum = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            anoBissexto = anoComum;

            anoBissexto[1] = 29;

            if (DateTime.IsLeapYear(ano) == true) return anoBissexto;

            return anoComum;
        }


    }
}
