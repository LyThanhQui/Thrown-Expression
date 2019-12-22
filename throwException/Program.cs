using System;

namespace throwException
{
    //before C# 7
    class Program
    {
        static void Main(string[] args)
        {
            var a = Divide(10, 0);
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
        public static double Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x % y;
            }
        }
    }
}
