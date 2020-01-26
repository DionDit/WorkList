using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> A = new List<double>();
            int l,n;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберете что хотите сделать\n1)Заполнить массив\n2)Вывести лист на экран\n3)Добавить новый элемент в лист\n4)Вывести на экран макс.элемент листа");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        WList.FillList(A);
                        break;
                    case 2:
                        WList.ShowList(A);
                        break;
                    case 3:
                        WList.AddNewItem(A);
                        break;
                    case 4:
                        WList.GetMax(A);
                        break;
                }
            }
        }
    }
}
