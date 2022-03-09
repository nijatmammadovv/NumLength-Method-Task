using System;

namespace NumLength_Method_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n The number {0} contains number of digits : {1} ", num, NumLength(num, 0));
            Console.ReadLine();
        }

        static int NumLength(int n1, int numberless)
        {
            if (n1 == 0)
                return numberless;

            return NumLength(n1 /= 10, ++numberless);

        }
    }
}