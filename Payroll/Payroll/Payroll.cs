/* Programmer: Moses Byanyuma
   Date: 11/24/2016
 * Application: Payroll program that calculates an employee's earnings
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
   public class Payroll
    {
        static void Main(string[] args)
        {
            string name, SSN;
            double hourlyPayRate = 0, hoursWorked = 0, grossPay = 0;
            double federalWithholding, stateWitholding, netPay;

            Console.Write("Enter your name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Social security number: ");
            SSN = Convert.ToString(Console.ReadLine());
            Console.Write("Hourly pay rate: ");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());

            grossPay = hourlyPayRate * hoursWorked;
            federalWithholding = grossPay * 0.15;
            stateWitholding = grossPay * 0.05;
            netPay = grossPay - (federalWithholding + stateWitholding);


            Console.WriteLine("Payroll summary for {0}", name);
            Console.WriteLine("SSN: {0}", SSN);
            Console.WriteLine("You worked for {0} hours at {1:C} per hour", hoursWorked, hourlyPayRate.ToString("C2"));

            Console.WriteLine("\nGross pay: {0}", grossPay.ToString("C"));
            Console.WriteLine("Federal withholding: {0}", federalWithholding.ToString("C"));
            Console.WriteLine("State witholding: {0}", stateWitholding.ToString("C"));
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n Net pay: {0}", netPay.ToString("C"));

            Console.WriteLine("Press any key to exit application");
            Console.ReadKey();


            
        }
    }
}
