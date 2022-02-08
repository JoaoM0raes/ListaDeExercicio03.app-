using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 500; i++)
            {
                
                if (i%2==1 && i%3==0)
                {
                    
                    Console.WriteLine(total+=i);
                }
            }
        }
    }
}
