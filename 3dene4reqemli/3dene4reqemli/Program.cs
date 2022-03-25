using System;

namespace _3dene4reqemli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 dene 4 reqemli eded daxil edin ");

            Console.WriteLine("I ededi daxil edin: ");
            
            string num1 = Console.ReadLine();

            Console.WriteLine("II ededi daxil edin:");

            string num2 = Console.ReadLine();


            Console.WriteLine("III ededi daxil edin");

            string num3 = Console.ReadLine();

            int a = int.Parse(num1);
            int b = int.Parse(num2);
            int c = int.Parse(num3);

            double d = a / 100 * 1;
            double e = b / 100 * 2;
            double f = c / 100 * 3;

            double x = d - e - f;
            double z = x + (c / 100 * 7);

            if (a>=1000 && a<10000 || b >= 1000 && b < 10000 || c >= 1000 && c < 10000)
            {
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine("Nezere alinmayib");
            }
        }
    }
}
