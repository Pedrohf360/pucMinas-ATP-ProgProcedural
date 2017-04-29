using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_27_Aula09_Interface_ClassAbst
{
    public class Empregado : Pessoa, IEmpregado
    {
        private int AnoAdmissao;
        private double SalHora;
        private int Horas;

        public Empregado(string Nome, int AnoAdmissao, double SalHora, int Horas) :
            base(Nome)
        {
            this.AnoAdmissao = AnoAdmissao;
            this.SalHora = SalHora;
            this.Horas = Horas;
        }
        public override string LerNome()
        {
            return Nome;
        }
        public double salario()
        {
            return SalHora * Horas;
        }
        public int AnosDeCasa(int AnoCorrente)
        {
            return (AnoCorrente - AnoAdmissao);
        }
    }
}
