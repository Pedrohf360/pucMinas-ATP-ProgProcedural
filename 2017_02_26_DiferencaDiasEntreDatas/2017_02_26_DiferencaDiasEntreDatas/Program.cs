using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_26_DiferencaDiasEntreDatas
{
    class Program
    {
        const int ERRO = -1;

        static void SplitData (string data, out int dia, out int mes, out int ano)
        {
            string[] dataVetor;

            dataVetor = data.Split('/');

            dia = int.Parse(dataVetor[0]);

            mes = int.Parse(dataVetor[1]);

            ano = int.Parse(dataVetor[2]);
        }

        static string[] DataAtualVetor()
        {
            string[] dataAtualVetor;

            string dataAtual;

            DateTime date = DateTime.Now;

            dataAtual = date.ToString();

            dataAtual = date.ToString();

            dataAtual = dataAtual.Replace(" ", "/").Replace(":", "/");

            dataAtualVetor = dataAtual.Split('/');

            return dataAtualVetor;
        }

        /// <summary>
        /// Converte um vetor de string para um vetor de número inteiros (por referência), passando-os como parâmetros no método.
        /// </summary>
        /// <param name="vetorString">Vetor do tipo string.</param>
        /// <param name="vetorInt">Vetor do tipo int.</param>
        static void ConverterStringToInt(string[] vetorString, int[] vetorInt)
        {
            vetorInt = new int[3];

            for (int i = 0; i < vetorInt.Length; i++)
            {
                vetorInt[i] = int.Parse(vetorString[i]);
            }
        }

        /// <summary>
        /// Verify if the year informed as parameter is bissext and return a vector with the right number of days to each month (februrary, especially).
        /// </summary>
        /// <param name="ano">Actual year.</param>
        /// <returns></returns>
        static int[] VerificaAnoBissexto(int ano)
        {
            int[] anoComum, anoBissexto;

            anoComum = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (ano % 4 == 0)
            {
                if (ano % 100 != 0)
                {
                    anoBissexto = anoComum;
                    anoBissexto[1] = 29;

                    return anoBissexto;
                }
            }
            else if (ano % 400 == 0)
            {
                anoBissexto = anoComum;
                anoBissexto[1] = 29;

                return anoBissexto;
            }

            return anoComum;
        }

        static int VerificarData(int dia, int mes, int ano, int[] quantDiasMeses)
        {
            if (mes < 0 || mes > 12)
                return ERRO;

            else if (dia > quantDiasMeses[mes - 1] || dia < 0)
                return ERRO;

            else if (ano < 0)
                return ERRO;

            return 0;
        }

        /// <summary>
        /// Calcula a diferença de dias entre duas datas, uma atual e outra anterior.
        /// </summary>
        /// <param name="dia">Dia da data anterior.</param>
        /// <param name="mes">Mês da data anterior.</param>
        /// <param name="ano">Ano da data anterior.</param>
        /// <param name="dataAtual">Vetor contendo 3 posições = 0, dia; 1, mês; 2, ano.</param>
        static void QuantosDias (int dia, int mes, int ano, int[] dataAtual)
        {
            // vetor dataAtual[i] = i = 0 (DIA); i = 1 (MÊS); i = 2 (ANO)

            int quantDias = 0;

            int[] diasMesesAnoAtual, diasMesesAnoInformado;

            diasMesesAnoAtual = VerificaAnoBissexto(dataAtual[2]);
            diasMesesAnoInformado = VerificaAnoBissexto(ano);

            // O ano informado é menor que o ano atual.
            if (dataAtual[2] - ano >= 1)
            {
                if (dataAtual[1] - mes == 1)
                {

                }
            }
            // O ano informado é maior que o ano atual.
            else if (ano - dataAtual[2] >= 1)
            {

            }
            // Os anos são iguais.
            else
            {
                if (dataAtual[1] > mes)
                {
                    quantDias = 
                }
                else if (dataAtual[1] < mes)
                {

                }
                else
                {

                }
            }
            
        }

        static void Main(string[] args)
        {
            string data;
            string[] dataAtualString;
            int[] dataAtualInt, quantDiasMeses;

            int dia, mes, ano;

            dataAtualInt = new int[3];

            dataAtualString = DataAtualVetor();

            ConverterStringToInt(dataAtualString, dataAtualInt);

            // Posição 2 (index) do vetor dataAtualInt = ano atual, para verificar se é bissexto.
            quantDiasMeses = VerificaAnoBissexto(dataAtualInt[2]);

            do
            {
                Console.Write("Digite uma data (Ex.: 20/05/2017): ");
                data = Console.ReadLine();

                Console.Clear();

                SplitData(data, out dia, out mes, out ano);

                if (VerificarData(dia, mes, ano, VerificaAnoBissexto(ano)) == ERRO)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tente novamente.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (VerificarData(dia, mes, ano, quantDiasMeses) == ERRO);

            QuantosDias(dia, mes, ano, dataAtualInt);




            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);

        }
    }
}
