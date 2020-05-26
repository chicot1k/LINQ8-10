using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ9
{
    class Program
    {
      static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива A:\t");
            int elementcount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementcount];
            Console.Write("Введите элементы  массива:\t");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите количество элементов массива B:\t");
            int elementcount1 = int.Parse(Console.ReadLine());
            int[] myArray1 = new int[elementcount1];
            Console.Write("Введите элементы  массива:\t");
            for (int i = 0; i < myArray1.Length; i++)
            {
                myArray1[i] = int.Parse(Console.ReadLine());
            }
            var result = myArray.Select(s => new { f = s, ind = 0});
            var result1 = myArray1.Select(s => new { f1 = s, ind = 0 });
            var result3 = from item in result
                          join item2 in result1
                               on item.ind equals item2.ind
                          select (item.f + item2.f1);
            result = result.Distinct();
            result = result.OrderBy(s => s);
            Console.WriteLine("Отсортированная последовательность: ");
            foreach (var i in result3)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

        }
        
    }
}
