using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_27_Aula08_Classes_Interface
{
    public class ContaInvestimento
    {
        private int numero;

        public ContaInvestimento(int numero)
        {
            this.numero = numero;
        }

        public double SimulaInvestimento(Operacao operacao, double deposito, double juros, int meses)
        {
            return operacao.Simular(deposito, juros, meses);
        }
    }
}
