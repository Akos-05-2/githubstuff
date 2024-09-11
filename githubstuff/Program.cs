using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubstuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            List<int> rndm_nums = new List<int>();
            Random rndm = new Random();
            for (int i = 0; i <= 100; i++)
            {
                rndm_nums.Add(rndm.Next(1, 101));
            }
            foreach (var item in rndm_nums)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            foreach (var item in rndm_nums)
            {
                if (item == 100)
                {
                    Console.WriteLine("Ez a lista fasza");
                }
            }
            Console.WriteLine();
            foreach (var item in rndm_nums)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine("Páros szám!");
                }
            }
            Console.ReadKey();
        }
    }
}
