using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc1
{
    class PessoaJur : Pessoa
    {
        private String CNPJ;
        private double Faturamento;

        public override String ImprimeDados()
        {
            string aux = base.ImprimeDados();

            aux += "\nCPF: " + CNPJ + "\nSalário: " + Faturamento;

            return aux;
        }

        public override double CalcImposto()
        {
            double aux = base.CalcImposto();

            return aux;
        }
    }
