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
            int l;
            Console.WriteLine("Введите длину массива");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < l; i++)
            {

                A.Add(Convert.ToDouble(Console.ReadLine()));
            }

        }
    }
}
