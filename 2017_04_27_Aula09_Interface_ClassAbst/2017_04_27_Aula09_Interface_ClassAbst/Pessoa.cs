using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_27_Aula09_Interface_ClassAbst
{
    public abstract class Pessoa
    {
        protected string Nome;
        public Pessoa(string Nome)
        {
            this.Nome = Nome;
        }
        public abstract string LerNome();
    }
}
