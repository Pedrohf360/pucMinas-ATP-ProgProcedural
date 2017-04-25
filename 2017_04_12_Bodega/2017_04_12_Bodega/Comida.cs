using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_12_Bodega
{
    class Comida : Produto
    {
        static double impostoC;

        /// <summary>
        /// É executado sempre que um objeto desta classe é instanciado.
        /// </summary>
        static Comida()
        {
            impostoC = 0.18;
        }

        public Comida (string nome, double precoCusto, double margemLucro) : 
            base (nome, precoCusto, margemLucro, impostoC)
        {

        }
    }
}
