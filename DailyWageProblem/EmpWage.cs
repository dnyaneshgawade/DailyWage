using System;
using System.Collections.Generic;
using System.Text;

namespace DailyWageProblem
{
    public class EmpWage
    {
        public void Wage()
        {
            Random ran = new Random();
            int attend = ran.Next(0, 2);
            if (attend == 0)
                Console.WriteLine("Employee is Present");

        }
    }
}
