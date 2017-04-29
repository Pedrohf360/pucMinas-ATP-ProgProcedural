using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_29_Aula9_Intef_ClassAbst
{
    public class Calculos: IMediaAritmetica, IMediaPonderada
    {
        private int[] amostra; // Quantidade de itens observados.

        public Calculos (int[] amostra)
        {
            this.amostra = amostra;
        }

        public double SomaAmostra()
        {
            return amostra.Sum();
        }

        public double MediaAritmetica()
        {
            return SomaAmostra() / amostra.Length;
        }

        public double MediaPonderada()
        {
            double soma = 0;

            for (int i = 0; i < amostra.Length; i++)
            {
                if (((i * 2) % 2) == 0) // se o valor de "i" atual é par, multiplica por 1.
                {
                    soma += amostra[i] * 2;
                    continue;
                }

                soma += amostra[i] * 1;
            }
        }

        public int[] Amostra
        {
            get
            {
                return this.amostra;
            }
            set
            {
                this.amostra = value;
            }
        }
    }
}
