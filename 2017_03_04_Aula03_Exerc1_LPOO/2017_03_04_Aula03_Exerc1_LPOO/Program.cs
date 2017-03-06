using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_04_Aula03_Exerc1_LPOO
{
    class Program
    {
        static void SplitDataTexto(string dataTexto, out int d, out int m, out int a)
        {
            String[] dataTextoVetor;

            dataTextoVetor = dataTexto.Split('/');

            d = int.Parse(dataTextoVetor[0]);
            m = int.Parse(dataTextoVetor[1]);
            a = int.Parse(dataTextoVetor[2]); 
        }

        static void PedirDataUsuario()
        {
            string dataTexto;

            int d, m, a;

            do
            {
                Console.WriteLine("Digite uma data qualquer (Ex.: 01/01/2000):");
                dataTexto = Console.ReadLine();

                SplitDataTexto(dataTexto, out d, out m, out a);
            } while (ver);
        }

        static void Main(string[] args)
        {
            String dataTexto;
            int dia, mes, ano;

            SplitDataTexto(dataTexto, out dia, out mes, out ano);

            Data.diasMeses = Data.VerificaAnoBissexto(ano);

            Data data1 = new Data(dia, mes, ano);



            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);  
        }
    }
}
