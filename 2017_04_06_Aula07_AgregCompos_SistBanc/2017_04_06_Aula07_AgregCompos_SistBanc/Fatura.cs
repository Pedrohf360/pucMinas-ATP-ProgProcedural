using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_06_Aula07_AgregCompos_SistBanc
{
    class Fatura
    {
        double total;

        public Fatura(double total)
        {
            this.total = total;
        }

        public void adiciona(double valor) 
        {
            total += valor;
        }


        public double calculaMulta() 
        {
            return total * 0.02;
        }
        
        public void imprimeDados() 
        {
            Console.WriteLine("Total fatura: " + this.total);
        }

    }
}