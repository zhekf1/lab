/*Написати статичний метод ChangeMatrix, що виконує вказані дії над елементами матриці дійсних чисел
(матрицю заповнити рандомно або з файла!! в Main()).
Формальні параметри : матриця дійсних чисел, задана дія – об'єкт Action/Func.
Використовуючи написаний метод:
 вивести матрицю на екран;
 вивести на екран позитивні(>=0) елементи матриці;
 збільшити в три рази всі позитивні елементи матриці.
Після виклику останньої дії – вивести змінену матрицю на екран.*/


using System;


namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Введи размер массива:");
            while (!Int32.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("Произошла ошибка\nВведи размер массива:");
            }
            int[,] matr = GenerateMatrix(n);
            ChangeMatrix(matr, "Вывод матрици на экран", (Action<int>)Show);
            ChangeMatrix(matr, "Вывод положительних элементов матрици на экран", (Action<int>)ShowPos);
            ChangeMatrix(matr, "Умножение положительних элементов на 3", Mult3Pos);
            ChangeMatrix(matr, "Вывод матрици на экран", (Action<int>)Show);
            Console.ReadKey();
        }
        static int[,] GenerateMatrix(int n)
        {
            int[,] matr = new int[n, n];
            Random random = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matr[i, j] = random.Next(-20, 20);
                }
            }
            return matr;
        }

        static void ChangeMatrix (int[,] arr,String name, Action<int> act)
        {
            Console.WriteLine(name);
            for(int i = 0; i < Math.Sqrt(arr.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(arr.Length); j++)
                {
                    act(arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void ChangeMatrix(int[,] arr, String name, Func<int, int> act)
        {
            Console.WriteLine(name);
            for (int i = 0; i < Math.Sqrt(arr.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(arr.Length); j++)
                {
                    arr[i, j] = act(arr[i, j]);
                }
            }
        }

        static void Show(int n)
        {
            Console.Write($"{n} ");
        }

        static void ShowPos(int n)
        {
            if(n >= 0)
                Console.Write($"{n} ");
            else
                Console.Write("_ ");
        }
        static int Mult3Pos(int n)
        {
            if (n >= 0)
                return n * 3;
            else
                return n;
        }
    }
}
