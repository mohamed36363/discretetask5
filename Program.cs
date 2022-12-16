using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Section1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inter the frist num");
            int Start = int.Parse(Console.ReadLine());

            Console.WriteLine("Inter the second num");
            int End = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = Start; i <= End; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                        sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine("The number {0} is prime", i);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                    continue;
                }
            }
        }
    }
}