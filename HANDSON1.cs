using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirst
{
    class HANDSON1
    {
        public string WriteFile()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\COURSE.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter objWrite = new StreamWriter(fs);
            objWrite.WriteLine("Course Details");
            objWrite.WriteLine("**************");
            Console.WriteLine("enter number of courses");
            int num = Convert.ToInt32(Console.ReadLine());
            objWrite.WriteLine("Number of Courses : " + num);
            for (int i = 0; i < num; i++)
            {
                Console.Write("regno : ");
                int reg = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter course : ");
                string course = Console.ReadLine();
                Console.Write("enter course title : ");
                string course_title = Console.ReadLine();
                

                //Console.WriteLine("Number of courses : " + num);
                Console.WriteLine("RegNo : " + reg);
                Console.WriteLine("Course : " + course);
                Console.WriteLine("Course Title : " + course_title);
                //objWrite.WriteLine("Number of courses : " + num);
                objWrite.WriteLine("RegNo : " + reg);
                objWrite.WriteLine("Course : " + course);
                objWrite.WriteLine("Course Title : " + course_title);

            }
            

            objWrite.Close();
            fs.Close();



            return "file created";
        }
        
    }
}
