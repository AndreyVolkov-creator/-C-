using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex2
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine("Написать метод подсчета количества цифр числа. Выполнил Волков Андрей\n");
			Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                if (number < 10) Console.WriteLine("Кол-во цифр числа = 1");
                else if (number < 100) Console.WriteLine("Кол-во цифр числа = 2");
                else if (number < 1000) Console.WriteLine("Кол-во цифр числа = 3");
                else if (number < 10000) Console.WriteLine("Кол-во цифр числа = 4");
                else if (number < 100000) Console.WriteLine("Кол-во цифр числа = 5");
                else if (number < 1000000) Console.WriteLine("Кол-во цифр числа = 6");
            }
            Console.ReadKey();
			
		}
    }
}
