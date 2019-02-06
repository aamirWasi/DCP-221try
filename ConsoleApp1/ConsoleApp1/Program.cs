using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                int max = int.Parse(space[0]), min = int.Parse(space[0]);
                for (int i = 0; i < space.Length; i++)
                {
                    for (int j = 1; j < space.Length; j++)
                    {
                        int diff = int.Parse(space[j]);
                        if (min > diff)
                        {
                            min = diff;
                        }
                        if (max < diff)
                        {
                            max = diff;
                        }
                    }
                }
                Console.WriteLine($"Case {t}: Among {space.Length} numbers {max} is maximum and {min} is minimum");
            }
        }
    }
}
