using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace поликлиника
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people;
            int timeOne = 10;
            int chas;
            int min;
            Console.Write(" Введите кол-во людей ");
            people = Convert.ToInt32(Console.ReadLine());
            chas = people * timeOne / 60;
            min = people * timeOne % 60;
            Console.WriteLine(" Время ожидания " + (chas) + " часов " + (min) + " минут ");
        }
    }
}
