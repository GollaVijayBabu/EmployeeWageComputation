using System;

namespace EmployeeWageComputation
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation \n");

            Console.WriteLine("Please select the following options \n");
            Console.WriteLine(" 1.UC_1 \n 2.UC_2 \n 3.UC_3 \n 4.UC_4 \n 5.UC_5 \n " +
                "6.UC_6 \n 7.UC_7 \n 8.UC_8 \n 9.UC_9 \n 10.UC_10 \n 11.UC_11 \n ");
            Console.WriteLine(" To Execute User Case 12 to 14 Please Select UC_11 Option");

            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    UC_1 uc1 = new UC_1();
                    uc1.Attendance();
                    break;

                case 2:
                    UC_2 uc2 = new UC_2();
                    uc2.DailyWage();
                    break;

                case 3:
                    UC_3 uc3 = new UC_3();
                    uc3.PartTime();
                    break;
                case 4:
                    UC_4 uc4 = new UC_4();
                    uc4.Case();
                    break;

                case 5:
                    UC_5 uc5 = new UC_5();
                    uc5.MonthlyWage();
                    break;

                case 6:
                    UC_6 uc6 = new UC_6();
                    uc6.Condition();
                    break;

                case 7:
                    UC_7 uc7 = new UC_7();
                    uc7.ComputeEmpWage();
                    break;

                case 8:
                    UC_8 company = new UC_8();
                    company.ComputeEmpWage("Dmart", 20, 20, 100);
                    company.ComputeEmpWage("Reliance", 15, 25, 150);
                    break;

                case 9:
                    EmpWageBuilderUC_9 dmart = new EmpWageBuilderUC_9("Dmart", 20, 20, 100);
                    EmpWageBuilderUC_9 reliance = new EmpWageBuilderUC_9("Reliance", 15, 25, 150);
                    dmart.ComputeEmpWage();
                    Console.WriteLine(dmart.toString());
                    reliance.ComputeEmpWage();
                    Console.WriteLine(reliance.toString());
                    break;

                case 10:
                    EmpWageBuilderArrayUC_10 companylist = new EmpWageBuilderArrayUC_10();
                    companylist.addCompany("Dmart", 20, 20, 100);
                    companylist.addCompany("Reliance", 15, 25, 150);
                    companylist.ComputeEmpWage();
                    break;

                case 11:
                    EmpWageBuilderArrayUC_10 companyDetails = new EmpWageBuilderArrayUC_10();
                    companyDetails.addCompany("Dmart", 20, 20, 100);
                    companyDetails.addCompany("Reliance", 15, 25, 150);
                    companyDetails.ComputeEmpWage();
                    Console.WriteLine("Total Wage for Dmart company :" + companyDetails.GetTotlaWage("Dmart"));
                    Console.WriteLine("Total Wage for Reliance company :" + companyDetails.GetTotlaWage("Reliance"));
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
