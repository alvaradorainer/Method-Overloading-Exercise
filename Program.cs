using System;

namespace Method_Overloading_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine(Add(1, 3, true));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool grammar)
        {
            if((grammar == true) && ((x + y) == 1))
            {
                return (x + y) + " dollar";
            }
            else if(grammar == true)
            {
                return (x + y) + " dollars";
            }
            else
            {
                return (x + y).ToString();
            }
            
        }
    }
}
