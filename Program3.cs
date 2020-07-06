Write the output of this code:

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Section3 s = new Section3();
            s.run();
        }
    }

    class Section3
    {
        int a, b, c = 0;
        public void run()
        {
            for (b = 6; this.MethodA(); c = a - b)
            {
                a++;
                Console.WriteLine("{0} -- {1} -- {2}", a, b, c);
            }
        }
        public bool MethodA()
        {
            if (a > 5) { return false; } else { return true; }
        }

    }
}
