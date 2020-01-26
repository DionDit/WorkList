using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkList
{
    class WList
    {
        static void Error(string Text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Text}");
            Console.ResetColor();
        }
        public static void FillList(List<double> List)
        {
            Console.Clear();
            Console.WriteLine("Введите длину массива");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < l; i++)
            {

                List.Add(Convert.ToDouble(Console.ReadLine()));
            }
            Console.ReadKey();
        }
        public static void ShowList(List<double> List)
        {
            Console.Clear();
            if (List.Count != 0)
            {
                for(int i = 0; i < List.Count; i++)
                {
                Console.WriteLine($"{i} элемент листа = {List[i]}");
                }
            }
            else
            {
                Error("Вы еще не заполнили массив");
            }
            Console.ReadKey();
        }
        public static void AddNewItem(List<double> List)
        {
            Console.Clear();
            int l;
            Console.WriteLine("Сколько элементов хотите добавить?");
            l = Convert.ToInt32(Console.ReadLine());
            if(l > 0)
            {
                for(int i = 0; i < l; i++)
                {
                    List.Add(Convert.ToDouble(Console.ReadLine()));
                }
            }
            else
            {
                Error("Вы ввели не верное кол-во элеметов");
            }
            Console.ReadKey();
        }
        public static void GetMax(List<double> List)
        {
            if(List.Count != 0)
            {
                Console.Clear();
                Console.WriteLine($"Макс.элемент листа = {List.Max()}");
            }
            else
            {
                Error("Вы еще не заполнили массив");
            }
            Console.ReadKey();
        }
    }
}
