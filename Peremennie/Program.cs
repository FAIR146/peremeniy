using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peremennie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа, чтобы узнать их частное");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double div = (double)number1 / number2;

            Console.WriteLine("Сумма введенных чисел равна: " + div);

            Console.ReadKey();
        }
    }
}
