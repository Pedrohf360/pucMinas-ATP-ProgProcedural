/* Nome: Pedro H. Ferreira Fonseca
 * Matrícula: 580544
 * Exercício 1, aula 4 - TAD.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_10_Aula04_Exerc1
{
    class CartaoValeTransporte
    {
        public int numero; // número identificador do cartão valetransporte.
        private double saldo; // saldo do cartão vale-transporte.
        private Boolean bloqueado; // indica se o cartão vale-transporte está desbloqueado, e, portanto, pode ser utilizado; ou não.

        public CartaoValeTransporte(int num, double saldoInicial)
        {
            this.numero = num;
            this.saldo = saldoInicial;
            this.bloqueado = false;
        }

        public void Carregar(double credito)
        {
            if (this.bloqueado == false && credito > 0) this.saldo += credito;
        }

        public double ObterSaldoAtual()
        {
            return this.saldo;
        }

        public void Pagar(double tarifa)
        {
            if (this.bloqueado == false && tarifa > 0 && this.saldo >= tarifa) this.saldo -= tarifa;
        }

        public void Bloquear(CartaoValeTransporte destino)
        {
            this.bloqueado = true;
            destino.saldo += this.saldo;
            this.saldo = 0;
        }
    }
}
