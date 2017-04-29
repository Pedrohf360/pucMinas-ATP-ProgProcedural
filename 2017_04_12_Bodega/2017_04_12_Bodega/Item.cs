using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_12_Bodega
{
    class Item
    {
        private Produto produto;
        private int quantidade;

        internal Produto Produto
        {
            get
            {
                return this.produto;
            }

            set
            {
                this.produto = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return this.quantidade;
            }

            set
            {
                this.quantidade = value;
            }
        }
    }
}
