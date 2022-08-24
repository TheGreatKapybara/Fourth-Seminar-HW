using System;

namespace W_Fourth_seminar_HW
{
    class Program
    {

        static void WriteSelect(string[] namesArray)
        {
            for (int i = 0; i < namesArray.Length - 1; i++)
            {
                Console.WriteLine(i + 1 + " - " + namesArray[i]);
            }
            Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length - 1]);
        }
        static void Main(string[] args)
        {
            string[] Task = { "Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.",
        "Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.",
        "Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран." };
            WriteSelect(Task);
            System.Console.WriteLine();
            Console.WriteLine("Выберите задачу");
            int TaskIndex = Convert.ToInt32(Console.ReadLine());
            if (TaskIndex == 1)
            {
                System.Console.WriteLine("Введите число которое будем возводить");
                int number = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Введите его степень");
                int value = Convert.ToInt32(Console.ReadLine());
                int prod = number;
                for (int i = 1; i < value; i++)
                {
                    prod = prod * number;
                }
                System.Console.WriteLine($"Получается - {prod}");

            }
            if (TaskIndex == 2)
            {
                Console.WriteLine("Сведите число");
                int i = Convert.ToInt32(Console.ReadLine());
                int sum = 0;

                while (i > 0)
                {
                    int num = i % 10;
                    i = i / 10;
                    sum = sum + num;
                }
                Console.WriteLine("Сумма всех цифр в числе равна: " + sum);
            }
            if (TaskIndex == 3)
            {
                Console.WriteLine("Введите число N");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = new Random().Next(1, 10);
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }


        }
    }
}
