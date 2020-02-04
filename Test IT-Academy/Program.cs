using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_IT_Academy
{
    class Program
    {
        static void Main(string[] args)
        {

            // ввод размера массива
            Console.Write(" Введите размер массива: ");
            int size;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out size))
                {
                    if (size > 0)
                        break;
                }
                Console.Write("Ошибка введённого размера! Введите размер массива ещё раз: ");
            }
            int[] array = new int[size];

            // Заполнение массива
            int i = 0;
            Console.WriteLine("\n Заполните массив:");
            do
            {
                Console.Write("{0}-е число: ", i + 1);
                if (int.TryParse(Console.ReadLine(), out array[i]))
                {
                    i++;
                }
                else
                    Console.Write("Ошибка введённых данных! Введите ещё раз ");
            } while (i < array.Length);

            Console.WriteLine("Сформированный массив: " + string.Join(", ", array));

            // Ввод числа x
            int x;
            Console.Write("\n Введите число x: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out x))
                    break;
                else
                    Console.Write("Ошибка введённых данных! Введите число x ещё раз: ");
            }

            //Сортировка по возрастанию
            Array.Sort(array);
            Console.WriteLine("\n Отсортированный массив: " + string.Join(", ", array));

            //Результат вызова функции bsearch
            string result = bsearch(array, x);
            Console.WriteLine("\n Реультат \n" + result);
            Console.ReadLine();
        }
        public static string bsearch(int[] array, int x)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > x)
                {
                    return "Индекс №" + i.ToString();
                }
            }
            return "В данном массиве нет числа больше чем " + x;
        }
    }
}
