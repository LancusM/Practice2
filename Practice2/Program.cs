using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the month: ");
            int month = Convert.ToInt16(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("There are 31 days in this month.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("There are 30 days in this month.");
                    break;
                case 2:
                    Console.WriteLine("There are 28 days in this month.");
                    break;
            }
            Console.ReadLine();
            
            Console.WriteLine("Input your grade: ");
            int grade = Convert.ToInt16(Console.ReadLine());
            switch (grade/10)
            {
                case 9:
                case 10:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
            Console.ReadLine();
        }
    }
}
