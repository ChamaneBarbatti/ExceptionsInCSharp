using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
       
        
        static double Divide(double x, double y)
        {
           if (y == 0.0)
            {
                throw new ArgumentOutOfRangeException("y", "You cannot divide by zero!");
            }
            else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("filename" , "Student did not submit any work!");
            }
            else
            {
                if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
                {
                    return 1;
                }
                else
                {
                    return 0;

                }

            }
        }
        

        static void Main(string[] args)
        {
            double a = 9.9;
            double b = 0.0;

            try
            {
                Divide(a, b);
            }
               catch (ArgumentOutOfRangeException e)
            
            {
                Console.WriteLine(e.Message);
            }
         

            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine(student.Key);
                    CheckFileExtension(student.Value);
                }
                catch(ArgumentNullException n)
                {
                    Console.WriteLine(n.Message);
                }
            }
        }
    }
}