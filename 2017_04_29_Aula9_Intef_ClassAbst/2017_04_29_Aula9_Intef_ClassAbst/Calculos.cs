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
            double somaPosicoes = 0;
            double somaPesos = 0;
            double mediaPonderada;

            for (int i = 0; i < amostra.Length; i++)
            {
                if (((i + 2) % 2) == 0) // se o valor de "i" atual é par, multiplica por 1.
                {
                    somaPosicoes += amostra[i];
                    somaPesos += 1;
                    continue;
                }

                somaPesos += 2;
                somaPosicoes += amostra[i] * 2;
            }
            
            // Média ponderada = cada elemento multiplicado por seu peso (1, 2, 1, 2...) / soma de todos pesos.

            mediaPonderada = somaPosicoes / somaPesos;

            return mediaPonderada;
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
