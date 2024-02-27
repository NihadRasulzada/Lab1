using System;

namespace TestConsole
{
    public class Program
    {
        static void Main()
        {
            double x = 0.1, eps = 0.01, z1 = 1, S = 0;
            int fact = 1, i = 1;
            while (Math.Abs(z1) > eps)
            {
                z1 = Math.Pow(x, i);
                fact *= i++;
                z1 /= fact;
                S += z1;
            }
            Console.WriteLine(++S);
        }
    }
}