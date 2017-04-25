using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_06_Aula07_AgregCompos_SistBanc
{
    class Agencia
    {
        int numero;

        public Agencia(int num)
        {
            this.numero = num;
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
    }
}
