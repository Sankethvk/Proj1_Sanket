using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1; int value2; int value3;
            Console.Write("enter value1 : ");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value2 : ");
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = value1 * value2;
            Console.WriteLine("Result : " + value3);
            Console.Read();

        }
    }
}
