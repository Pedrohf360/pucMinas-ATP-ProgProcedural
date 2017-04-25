using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_06_Aula07_AgregCompos_SistBanc
{
    class Cliente
    {
        String nome;
        int codigo;

        public Cliente(String nome, int codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

    }
}
