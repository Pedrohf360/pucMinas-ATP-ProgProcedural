using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_06_Aula07_Agreg_Composic_SistEmpresa
{
    class Funcionario
    {
        private int matricula;
        private String nome;

        Departamento depto;

        public Funcionario(int matric, String nome)
        {
            this.matricula = matric;
            this.nome = nome;
        }

        public override string ToString()
        {
            string dados;

            dados = "Matrícula: " + this.matricula.ToString();
            dados += "\n";
            dados += "Nome: " + this.nome;
            dados += "\n";
            dados += "Departamento: " + this.depto.ToString();

            return dados;
        }

        public int Matricula
        {
            get { return this.matricula; }
            set
            {
                if (this.matricula >= 0)
                    this.matricula = value;
            }
        }

        public String Nome
        {
            get { return this.nome; }
            set
            {
                if (value != null)
                this.nome = value;
            }
        }

        public Departamento Depto
        {
            get { return this.depto; }
            set
            {
                if (value != null)
                    this.depto = value;
            }
        }


    }
}