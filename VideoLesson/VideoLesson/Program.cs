using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student._age = 5;

            Calculate(student);

            Console.WriteLine(student._age);

            Console.ReadLine();
        }

        static void Calculate(Student student)
        {
            student._age += 1;
        }
    }
}
