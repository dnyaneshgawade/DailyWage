using System;

namespace DailyWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Daily Wage!");
            EmpWage.Wage("facebook",12,10,50);
            EmpWage.Wage("google", 15, 15, 90);
            EmpWage.Wage("microsoft", 30, 20, 100);
        }
    }
}
