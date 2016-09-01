/* PUC MINAS - Laboratório de Computação I (SI - Noturno)
 * NOME: Pedro Henrique Ferreira Fonseca
 * MATRÍCULA: 580544
 * DATA: 27/08/16
 *  */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_PedroHenrique_SI_NOITE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa cria 3 arquivos: A, B (cópia de A) e C (concatenação de A e B).\n");

            StreamWriter writeA = new StreamWriter(@"Arquivos\A.txt");
            StreamWriter writeB = new StreamWriter(@"Arquivos\B.txt");
            StreamWriter writeC = new StreamWriter(@"Arquivos\C.txt");

            writeA.WriteLine("A) O rato roeu \r\na roupa do \r\nrei de roma.\r\n\r\n");

            writeA.Close();

            StreamReader readA = new StreamReader(@"Arquivos\A.txt");

            string A = readA.ReadToEnd();
            writeB.WriteLine("Copia o centeúdo de A: \r\n\r\n" + A);

            writeB.Close();

            StreamReader readB = new StreamReader(@"Arquivos\B.txt");

            string B = readB.ReadToEnd();
            writeC.WriteLine("Concatena o conteúdo de A e B: \r\n\r\n" + A + "\r\n" + B);

            writeC.Close();

            Console.Write("Digite qualquer tecla para sair.");
            Console.ReadKey(true); //Oculta a tecla pressionada


        }
    }
}