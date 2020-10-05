using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел. Выполнил Волков Андрей\n");
            Console.WriteLine("Введите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 < number2 && number1 < number2) Console.WriteLine($"Самое маленько число: {number1}");
            else if (number2 < number3) Console.WriteLine($"Самое маленькое число: {number2}");
            else Console.WriteLine($"Самое маленькое число {number3}");

            Console.ReadKey();
        }
    }
}
