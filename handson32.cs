using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirst
{
    class handson32
    {
        public string DeleteFile()
        {
            string file = @"C:\Training\EuroTraining\Files\mytest.txt";
            if (File.Exists(file))
               {
                File.Delete(file);
                Console.WriteLine("the file deleted successfully");
            }
            else
            {
                Console.WriteLine(" File does not exist");
                Console.ReadKey();
            }
            return " ";
            

        }
    }
}
