using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_06_Aula07_AgregCompos_SistBanc
{
    class CartaoDeCredito
    {
        int numero;
        String dataDeValidade;

        Cliente cliente;

        Fatura[] faturas;

        public CartaoDeCredito(int numero, String dataValid)
        {
            this.numero = numero;
            this.dataDeValidade = dataValid;
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public String DataDeValidade
        {
            get { return this.DataDeValidade; }
            set { this.dataDeValidade = value; }
        }

        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
    }
}
