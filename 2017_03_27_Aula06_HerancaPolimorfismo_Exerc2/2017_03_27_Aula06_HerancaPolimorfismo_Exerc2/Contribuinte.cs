using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc2
{
    public abstract class Contribuinte
    {
        protected String nome;
        protected String endereco;

        public static Contribuinte[] listaContr()
        {
            Contribuinte[] lst = new Contribuinte[6];
            lst[0] = new PFisica("Joao Santos", "Rua abc, 123", 3000.00, "11111");
            lst[1] = new PJuridica("Lojas AA", "Rua Hum, 111", 150000.00, "10055");
            lst[2] = new PFisica("Maria Soares", "Av. Xyz, 777", 5000.00, "22222");
            lst[3] = new PJuridica("Supermercados B", "Rua Dois, 987", 2000000.00, "10066");
            lst[4] = new PFisica("Carla Maia", "Av. Três, 333", 1500.00, "33333");
            lst[5] = new PJuridica("Posto XX", "Rua Cinco, 555", 500000.00, "10077");
            return lst;
        }

        public String getNome()
        {
            return nome;
        }

        public abstract double calcImposto();
    }
}
