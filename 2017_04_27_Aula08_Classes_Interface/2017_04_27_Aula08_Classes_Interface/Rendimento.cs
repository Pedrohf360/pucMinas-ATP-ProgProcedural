using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_27_Aula08_Classes_Interface
{
    public class Rendimento : Operacao
    {
        public override double Simular(double deposito, double juros, int meses)
        {
            return deposito - (deposito * (juros * meses));
        }
    }
}
