using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2.andreew
{
    class Program
    {
        public static int[,] RandomX()
        {
            Random rand = new Random();
            int n = rand.Next(5, 10);
            int m = rand.Next(5, 10);
            int[,] X = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    X[i, j] = rand.Next(-20, 20);
                    Console.Write(X[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return X;
        }

        static void Main(string[] args)
        {
            int[,] X = RandomX();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    if (X[i, j] < 0) count++;
                    if (count == 2)
                    {
                        int divider = j + 1;
                        while (divider < X.GetLength(1))
                        {
                            int max = divider;
                            for (int t = divider; t < X.GetLength(1); t++)
                            {
                                if (X[i, t] > X[i, max]) max = t;
                            }
                            if (max != divider)
                            {
                                int tmp = X[i, max];
                                X[i, max] = X[i, divider];
                                X[i, divider] = tmp;
                            }
                            divider++;
                        }
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    Console.Write(X[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
