using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;

            Console.Write("Enter your marks: ");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks <= 100 && marks >= 90)
            {
                Console.WriteLine("Your Grade Is A*");
            }
            else if (marks <= 89 && marks >= 80)
            {
                Console.WriteLine("Your Grade Is A");
            }
            else if (marks <= 79 && marks >= 70)
            {
                Console.WriteLine("Your Grade Is B");
            }
            else if (marks <= 69 && marks >= 60)
            {
                Console.WriteLine("Your Grade Is C");
            }
            else if (marks <= 59 && marks >= 50)
            {
                Console.WriteLine("Your Grade Is D");
            }
            else if (marks <= 49 && marks >= 40)
            {
                Console.WriteLine("Your Grade Is E");
            }
            else if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invaid Marks");
            }
            else
            {
                Console.WriteLine("Your Grade Is F");
            }

            Console.ReadKey();
        }
    }
}
