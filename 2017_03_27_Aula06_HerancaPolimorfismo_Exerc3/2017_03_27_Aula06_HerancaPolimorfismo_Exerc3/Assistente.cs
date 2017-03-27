using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc3
{
    class Assistente : Funcionario
    {
        private int numMatricula;

        public override string ExibeDados()
        {
            Console.Write(this.numMatricula);
        }

        // MÉTS. GET/SET

        public int NumMatricula
        {
            get { return this.numMatricula; }
            set
                {
                if (value >= 0) this.numMatricula = value;
                }
        }
    }
}
