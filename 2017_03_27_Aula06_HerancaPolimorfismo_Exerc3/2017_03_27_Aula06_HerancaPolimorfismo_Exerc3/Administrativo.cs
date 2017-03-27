using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc3
{
    class Administrativo : Assistente
    {
        private String turnoDiurnoNoturno;
        private String nome;

        private double adicionalNoturno;

        public Administrativo(int numMat, string nome)
        {
            this.NumMatricula = numMat;
            this.nome = nome;
        }

    }
}
