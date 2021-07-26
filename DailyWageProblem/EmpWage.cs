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
        public const int PART_TIME_HR = 4;
        public const int FULL_TIME_HR = 8;
        int fPayment;
        int hPayment;

        public void Wage()
        {
            for (int i = 1; i <= WORKING_DAYS; i++)
            {
                int working_day = i;
                fPayment = WAGE_PER_HR * FULL_TIME_HR * working_day;
                Console.WriteLine("full time Payment of day" + i + " is:" + fPayment);
                hPayment = WAGE_PER_HR * PART_TIME_HR * working_day;
                Console.WriteLine("part time Payment of day" + i + " is:" + hPayment);
            }
        }
    }
}
