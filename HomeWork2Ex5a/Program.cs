using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex5a
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме. Выполнил Волков Андрей\n");
            Console.WriteLine("Введите Ваш вес:");
            double weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Ваш рост:");
            double height = Convert.ToInt32(Console.ReadLine());
            int degree = 10000;
            double i = Convert.ToInt32((weight / (height * height)) * degree);

            if (i < 16)
            {
                Console.WriteLine("У вас выраженный дефицит массы тела. Вам нужно набрать массу");
                Console.WriteLine($"Ваш ИМТ: {i:f2}");
            }
            else if (i>=16 && i < 18 ){
                Console.WriteLine("У вас недостаточная масса тела. Вам нужно набрать массу");
                Console.WriteLine($"Ваш ИМТ: {i:f2}");
            }
            else if (i >= 18 && i < 25)
            {
                Console.WriteLine("У вас нормальная масса тела.");
                Console.WriteLine($"Ваш ИМТ: {i:f2}");
            }
            else if (i >= 25 && i < 30)
            {
                Console.WriteLine("У вас избыточная масса тела. Вам нужно сбросить массу");
                Console.WriteLine($"Ваш ИМТ: {i:f2}");
            }
            else if (i >= 30 && i < 35)
            {
                Console.WriteLine("У вас ожирение. Вам нужно сбросить массу");
                Console.WriteLine($"Ваш ИМТ: {i:f2}");
            }
            else if (i >= 35 && i < 40)
            {
                Console.WriteLine("У вас резкое ожирение. Вам нужно сбросить массу");
                Console.WriteLine($"Ваш ИМТ: {i:f2}");
            }
            else if (i >= 40)
            {
                Console.WriteLine("У вас очень резкое ожирение. Вам нужно сбросить массу");
                Console.WriteLine($"Ваш ИМТ: {i:f2}");
            }


            Console.ReadKey();
        }
    }
}
