using System;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Welcome to Employee Wage Computation Program ==========\n");

            // UC1 – Check Employee Attendance
            Console.WriteLine("UC1 - Employee Attendance:");
            UC1_EmployeeAttendance attendance = new UC1_EmployeeAttendance();
            attendance.CheckAttendance();
            Console.WriteLine("--------------------------------------------------\n");

            // UC2 – Calculate Daily Employee Wage
            Console.WriteLine("UC2 - Daily Wage:");
            UC2_DailyWage dailyWage = new UC2_DailyWage();
            dailyWage.CalculateDailyWage();
            Console.WriteLine("--------------------------------------------------\n");

            // UC3 – Add Part-Time Employee & Wage
            Console.WriteLine("UC3 - Part Time Wage:");
            UC3_PartTimeWage partTime = new UC3_PartTimeWage();
            partTime.CalculatePartTimeWage();
            Console.WriteLine("--------------------------------------------------\n");

            // UC4 – Using Switch Case to Compute Wage
            Console.WriteLine("UC4 - Switch Case Wage:");
            UC4_SwitchCaseWage switchWage = new UC4_SwitchCaseWage();
            switchWage.CalculateWageUsingSwitch();
            Console.WriteLine("--------------------------------------------------\n");

            // UC5 – Calculate Wages for a Month
            Console.WriteLine("UC5 - Wages for a Month:");
            UC5_WagesForMonth wageMonth = new UC5_WagesForMonth();
            wageMonth.CalculateWagesForMonth();
            Console.WriteLine("--------------------------------------------------\n");

            // UC6 – Wages till a Condition is Reached
            Console.WriteLine("UC6 - Wages with Condition:");
            UC6_WagesWithCondition wageCondition = new UC6_WagesWithCondition();
            wageCondition.CalculateWageWithCondition();
            Console.WriteLine("--------------------------------------------------\n");

            // UC7 – Refactor Code using Class Method
            Console.WriteLine("UC7 - Class Method Refactor:");
            UC7_ClassMethodRefactor classRefactor = new UC7_ClassMethodRefactor();
            classRefactor.ComputeEmpWage();
            Console.WriteLine("--------------------------------------------------\n");

            // UC8 – Employee Wage for Multiple Companies
            Console.WriteLine("UC8 - Company Employee Wage:");
            UC8_CompanyEmployeeWage companyWage = new UC8_CompanyEmployeeWage();
            companyWage.ComputeEmpWage("TCS", 25, 20, 100);
            companyWage.ComputeEmpWage("Infosys", 30, 22, 120);
            Console.WriteLine("--------------------------------------------------\n");

            // UC9 – Save Total Wage for Each Company
            Console.WriteLine("UC9 - Save Total Wage:");
            UC9_SaveTotalWage totalWage = new UC9_SaveTotalWage("Wipro", 20, 20, 100);
            totalWage.ComputeEmpWage();
            Console.WriteLine(totalWage.ToString());
            Console.WriteLine("--------------------------------------------------\n");

            // UC10 – Compute Wages for Multiple Companies
            Console.WriteLine("UC10 - Multiple Company Wages:");
            UC10_MultipleCompany multipleCompany = new UC10_MultipleCompany();
            multipleCompany.AddCompany("Reliance", 25, 22, 120);
            multipleCompany.AddCompany("Accenture", 30, 25, 100);
            multipleCompany.ComputeWages();
            Console.WriteLine("--------------------------------------------------\n");

            // UC11 – Interface Implementation
            Console.WriteLine("UC11 - Interface Implementation:");
            IComputeEmpWage computeWageInterface;
            computeWageInterface = new UC12_SaveEachCompanyWage();
            computeWageInterface.AddCompany("Google", 35, 20, 100);
            computeWageInterface.ComputeWages();
            Console.WriteLine("--------------------------------------------------\n");

            // UC12 – Save Each Company’s Wage Separately
            Console.WriteLine("UC12 - Save Each Company Wage:");
            UC12_SaveEachCompanyWage saveEach = new UC12_SaveEachCompanyWage();
            saveEach.AddCompany("Microsoft", 40, 25, 120);
            saveEach.ComputeWages();
            Console.WriteLine($"Microsoft Total Wage: {saveEach.GetTotalWage("Microsoft")}");
            Console.WriteLine("--------------------------------------------------\n");

            // UC13 – Query by Company Name
            Console.WriteLine("UC13 - Query by Company Name:");
            UC13_QueryByCompany query = new UC13_QueryByCompany();
            query.AddCompanyWage("TCS", 20000);
            query.AddCompanyWage("Infosys", 18000);
            query.DisplayCompanyWage("TCS");
            query.DisplayCompanyWage("Google");
            Console.WriteLine("--------------------------------------------------\n");

            // UC14 – Final Wage Builder Using Interface
            Console.WriteLine("UC14 - Final Wage Builder:");
            UC14_FinalWageBuilder finalBuilder = new UC14_FinalWageBuilder();
            finalBuilder.AddCompany("Amazon", 50, 20, 100);
            finalBuilder.AddCompany("Netflix", 45, 22, 110);
            finalBuilder.ComputeWages();
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("\n✅ All Use Cases (UC1 - UC14) executed successfully!");
        }
    }
}
