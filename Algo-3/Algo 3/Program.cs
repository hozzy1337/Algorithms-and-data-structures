using System;
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
            LinkedList<int> numbers = new LinkedList<int>();
            int a = 0;
            int b = 0;
            Console.WriteLine("Двухсвяхный список \n" +
                              "1.Добавление елемента в начало \n" +
                              "2. Добавление елемента в конец \n" +
                              "3. Вывод на экран \n" +
                              "4. Удаление елемента \n" +
                              "5. Удаление списка \n" +
                              "Другая клавиша - выход");
            while (true)
            {
                a = Int32.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("Введите значение");
                    b = Int32.Parse(Console.ReadLine());
                    numbers.AddFirst(b);
                    Console.WriteLine("Действие выполнено, выберите следующее");
                }

                else if (a == 2)
                {
                    Console.WriteLine("Введите значение");
                    b = Int32.Parse(Console.ReadLine());
                    numbers.AddLast(b);
                    Console.WriteLine("Действие выполнено, выберите следующее");
                }
                else if (a == 3)
                {
                    Console.WriteLine("Список");
                    foreach (int i in numbers)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("\nДействие выполнено, выберите следующее");
                }
                else if (a == 4)
                {
                    numbers.RemoveLast();
                    Console.WriteLine("Последний узел успешно удален, выберите следующее действие");
                }
                else if (a == 5)
                {
                    numbers.Clear();
                    Console.WriteLine("Список уничтожен(очищен)");
                }
                else break;
            }

        }
    }
}
