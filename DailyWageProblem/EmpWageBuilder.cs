using System;
using System.Collections.Generic;
using System.Text;

namespace DailyWageProblem
{
    public class EmpWageBuilder:IEmpWageBuilder
    {
        const int IS_FULL_TIME = 0;
        const int IS_PART_TIME = 1;
        public static int payment = 0;
        public static int workHr;
        public static int totalDays=0;
        public static int totalHrs=0;
        public static int number;
        public static List<CompanyWage> CompanyList = new List<CompanyWage>();

        public void AddEmp()
        {
            CompanyWage companyWage = new CompanyWage();
            Console.WriteLine("\nenter how many company do you want to add");
            number = Convert.ToInt16(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter the name of Company");
                companyWage.Company = Console.ReadLine();
                Console.WriteLine("Enter the Wage per hour");
                companyWage.WagePerHr = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter total working days");
                companyWage.WorkingDays = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the maximum working hours ");
                companyWage.MaxHr = Convert.ToInt16(Console.ReadLine());
                CompanyList.Add(companyWage);
            }
            
        }

        public void Wage()
        {
            foreach(var data in CompanyList)
            {
                while (totalDays <= data.WorkingDays && totalHrs <= data.MaxHr)
                {
                    Random random = new Random();
                    int num = random.Next(0, 3);
                    switch (num)
                    {
                        case IS_FULL_TIME:
                            workHr = 8;
                            break;
                        case IS_PART_TIME:
                            workHr = 4;
                            break;
                        default:
                            break;
                    }
                    totalDays++;
                    totalHrs += workHr;
                }
                data.Total_Wage = data.WagePerHr * totalHrs;
                Display(data);
            }
        }
        public void Display(CompanyWage com)
        {
            
            Console.WriteLine("Total Employee Wage for company: "+com.Company +" : " +com.Total_Wage);
        }

    }
}
