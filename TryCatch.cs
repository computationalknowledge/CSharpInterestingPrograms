using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 100; int den = 0;
                try
                {
                    Console.WriteLine("Message1");
                    int res = num / den;
                    Console.WriteLine("Message2");
                }
                catch (ArithmeticException ae)
                {
                    Console.WriteLine("Message3");
                }
                Console.WriteLine("Message4");
            }

            catch (Exception e) { Console.WriteLine(e.Message); }

        }
    }


}
