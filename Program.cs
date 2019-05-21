using System;

namespace Proj
{
    class Program
    {
        static void Main(string[] args)
        {
		//Kovtun
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i <=20; i++)
            {
                list.Add(random.Next(1, 10));
            }
            List<int> list2 = list.Where(x => x % 3 == 2).ToList();

            foreach(var i in list2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
