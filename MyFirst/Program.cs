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
            int value1,value2,value3,value4,value5;
            Console.Write("enter value1 : ");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value2 : ");
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = value1 * value2;
            value4 = value1 - value2;
            value5 = value1 / value2;
            Console.WriteLine("Multiplication Result : " + value3);
            Console.WriteLine("Subtraction Result : " + value4);
            Console.WriteLine("Division Result : " + value5);
            Console.Read();

        }
    }
}
