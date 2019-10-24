using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m,n1,m1;
            Console.WriteLine("Введите количество сторок первой матрицы");
            n = P();
            Console.WriteLine("Введите количество столбцов первой матрицы");
            m = P();
            int[,] mas = new int[n+1,m+1];
            for(int i=1;i<=n;i++)
                for(int j=1;j<=m;j++)
                {
                    mas[i, j] = P();
                }
            Console.WriteLine("Введите количество сторок второй матрицы");
            n1 = P();
            Console.WriteLine("Введите количество столбцов второй матрицы");
            m1 = P();
            int[,] mas1 = new int[n1+1, m1+1];
            for (int i = 1; i <= n1; i++)
                for (int j = 1; j <= m1; j++)
                {
                    mas1[i, j] = P();
                }
            X(mas,n,m);
            Y(mas,n,m);
            Z(mas, mas1,n,m,n1,m1);
            Console.Read();
        }
        public static void X(int[,] vs , int n,int m)            
        {
            int Max=0;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    if(Max<=vs[i,j])
                    {
                        Max = vs[i, j];
                    }
                }
            Console.WriteLine($"The bigest: {Max}");
            Console.WriteLine("/////////////////////////////////////////");
        }
        public static void Y(int[,] vs,int n,int m)
        {
            int Max = 0;
            for (int i = 1; i <= n; i++)
            {
                Max = vs[0, 0];
                for (int j = 1; j <= m; j++)
                {
                    if (Max <= vs[i, j])
                    {
                        Max = vs[i, j];
                    }
                }
                Console.WriteLine($"В {i}-й строке наибольшее число : {Max}");
            }
            Console.WriteLine("/////////////////////////////////////////");
           }
        public static void Z(int[,] vx , int[,] vs ,int n,int m,int n1,int m1)
        {
            if(m!=n1)
            {
                Console.WriteLine("Умножение не возможно!");
                return;
            }
            int i, j, k, s = 0;
            Console.WriteLine($"{n} {m1}");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= m1; j++)
                {
                    for (k = 1; k <= n1; k++)
                    {
                        s = s + (vx[i,k] * vs[k,j]);
                    }
                    Console.Write(s + " ");
                    s = 0;
                }
                Console.WriteLine();
            }
        }
        public static int P()
        {
            int x;
            var r = Console.ReadLine();
            while (!Int32.TryParse(r, out x))
            {
                Console.WriteLine("New number!");
                r = Console.ReadLine();
            }
            return x;
        }
    }
}