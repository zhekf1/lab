/*Оголосіть два делегати: UseOperation, GetGreeting.
Перший делегат посилається на функцію, яка в якості параметрів приймає два значення типу int і повертає
деяке ціле число.
Другий делегат посилається на метод без параметрів, який нічого не повертає.
 Створіть методи без параметрів GoodMorning, GoodDay, GoodEvening і GoodNight, при виклику яких
виводиться текст «Доброго ранку!», «Добрий день!», «Добрий вечір!» і «Доброї ночі!». Якщо відомо, що
властивість DateTime.Now.Hour повертає кількість годин поточного часу, то напишіть програму, в якій, за
допомогою делегата GetGreeting, запускається один з написаних вами методів, в залежності від поточного
значення часу.
 Створіть методи для обчислення суми, різниці, добутку, частки двох цілих чисел.
Використовуючи делегат UseOperation для виклику описаних в попередньому пункті методів, напишіть
програму, яка запитує у користувача два цілих числа і операцію, яку необхідно провести.Виводить відповідний
результат.
Звіт повинен містити приклади та завдання. Для захисту лабораторної роботи потрібно продемонструвати
робочу програму та відповісти на запитання викладача.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class Program
    {
        private delegate double UseOperation(double a, double b);
        static void Main(string[] args)
        {
            GreetingAction.SayGreetings();

            Dictionary<String, UseOperation> op = new Dictionary<String, UseOperation>();
            op["+"] = (a, b) => a + b;
            op["-"] = (a, b) => a - b;     
            op["*"] = (a, b) => a * b;
            op["/"] = (a, b) => a / b;
            double x = EnterData("Введи первое число для расчета:"), y = EnterData("Введи второе число для расчета:");          
            Console.WriteLine("Введи необходимую операцию(+, -, *, /)");
            String selectedOper = String.Empty;
            while (!op.Keys.Contains(selectedOper = Console.ReadLine()))
            {
                Console.WriteLine("Произошла ошибка, повторите попытку");
            }
            Console.WriteLine($"Результат = {op[selectedOper](x,y)}");
            Console.ReadKey();
        }

        private static double EnterData(String textToPrint)
        {
            double res;
            Console.WriteLine(textToPrint);
            while (!Double.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Произошла ошибка\n" + res);
            }
            return res;
        }
    }
}
