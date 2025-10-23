using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePay
{
    internal class Employee
    {
        //constant 
        const double TotalRevenueForEmployee = 0.07;
        const double FederalTaxRate = 0.18;
        const double RetirementContribution = 0.10;
        const double SocialSecurity = 0.06;

        //fields
        public double FederalTaxAmount;
        public double TakeHome;
        public double RetirementAmount;
        public double Commission;
        public double SocialSecurityAmount;

        //Setters & Getters
        public string Name { get; set; }
        public double SalesAmount { get; set; }
        
        //constructors
        public Employee() 
        { 
         // empty to generate object
        }
        //to build object
        public Employee(string Name, double SalesAmount) 
        {
            this.Name = Name;
            this.SalesAmount = SalesAmount;
        }


        //Method to calculate fed tax
        public double GetTaxAmount() 
        {
            FederalTaxAmount = Commission * FederalTaxRate;
                return FederalTaxAmount;
        }
        //Method to calculate SS amount
        public double SocialSecurityWithheld()
        {
            SocialSecurityAmount = Commission * SocialSecurity;
            return SocialSecurityAmount;
        }
        //Method to get retirment information
        public double AdditionalDeductions()
        {
            RetirementAmount = Commission * RetirementContribution;
            return RetirementAmount;
        }
        
       //method to calculate commision amount
        public double CommisionsIncome()
        {
            Commission = SalesAmount * TotalRevenueForEmployee;
            return Commission;
        }
        //Method to get the take home after everything has been deducted. 
        public double RevenueTotal()
        {
            TakeHome = Commission - (FederalTaxAmount + SocialSecurityAmount + RetirementAmount);// Adds the deductions togethe then commisions subtracts from the ammount. 
            return TakeHome;
        }


    }
}
