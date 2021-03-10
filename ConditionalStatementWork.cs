using System;

namespace _10364
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            double x, y, time, price;
            mode = Console.ReadLine();
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (mode == "time" || mode == "price")
            {
                if (x >= 0)
                {
                    if (mode == "time")
                    {
                        price = Math.Pow(x - 1, 2);
                        Console.WriteLine("{0},{1}", x, price);
                    }
                    if (mode == "price")
                    {
                        time = Math.Sqrt(y) + 1;
                        Console.WriteLine("{0},{1}", time, y);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
            else
            {

                Console.WriteLine("Invalid mode");
            }
            Console.ReadLine();
        }

    }
}
