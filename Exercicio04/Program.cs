using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            int number;
            
            Console.WriteLine("Escreve seu Número entre 1 e 10");
            number = Convert.ToInt32(Console.ReadLine());

            if (number>=1 && number <=10)
                
            {
                for (int i = 0; i < 11; i++)
                {
                    int multiplicação = number * i;
                    Console.WriteLine("a tabuada de " + number +" x " + i + " = " + multiplicação );
                }
            }
          
        }
    }
}
