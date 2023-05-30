using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i * j);
                    Console.Write(" ");
                    if (i == j)
                        Console.WriteLine();
                }
            }
        }
    }
}
