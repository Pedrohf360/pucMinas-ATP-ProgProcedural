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
        static void ConverterStringToInt(string[] vetorString, ref int[] vetorInt)
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
        static int QuantosDias (int dia, int mes, int ano, int[] dataAtual)
        {
            // vetor dataAtual[i] = i = 0 (DIA); i = 1 (MÊS); i = 2 (ANO)

            int quantDias = 0;

            int[] diasMesesAnoAtual, diasMesesAnoInformado, diasMesesAux;

            diasMesesAnoAtual = VerificaAnoBissexto(dataAtual[2]);
            diasMesesAnoInformado = VerificaAnoBissexto(ano);

            // 1) O ano informado é menor que o ano atual.
            if (dataAtual[2] > ano)
            {
                // Soma a quant. de dias entre o dia informado e o final de seu respectivo mês + dia atual.
                quantDias = (diasMesesAnoInformado[mes - 1] - dia) + dataAtual[0];

                for (int i = ano; i < dataAtual[2]; i++)
                {
                    diasMesesAux = VerificaAnoBissexto(i);

                    for (int j = mes; j < 12; j++)
                    {
                        quantDias += diasMesesAux[j]; ;
                    }
                    mes = 0;
                }

                // Soma a quant. de dias do início do ano atual até o mês anterior ao atual.
                for (int j = 0; j < dataAtual[1] - 1; j++)
                {
                    quantDias += diasMesesAnoAtual[j];
                }

                return quantDias;
            }

            // 2) O ano informado é maior que o ano atual.
            else if (ano > dataAtual[2])
            {
                // Soma a quant. de dias entre o dia atual até o final de seu respectivo mês + dia informado.
                quantDias = (diasMesesAnoAtual[dataAtual[1] - 1] - dataAtual[0]) + dia;

                for (int i = dataAtual[2]; i < ano; i++)
                {
                    diasMesesAux = VerificaAnoBissexto(i);

                    for (int j = dataAtual[1]; j < 12; j++)
                    {
                        quantDias += diasMesesAux[j]; ;
                    }
                    dataAtual[1] = 0;
                }

                // Soma a quant. de dias do início do ano informado até o mês anterior ao informado.
                for (int j = 0; j < mes - 1; j++)
                {
                    quantDias += diasMesesAnoInformado[j];
                }

                return quantDias;
            }

            // 3) Os anos (atual e o informado pelo usuário) são iguais.
            else
            {   // 3.1) Mês atual é maior que o mês informado.
                if (dataAtual[1] > mes)
                {
                    // Calcula a quant. de dias do dia informado até o final de seu respectivo mês + quant. dias do mês atual.
                    quantDias = (diasMesesAnoInformado[mes - 1] - dia) + dataAtual[0];

                    // 3.1.1) Se a diferença entre o mês atual e o informado for maior que 1, somar os dias dos meses entre eles.
                    if (dataAtual[1] - mes > 1)
                    {
                        for (int i = mes; i < dataAtual[1] - 1; i++)
                        {
                            quantDias += diasMesesAnoAtual[i];
                        }
                    }

                    return quantDias;
                }

                // 3.2) Mês atual é menor que o mês informado.
                else if (dataAtual[1] < mes)
                {
                    quantDias = (diasMesesAnoAtual[dataAtual[1] - 1] - dataAtual[0]) + dia;
                    // 3.2.1) Se a diferença entre o mês informado e o mês atual for maior que 1, somar os dias dos meses entre eles.
                    if (mes - dataAtual[1] > 1)
                    {
                        for (int i = dataAtual[1]; i < mes - 1; i++)
                        {
                            quantDias += diasMesesAnoAtual[i];
                        }
                    }
                    return quantDias;
                }

                // 3.3) Mês atual e informado são iguais.
                else
                {
                    if (dataAtual[0] > dia) quantDias = dataAtual[0] - dia;

                    else if (dia > dataAtual[0]) quantDias = dia - dataAtual[0];

                    else quantDias = 0;

                    return quantDias;
                }
            }

            // Se não retornar nenhuma das possibilidades, significa que a verificação da data informada sofreu algum problema,
            // logo, o método deve retornar o valor da  constante "ERRO".
            return ERRO;
        }

        static void Main(string[] args)
        {
            string data;
            string[] dataAtualString;
            int[] dataAtualInt, quantDiasMeses;

            int dia, mes, ano, diferencaDiasEntreDatas;

            dataAtualInt = new int[3];

            dataAtualString = DataAtualVetor();

            ConverterStringToInt(dataAtualString, ref dataAtualInt);

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

            diferencaDiasEntreDatas = QuantosDias(dia, mes, ano, dataAtualInt);

            Console.WriteLine("Diferença de dias entre as datas informadas: {0} dias.", diferencaDiasEntreDatas);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);

        }
    }
}
