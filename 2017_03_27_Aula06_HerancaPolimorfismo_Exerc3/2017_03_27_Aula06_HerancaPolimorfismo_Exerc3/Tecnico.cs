using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc3
{
    class Tecnico : Assistente
    {
        private double bonusSalarial;

        private String nome;

        public Tecnico(int numMat, string nome)
        {
            this.NumMatricula = numMat;
            this.nome = nome;
        }

        public override void ExibeDados()
        {
            string aux = base.ExibeDados();
        }
    }
}
