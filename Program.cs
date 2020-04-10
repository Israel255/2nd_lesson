using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("TARGIL 1 - GUESS , SECRET");
             Random num1 = new Random();
             int random_number1 = num1.Next(0, 10);
             while (true)
             {
                 Console.WriteLine("guess a number between 0-10");
                 int i1 = Convert.ToInt32(Console.ReadLine());
                 if (i1 == random_number1)
                 {
                     Console.WriteLine("very good the number is " + i1);
                     break;
                 }
                 else if (i1 > random_number1)
                 {
                     Console.WriteLine("too big");
                     continue;
                 }
                 else
                 {
                     Console.WriteLine("too small");
                     continue;
                 }
             }
             Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 2");
            for (int i2 = 1; i2 <=2000; i2++)
            {
                Console.WriteLine(i2);
            }
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 2 SEIF A");
            for (int i2a = 2; i2a <=100; i2a += 2)
            {
                Console.WriteLine(i2a);
            }
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 2 SEIF B");
            for (int i2b = 10; i2b <= 100; i2b += 10)
            {
                Console.WriteLine(i2b);
            }
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 3");
            for (int i3 = 100; i3 >= 1; i3--)
            {
                Console.WriteLine(i3);
            }
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 4");
            Console.WriteLine("please enter a number");
            int a4 = Convert.ToInt32(Console.ReadLine());
            while (a4 < 0)
            {
                if (a4 > -10 && a4 <= -100)
                {
                    Console.WriteLine("not good");
                    break;
                }
                int ahadot = a4 % 10;
                int asarot = a4 / 10;
                Console.WriteLine(ahadot);
                Console.WriteLine(asarot);
                if (asarot > ahadot)
                {
                    Console.WriteLine("asarot");
                }
                else
                {
                    Console.WriteLine("ahadot");
                }
                a4 = 0;
            }
            while (a4 > 0)
            {
                if (a4 < 10 && a4 >= 100)
                {
                    Console.WriteLine("not good");
                    break;
                }
                int ahadot = a4 % 10;
                int asarot = a4 / 10;
                Console.WriteLine(ahadot);
                Console.WriteLine(asarot);
                if (asarot > ahadot)
                {
                    Console.WriteLine("asarot");
                }
                else
                {
                    Console.WriteLine("ahadot");
                }
                a4 = 0;
            }
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 5");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("5");
            Console.WriteLine("7");
            Console.WriteLine("9");
            for (int i5 = 11; i5 < 100; i5++)
            {
                if (i5 % 2 == 0 || i5 % 3 == 0)
                {
                    continue;
                }
                else if (i5%5==0|| i5 % 7 == 0)
                {
                    continue;
                }
                else if (i5 % 9 == 0)
                {
                    continue;
                }
                Console.WriteLine(i5);
            }
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 6");
            Console.WriteLine("please enter a number that divied 5");
            int num6 = Convert.ToInt32(Console.ReadLine());
            int sum_200 = 0;
            int sum_100 = 0;
            int sum_50 = 0;
            int sum_20 = 0;
            int sum_10 = 0;
            int sum_5 = 0;
            while (num6 >= 200)
            {
                num6 -= 200;
                sum_200++;
            }
            Console.WriteLine("200: " + sum_200);
            while (num6 >= 100)
            {
                num6 -= 100;
                sum_100++;
            }
            Console.WriteLine("100: " + sum_100);
            while (num6 >= 50)
            {
                num6 -= 50;
                sum_50++;
            }
            Console.WriteLine("50: " + sum_50);
            while (num6 >= 20)
            {
                num6 -= 20;
                sum_20++;
            }
            Console.WriteLine("20: " + sum_20);
            while (num6 >= 10)
            {
                num6 -= 10;
                sum_10++;
            }
            Console.WriteLine("10: " + sum_10);
            while (num6 >= 5)
            {
                num6 -= 5;
                sum_5++;
            }
            Console.WriteLine("5: " + sum_5);
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 7");
            int number = 0;
            do
            {
                Console.WriteLine("Please enter number of lines:");
            }
            while (int.TryParse(Console.ReadLine(), out number) == false);

            Console.WriteLine();

            // 1**** - line 1 -- 5-1 = 4 *
            // 12*** - line 2 -- 5-2 = 3 *
            // 123** - line 3 -- 5-3 = 2 *
            // 1234* - line 4 -- 5-4 = 1 *
            // 12345 - line 5 -- 5-5 = 0 *
            for (int line_number = 1; line_number <= number; line_number++)
            {
                for (int row = 1; row <= line_number; row++)
                {
                    Console.Write(row);
                }
                for (int row = 1; row <= number - line_number; row++)
                {
                    Console.Write('*');
                }

                // shorter (difiicult?)
                
                for (int row = 1; row <= number; row++)
                {
                    if (row <= line_number)
                        Console.Write(row);
                    else
                        Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine("_____________________________________________________________");
        }
    }
}
