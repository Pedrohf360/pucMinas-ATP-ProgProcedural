﻿/*
 * 3. Foi realizada uma pesquisa de algumas características físicas de 50 habitantes de uma certa região. De
cada habitante foram coletados os seguintes dados: sexo, altura, idade e cor dos olhos (A - Azuis, V -
Verdes ou C - Castanhos).
Faça um programa que leia esses dados e armazene-os em um registro do tipo vetor. Determine:
(a) a média de idade das pessoas com olhos castanhos e altura superior a 1.60 m;
(b) a maior idade entre os habitantes;
(c) a quantidade de indivíduos do sexo feminino cuja idade esteja entre 20 e 45 anos (inclusive) ou
que tenham olhos verdes e altura inferior a 1,70 m;
(d) o percentual de homens.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_12_22_CaracFisicasPesquisa
{
    class Program
    {
        struct CaracFisicas
        {
            public char sexo;
            public float altura;
            public int idade;
            public char corOlhos;
        }
        
        static void PreencheVetor(char[] sexo, float[] altura, int[] idade, char[] corOlhos, CaracFisicas[] nomePesq)
        {
            Random r = new Random();

            for (int i = 0; i < nomePesq.Length; i++)
            {
                nomePesq[i].sexo = sexo[r.Next(0, 2)]; // M ou F
                nomePesq[i].altura = altura[r.Next(0, 4)]; // 4 valores para altura
                nomePesq[i].idade = idade[r.Next(0, 6)]; // 6 idades
                nomePesq[i].corOlhos = corOlhos[r.Next(0, 3)]; // A, V ou C
            }
        }

        static void LerStruct(CaracFisicas[] nomePesq)
        {
            for (int i = 0; i < nomePesq.Length; i++)
            {
                Console.WriteLine(i+1 + ") Sexo:" + nomePesq[i].sexo);
                Console.WriteLine("Cor dos olhos: " + nomePesq[i].corOlhos);
                Console.WriteLine("Idade: " + nomePesq[i].idade);
                Console.WriteLine("Altura: " + nomePesq[i].altura);
                Console.WriteLine(new string('-', 40));
            }
        }

        static int MenuOpcoes()
        {
            int opcao;

            Console.WriteLine("Digite a opção desejada:\n\n1- Exibir informações do struct;\n2- Exibir a média de idade das pessoas com olhos castanhos e altura superior a 1.60 m\n3- Exibir a maior idade entre os habitantes;\n4- a quantidade de indivíduos do sexo feminino cuja idade esteja entre 20 e 45 anos (inclusive) ou que tenham olhos verdes e altura inferior a 1,70m;\n5- Exibir percentual de homens;\n6- Sair.");
            opcao = int.Parse(Console.ReadLine());

            while (opcao < 1 || opcao > 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O valor digitado não corresponde a nenhuma das opções. Tente novamente.");
                Console.ResetColor();

                Console.WriteLine("\n\nPressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                Console.Clear();
            }

            return opcao;
        }

        static int MenuOp2(CaracFisicas[] nomeStruct)
        {
            int MenuOp2 = 0;

            for (int i = 0; i < nomeStruct.Length; i++)
            {
                if (nomeStruct[i].altura > 1.60 && nomeStruct[i].corOlhos == 'C') MenuOp2++;
            }

            return MenuOp2;
        }

        static int Soma(CaracFisicas[] nomeStruct)
        {
            int soma = 0;

            for (int i = 0; i < nomeStruct.Length; i++)
            {
                if (nomeStruct[i].altura > 1.60 && nomeStruct[i].corOlhos == 'C')
                {
                    soma += nomeStruct[i].idade;
                }
            }

            return soma;
        }

        static double CalcMedia(int valorSomado, int qtdValores)
        {
            valorSomado /= qtdValores;

            return valorSomado; //Média
        }

        static int MaiorNum(CaracFisicas[] nomeStruct)
        {
            int maiorNum = int.MinValue;

            for (int i = 0; i < nomeStruct.Length; i++)
            {
                if (nomeStruct[i].idade > maiorNum) maiorNum = nomeStruct[i].idade;
            }

            return maiorNum;
        }

        static int MenuOp4(CaracFisicas[] nomeStruct)
        {
            int qtdOcorrencias = 0;

            for (int i = 0; i < nomeStruct.Length; i++)
            {
                if ((nomeStruct[i].sexo == 'F' && nomeStruct[i].idade >= 20 || nomeStruct[i].idade <= 45) || (nomeStruct[i].corOlhos == 'V' && nomeStruct[i].altura < 1.70)) qtdOcorrencias++;
            }

            return qtdOcorrencias;
        }

        static int QtdHomens(CaracFisicas[] nomeStruct)
        {
            int qtdHomens = 0;

            for (int i = 0; i < nomeStruct.Length; i++)
            {
                if (nomeStruct[i].sexo == 'M') qtdHomens++;
            }

            return qtdHomens;
        }

        static double CalcPorcentagem(CaracFisicas[] nomeStruct)
        {
            double percHomens;
            double qtdHomens = QtdHomens(nomeStruct);

            percHomens = qtdHomens / 50 * 100;

            return percHomens;
        }

        static void Main(string[] args)
        {
            char[] sexo, corOlhos;
            float[] altura;
            int[] idade;
            int opcao, maiorIdade, qtdOcorrenciasOp4;
            double media, percHomens;
            CaracFisicas[] pesq1;
                
            pesq1 = new CaracFisicas[50];
            sexo = new char[2] { 'M', 'F' };
            corOlhos = new char[3] { 'A', 'V', 'C' };
            altura = new float[4] { 1.50F, 1.30F, 1.70F, 1.90F };
            idade = new int[6] { 10, 15, 20, 25, 30, 35 };

            PreencheVetor(sexo, altura, idade, corOlhos, pesq1);

            do
            {
                opcao = MenuOpcoes();
                switch(opcao)
                {
                    case 1:
                        Console.Clear();

                        LerStruct(pesq1);

                        Console.WriteLine("\nPressione qualquer tecla para prosseguir.");
                        Console.ReadKey(true);
                        Console.Clear();
                    break;

                    case 2:
                        Console.Clear();

                        media = CalcMedia(Soma(pesq1), MenuOp2(pesq1));

                        Console.WriteLine("Média: {0:N2}", media);

                        Console.WriteLine("\nPressione qualquer tecla para prosseguir.");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();

                        maiorIdade = MaiorNum(pesq1);

                        Console.WriteLine("A maior idade é de: {0} anos.", maiorIdade);

                        Console.WriteLine("\nPressione qualquer tecla para prosseguir.");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();

                        qtdOcorrenciasOp4 = MenuOp4(pesq1);

                        Console.WriteLine("A quantidade de indivíduos do sexo feminino cuja idade esteja entre 20 e 45 anos (inclusive) ou que tenham olhos verdes e altura inferior a 1,70m = {0}.", qtdOcorrenciasOp4);

                        Console.WriteLine("\nPressione qualquer tecla para prosseguir.");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();

                        percHomens = CalcPorcentagem(pesq1);

                        Console.WriteLine("A porcentagem de homens é de: {0}%.", percHomens);

                        Console.WriteLine("\nPressione qualquer tecla para prosseguir.");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                }
            } while (opcao != 6);
        }
    }
}
