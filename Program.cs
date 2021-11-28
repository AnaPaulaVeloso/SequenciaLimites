using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o numero inicial da sequência..:");
            int primeiro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o numero final da sequência....:");
            int segundo = Convert.ToInt32(Console.ReadLine());

            if (segundo >= primeiro)
            {
                int n = primeiro;
                while (n <= segundo)
                {
                    Console.Write($"{n} ");
                    n += 1;
                }
            }
            else
            {
                Console.WriteLine("Não é possível realizar a sequência");
            }

        }
    }
}
