using System;
using System.Collections.Generic;
using System.Text;

namespace DailyWageProblem
{
    public class EmpWage
    {
        const int WAGE_PER_HR = 20;
        const int IS_FULL_TIME = 0;
        const int IS_PART_TIME = 1;
        const int WORKING_DAYS = 20;
        int payment = 0;
        int workHr;

        public void Wage()
        {
            Random random = new Random();
            int num = random.Next(0, 3);
            switch (num)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("daily wage of fulltime employee");
                    workHr = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("daily wage of parttime employee");
                    workHr = 4;
                    break;
                default:
                    Console.WriteLine("employee is absent");
                    break;
            }
            payment = WAGE_PER_HR * workHr * WORKING_DAYS;
            Console.WriteLine("Payment is:" + payment);
        }
    }
}
