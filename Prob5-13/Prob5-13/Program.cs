using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[][] num = new int[3][];
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = new int[3];
                for(int j = 0; j < num[i].Length; j++)
                {
                    num[i][j] = rnd.Next(0, 9);
                }
            }

            foreach(int[] i in num)
            {
                foreach(int j in i)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
