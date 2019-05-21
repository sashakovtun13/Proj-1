using System;

namespace Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi guys!");
            System.Console.WriteLine("Shehurin");
 		Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i <=20; i++)
            {
                list.Add(random.Next(1, 10));
            }
            foreach (var i in list)
            {
                if (i % 3 == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
