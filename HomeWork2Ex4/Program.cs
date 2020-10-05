using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками. Выполнил Волков Андрей\n");
            string truelog = "root";
            string truepass = "GeekBrains";
            int count = 0;
            int maxcount = 3;
            do
                {
                    Console.WriteLine("Введите свой логин:");
                    string userlog = Console.ReadLine();
                    Console.WriteLine("Введите свой пароль:");
                    string userpass = Console.ReadLine();
                if (maxcount > count)
                {
                    if (userlog == truelog && userpass == truepass) { Console.WriteLine("Добро пожаловать"); break; }
                    else
                    {
                        maxcount--;
                        Console.WriteLine($"Вы ошиблись, попробуйте еще раз. Осталось {maxcount} попыток");
                    }
                }
            } while(maxcount > count) ;
            Console.WriteLine("Попробуйте ввести данные чуть позже");
            Console.ReadKey();
        }
    }
}
