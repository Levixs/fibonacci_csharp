using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();
            int num;
            if (int.TryParse(entrada, out num))
            {
                int a = 0, b = 1, c = 0;
                while (c < num)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                if (c == num)
                {
                    Console.WriteLine("O número " + num + " pertence à sequência de Fibonacci.");
                }
                else
                {
                    Console.WriteLine("O número " + num + " não pertence à sequência de Fibonacci.");
                }
            }
            else
            {
                Console.WriteLine("Número inválido, por favor, digite um número inteiro válido.");
            }
            Console.ReadKey();
        }
    }
}