using System;
using static System.Console;
using static System.Convert;

namespace ZD3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1 - 1  \n2 - 2  \n3 - 3  \n");
            int n = ToInt32(ReadLine());
            if (n == 1)
            {
                int[] mas = new int[5] { 6, 3, -7, 2, -3 };
                int m = mas[0];
                int ind = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (Math.Abs(mas[i]) < m)
                    {
                        m = Math.Abs(mas[i]);
                        ind = i;
                    }
                }
                WriteLine($"Мин число: {m} индекс: {ind}");
            }
            else if (n == 2)
            {
                int[] mas = new int[10] { 3, 5, 3, 44, 21, 44, 4, 4, 8, -7 };
                string result = "";
                int count = 0;

                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas.Length; j++)
                    {
                        if (mas[i] == mas[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1) result = result + mas[i] + "; ";
                    count = 0;
                }
                WriteLine("Уникалные элементы : " + result);
            }
            else if (n == 3)
            {
                int[] mas = new int[10];
                Random rand = new Random();
                WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    mas[i] = rand.Next(-10, 10);
                    Write(mas[i] + " ");
                }
                Write("\nПоложительные элементы: ");
                for (int i = 0; i < 10; i++)
                {
                    if (mas[i] < 0)
                    {
                        mas[i] = 0;
                    }
                    else Write(mas[i] + " ");
                }
            }
        }
    }
}