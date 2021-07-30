using System;

namespace DailyWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Daily Wage!");
            EmpWageBuilder.Wage("facebook", 12, 10, 50);
            EmpWageBuilder.Wage("google", 15, 15, 90);
            EmpWageBuilder.Wage("microsoft", 30, 20, 110);
        }
    }
}
