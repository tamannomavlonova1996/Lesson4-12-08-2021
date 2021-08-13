using System;
using System.ComponentModel.Design;
using System.Text.Json;

namespace lesson4_12_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // задача1.1
             Console.Write("a:");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.Write("b:");
             int b = Convert.ToInt32(Console.ReadLine());
             int sum = 0;
             for (int i = a+1; i < b; i++) 
             {
                 sum = i + sum;
             }
             Console.WriteLine(sum);
            
             // Задача 1.2
             Console.Write("a:");
             int c = Convert.ToInt32(Console.ReadLine());
             Console.Write("b:");
             int d = Convert.ToInt32(Console.ReadLine());
             for (int i = c + 1; i < d; i++)
             {
                 if (i % 2 != 0)
                 {
                     Console.WriteLine(i);
                 }
            }
            
            //задача 3
            double S = 1000.0;
            double P = Convert.ToInt32(Console.ReadLine());
            double vk = 1100.0;
            int month = 0;
            for (int i = 0; S <= vk; i++)
            {
                double protcent = (S * P / 100);
                S = protcent + S;
                month = i + 1;
            }
            Console.WriteLine($"month={month},сумма с учетом вклада={S} ");
            
            
            // Задача 2
            // прямоугольник
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 15; j++)
                {
                    if (i == 0 || i == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(j == 0 || j == 14 ? "*" : " ");
                    }
                }
            
                Console.WriteLine();
            }
            // прямоугольный треугольник
             for (var i = 0; i < 5; i++)
             {
                 for (var j = 0; j < 5; j++)
                 {
                     if (i == 4)
                     {
                         Console.Write("*");
                     }
                     else
                     {
                         Console.Write(j == 0 || j==i? "*" : " ");
                     }
                 }
            
                 Console.WriteLine();
            }

            //равносторонний треугольник
              for (int i = 0; i <= 6; i++)
            {
                for (int k = 6 - i; k >= 0; k--)
                {
                    Console.Write("  ");
                }
                if (i >= 2 && i < 6)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            //Ромб
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (j == 5)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
                else
                {
                    int left = 5 - i;
                    int right = 5 + i;
                    for (int j = 0; j < 10; j++)
                    {
                        if (j == left)
                        {
                            Console.Write("*");
                        }
                        else if (j == right)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (j == 5)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
                else
                {
                    int left = 1 + i;
                    int right = 9 - i;
                    for (int j = 0; j < 10; j++)
                    {
                        if (j == left)
                        {
                            Console.Write("*");
                        }
                        else if (j == right)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}