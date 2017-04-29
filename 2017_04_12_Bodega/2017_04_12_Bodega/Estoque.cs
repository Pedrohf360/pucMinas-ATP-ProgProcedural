using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_12_Bodega
{
    class Estoque
    {
        private Item[] itensEstoque;

        public Estoque()
        {
            itensEstoque = new Item[99];
        }

        public bool AddProduto(Produto p, int quant)
        {
            for (int i = 0; i < itensEstoque.Length; i++)
            {
                if (itensEstoque[i].Produto.Equals(p))
                    return false;
                if (itensEstoque[i].Produto == null)
                {
                    itensEstoque[i].Produto = p;
                    itensEstoque[i].Quantidade = quant;
                    return true;
                }
            }

            return false;
        }

        public bool RemoverProduto(Produto p)
        {
            for (int i = 0; i < itensEstoque.Length; i++)
            {
                if (p.Equals(itensEstoque[i].Produto))
                {
                    for (int j = i; j < itensEstoque.Length - 1; j++)
                    {

                    }
                }
            }
        }


    }
}
