using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ10
{
    class Program
    {
        public class client : IComparable<client>
        {
            public int code, year, month, hours;
            public client(int c, int y, int m, int h)
            {
                this.code = c;
                this.month = m;
                this.year = y;
                this.hours = h;
            }
            public int CompareTo(client another)
            {
                return this.hours.CompareTo(another.hours);
            }
        }
        static void Main(string[] args)
        {
            int n, d, y, m, h;
            var current = new List<client>();
            Console.WriteLine("Введите количество клиентов");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Список клиентов(код, год, месяц, часы)");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Клиент " + (i + 1));
                d = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                m = Convert.ToInt32(Console.ReadLine());
                h = Convert.ToInt32(Console.ReadLine());
                current.Add(new client(d, y, m, h));
            }
            current.Reverse();
            var another = current;
            client min = another.Min();
            Console.Write("Минимальная продолжительность занятий в часах: " + min.hours + " год: " + min.year + " месяц: " + min.month);
            Console.ReadKey();

        }
    }
}

