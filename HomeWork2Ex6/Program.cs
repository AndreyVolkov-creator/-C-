using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime. Выполнил Волков Андрей\n");

            DateTime start = DateTime.Now;

            int goodnumbers = 0;
            bool flag = false;

            for (int i = 1; i < 100000000; i++)
            {
                flag = ПроверкаНаГудностьЧисла(i);
                if (flag) goodnumbers++;

            }
            Console.WriteLine($"\nКоличество Хороших чисел в интервале от 1 до 1 000 000\n" +
                                $"составило {goodnumbers} штук");
            Console.WriteLine(DateTime.Now - start);
            Console.ReadKey();

        }

        static bool ПроверкаНаГудностьЧисла(int i)
        {
            int времянка = i;
            int суммаЧиселЧисла = 0;
            while (времянка > 0)
            {
                суммаЧиселЧисла += времянка % 10;
                времянка /= 10;
            }
            return i % суммаЧиселЧисла == 0;

        }


        }
    }

