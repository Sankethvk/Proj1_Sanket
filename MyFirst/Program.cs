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
            Cube c = new Cube();
            Console.WriteLine("Area is = " + c.area());
            Console.WriteLine("Volume is = " + c.volume());
            circle circ = new circle();
            Console.WriteLine("Area of Circle is = " + circ.area());
            Console.WriteLine("Volume of Circle is = " + circ.volume());
            
            //Rectangle obj = new Rectangle(5, 10, "blue");
            //obj.displayArea();


            //string words = handson42.fiveletters();
            //Console.WriteLine(words);




            //int sum = handson4.Sumoflst();
            //Console.WriteLine(sum);










            //HANDSON1 objFile = new HANDSON1();
            //objFile.WriteFile();
            //Handson2 objFile2 = new Handson2();
            //objFile2.ReadFile();
            //handson31 obj31 = new handson31();
            //obj31.CreateFile();
            //handson32 obj32 = new handson32();
            //obj32.DeleteFile();
            //handson33 obj33 = new handson33();
            //obj33.question3();
            //handson34 obj34 = new handson34();
            //obj34.AddText();
            //handson35 obj35 = new handson35();
            //obj35.WriteRead();
            //obj35.Readonly();
            //handson36 obj36 = new handson36();
            //obj36.Specificline();
            //handson37 obj37 = new handson37();
            //obj37.CountLines() ;
            //obj37.CountLinesRead();
            //string value1 = objFile.WriteFile();
            //int value2 = objFile.ReadFile();
            //Console.WriteLine(value1);
            //Console.WriteLine(value2);
            //int value1, value2, value3, value4, value5;
            //Console.Write("enter value1 : ");
            //value1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter value2 : ");
            //value2 = Convert.ToInt32(Console.ReadLine());
            //value3 = value1 * value2;
            //value4 = value1 - value2;
            //value5 = value1 / value2;
            //Console.WriteLine("Multiplication Result : " + value3);
            //Console.WriteLine("Subtraction Result : " + value4);
            //Console.WriteLine("Division Result : " + value5);
            Console.Read();

        }
    }
}
