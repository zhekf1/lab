/*Оголосити тип делегату, що посилається на метод.Вимоги до сигнатури методу наступні:
 метод отримує вхідним параметром змінну типу double;
 метод повертає значення типу double, яке є результатом обчислення згідно з умовою задачі.
Реалізувати виклик трьох методів з допомогою одного делегату, які отримують радіус кола R в якості
вхідного параметру і обчислюють:
довжину кола за формулою D = 2πR;
 площу круга за формулою S = πR2;
 об‘єм кулі. Формула V = 4 / 3πR3.
Методи повинні бути представлені в окремому класі як нестатичні.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Program
    {
        private delegate double CalculateDeligat(double r);
        private static Calculator calculator = new Calculator();
        static void Main(string[] args)
        {
            double r = 0.0;
            Console.WriteLine("Введи необходимый радиус:");
            while (!Double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                Console.WriteLine("Произошла ошибка\nВведи необходимый радиус:");

            }
            CalculateDeligat calculateDeligat = calculator.CalculateLength;
            Console.WriteLine($"Длинна круга с R = {r} = {calculateDeligat(r)}");

                calculateDeligat = calculator.CalculateSquare;
            Console.WriteLine($"Площадь круга с R = {r} = {calculateDeligat(r)}");

            calculateDeligat = calculator.CalculateVolume;
            Console.WriteLine($"Объем сфери с R = {r} = {calculateDeligat(r)}");
            Console.ReadKey();
        }
    }
}
