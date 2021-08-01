using System;
using System.Collections.Generic;

namespace DailyWageProblem
{
    class Program
    {
        public static List<CompanyWage> CompanyList = new List<CompanyWage>();
        static void Main(string[] args)
        {

            EmpWageBuilder emp = new EmpWageBuilder();
            Console.WriteLine("Wellcome to Daily Wage!");
            emp.AddEmp();
            emp.Wage();
        }
    }
}
