using System;

namespace ESTRUTURA_LOOP_DE_REPETIÇÃO_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //7 - Escreva um programa que peça ao usuário para digitar uma palavra e, em seguida, imprima essa palavra de trás para frente usando um loop for.
            Console.WriteLine("Digite a palavra: ");
            string palavra = Console.ReadLine();

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(palavra[i]);
            }

        }
    }
}
