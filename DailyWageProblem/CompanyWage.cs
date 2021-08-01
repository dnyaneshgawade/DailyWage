using System;
using System.Collections.Generic;
using System.Text;

namespace DailyWageProblem
{
    public class CompanyWage
    {
        public  String Company { get; set; }
        public int WagePerHr { get; set; }
        public int WorkingDays { get; set; }
        public int MaxHr { get; set; }
        public int Total_Wage = 0;
        
    }
}
