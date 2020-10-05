using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. Выполнил Волков Андрей\n");
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
            while (number != 0)
            {
                Console.WriteLine("Введите еще одно число");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 && number % 2 != 0 ) summ = summ + number;
            }
            Console.WriteLine("Вы ввели 0");
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {summ}");


            Console.ReadKey();
        }
    }
}
