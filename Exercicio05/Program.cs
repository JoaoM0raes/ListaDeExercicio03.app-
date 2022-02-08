using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                int number;

                Console.WriteLine("Escreva o primeiro número :");
                number = Convert.ToInt32(Console.ReadLine());
                int total = 0;
                if (number == 0)
                {
                    total = 1;
                    Console.WriteLine(total);
                    continue;
                }

                for (int i = number - 1; i > 0; i--)
                {
                    total = number *= i;
                    Console.WriteLine(total);

                }
            }
          
        }
    }
}
