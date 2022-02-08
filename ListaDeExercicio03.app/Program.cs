using System;
using System.Linq;

namespace ListaDeExercicio03.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Alturas = new int[15];

            for (int i = 0; i <Alturas.Length; i++)
            {
                Console.WriteLine("Escreva sua Altura " + (i+1));
                Alturas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int m = Alturas.Max();
            int n = Alturas.Min();
            Console.WriteLine("a maior altura é:   " +m);
            Console.WriteLine("a menor altura é:   " + n);
        }
    }
}
