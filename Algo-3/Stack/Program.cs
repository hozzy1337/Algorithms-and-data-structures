﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int a = 0;
            int b = 0;
            Console.WriteLine("Стек \n" +
                              "1. Добавление елемента в стек \n" +
                              "2. Вывод на экран \n" +
                              "3. Удалить первый в стеке елемент \n" +
                              "4. Удаление списка \n" +
                              "Другая клавиша - выход");
            while (true)
            {
                a = Int32.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("Введите значение");
                    b = Int32.Parse(Console.ReadLine());
                    numbers.Push(b);
                    Console.WriteLine("Действие выполнено, выберите следующее");
                }


                else if (a == 2)
                {
                    Console.WriteLine("Список");
                    foreach (int i in numbers)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("\nДействие выполнено, выберите следующее");
                }
                else if (a == 3)
                {
                    numbers.Pop();
                    Console.WriteLine("Елемент успешно удален, выберите следующее действие");
                }
                else if (a == 4)
                {
                    numbers.Clear();
                    Console.WriteLine("Список уничтожен(очищен)");
                }
                else break;
            }

        }
    }
}
