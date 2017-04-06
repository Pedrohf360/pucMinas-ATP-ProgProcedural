using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_06_Aula07_Agreg_Composic_SistEmpresa
{
    class Departamento
    {
        private int codigo;
        private String nome;

        public Departamento (int cod, String nome)
        {
            this.codigo = cod;
            this.nome = nome;
        }

        public override String ToString()
        {
            string dados;

            dados = "Código: " + this.codigo.ToString();
            dados += "\nNome: " + this.nome;

            return dados;
        }

        /// <summary>
        /// Deve ser maior ou igual a zero.
        /// </summary>
        public int Codigo
        {
            get { return this.codigo; }
            set
            {
                if (value >= 0)
                this.codigo = value;
            }
        }

        /// <summary>
        /// Deve ser diferente de nulo.
        /// </summary>
        public String Nome
        {
            get { return this.nome; }
            set
            {
                if (value != null)
                this.nome = value;
            }
        }
    }
}