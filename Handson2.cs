using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirst
{
    class Handson2
    {
        public string ReadFile()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\handson2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Source   Destination   Date           Call");
            string line = sr.ReadLine();
            while(sr.Peek()>0)
            {
                for(int i = 0;i<4;i++)
                {
                    if(line.Contains(":"))
                    {
                        string[] list = line.Split(':');
                        Console.Write(list[1] + "   ");
                        line = sr.ReadLine();
                        

                    }
                    else
                    {
                        line = sr.ReadLine();
                        break;
                    }
                }
                Console.WriteLine();
            }
            fs.Close();
            sr.Close();

            return " ";
        }
    }
    
}
