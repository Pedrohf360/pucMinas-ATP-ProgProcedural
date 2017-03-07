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

        static String PedirDataUsuario()
        {
            string dataTexto;

            int d, m, a;

            do
            {
                Console.WriteLine("Digite uma data qualquer (Ex.: 01/01/2000):");
                dataTexto = Console.ReadLine();

                SplitDataTexto(dataTexto, out d, out m, out a);

                Data.diasMeses = Data.VerificaAnoBissexto(a);

            } while (Data.VerificarData(Data.diasMeses, d, m, a) == false);

            return dataTexto;
        }

        static int Menu()
        {
            int opcao = 0;

                while (opcao < 1 || opcao > 4)
                {
                    Console.WriteLine("Digite a opção desejada:\n\n1) Digitar uma data;\n2) Adicionar dias a uma data;\n3) Descobrir qual é o dia do ano (digitando um número qualquer entre 1 e 366);\n4) Sair.");
                    opcao = int.Parse(Console.ReadLine());

                    Console.Clear();
                }

            return opcao;
        }

        static void Main(string[] args)
        {
            String dataTexto;
            int dia = 0, mes = 0, ano = 0, opcao = 0;

            do
            {
                opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        dataTexto = PedirDataUsuario();

                        SplitDataTexto(dataTexto, out dia, out mes, out ano);

                        Data data1 = new Data(dia, mes, ano);

                        Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        int quantDiasSoma;

                        DateTime d = new DateTime(ano, mes, dia);

                        Console.WriteLine("Quantos dias deseja acrescentar?");
                        quantDiasSoma = int.Parse(Console.ReadLine());

                        d = d.AddDays(quantDiasSoma);

                        Console.Write("\nNova data: {0}", d);

                        Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        int diaDoAno;

                        DateTime e = new DateTime(ano, 1, 1);

                        Console.WriteLine("Digite um número entre 1 e 366 (se bissexto) ou 365:");
                        diaDoAno = int.Parse(Console.ReadLine());

                        e = e.AddDays(diaDoAno);

                        Console.Write("\nDia informado: {0}/{1}/{2}.", e.Day, e.Month, e.Year);

                        e = e.AddDays(-1);

                        Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcao != 4);
        }
    }
}
