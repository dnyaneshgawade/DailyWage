using System;

namespace DailyWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Daily Wage!");
            EmpWage emp = new EmpWage();
            emp.Wage();
        }
    }
}
