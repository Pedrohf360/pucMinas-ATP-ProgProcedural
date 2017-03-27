using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc1
{
    public class Pessoa // Só foi pedido que se criasse a estrutura das classes deste projeto.
    {
        private String nome;
        private String endereco;

        public virtual String ImprimeDados()
        {
            return "Nome: " + nome + "\nEndereço: " + endereco;
        }

        public virtual double CalcImposto()
        {
            return 0; // Não foram dados os valores a serem combrados.
        }
    }
}
