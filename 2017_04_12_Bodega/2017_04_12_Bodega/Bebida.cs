using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_12_Bodega
{
    class Bebida : Produto
    {
        static double impostoB;

        static Bebida()
        {
            impostoB = 0.45;
        }

        public Bebida(string nome, double precoCusto, double margemLucro) :
            base (nome, precoCusto, margemLucro, )
        {
            
        }
    }
}
