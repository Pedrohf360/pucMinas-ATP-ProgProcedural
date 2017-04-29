using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_12_Bodega
{
    class MaterialEscolar : Produto
    {
        static double impostoME;

        static MaterialEscolar()
        {
            impostoME = 0.21;
        }

        public MaterialEscolar (string nome, double precoCusto, double margemLucro) :
            base (nome, precoCusto, margemLucro, impostoME)
        {

        }
    }
}
