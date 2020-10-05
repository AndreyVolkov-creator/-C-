﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3Ex1
{
    class Complex
    {
        // Поля приватные.
        private double im;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double re;

        // Конструктор без параметров.
        public Complex()
        {
            im = 0;
            re = 0;
        }

        // Конструктор, в котором задаем поля.    
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public Complex(double _im, double re)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
        }
    public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        public Complex Compose(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = ((im * x2.im) - (re * x2.re));
            x3.re = ((im * x2.re) + (re * x2.im));
            return x3;
        }
        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }
        // Специальный метод, который возвращает строковое представление данных.
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.в) Добавить диалог с использованием switch демонстрирующий работу класса. Выполнил Волков Андрей\n");
            Console.WriteLine("Сложение = 1, Вычитыние = 2, Умножение = 3. Выберите операцию, которые хотите произвести");
            int count = Convert.ToInt32(Console.ReadLine());
            // Описали ссылку на объект.
            Complex complex1;
            // Создали объект и сохранили ссылку на него в complex1.
            complex1 = new Complex(1, 1);
            // Описали объект и создали его.
            Complex complex2 = new Complex(2, 2);
            Complex complex3 = new Complex(3, 3);
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            complex2.Im = 3;
            // Создали ссылку на объект.
            Complex result;
            // Так как в методе Plus создается новый объект,
            // в result сохраняем ссылку на вновь созданный объект.
            switch (count)
            {
                case 1:
                    result = complex1.Plus(complex2);
                    Console.WriteLine("Сложение");
                    Console.WriteLine(result.ToString());
                    break;
                case 2:
                    result = complex1.Minus(complex2);
                    Console.WriteLine("Вычитание");
                    Console.WriteLine(result.ToString());
                    break;
                case 3:
                    result = complex1.Compose(complex2);
                    Console.WriteLine("Умножение");
                    Console.WriteLine(result.ToString());
                    break;
                default:
                    Console.WriteLine("Вы не правильно выбрали операцию");
                    break;
            }
            
            Console.ReadKey();
        }
    }

}
