using System;

class GranolaBarSales
{
    // Constants
    const int BarsPerCase = 12;
    const double CaseCost = 5.00;
    const double StudentGovRate = 0.10;

    // Fields
    private int casesSold;
    private double salePricePerBar;
    private double grossRevenue;
    private double totalCost;
    private double netEarnings;
    private double studentGovContribution;
    private double clubProceeds;

    // Method to display instructions
    public void DisplayInstructions()
    {
        Console.WriteLine("Welcome to the Granola Bar Sales Proceeds Calculator!");
        Console.WriteLine("This application helps the computer club determine how much money they will earn from granola bar sales.");
        Console.WriteLine("You will enter the number of cases sold and the sale price per bar.\n");
    }

    // Method to get user input
    public void GetSalesData()
    {
        Console.Write("Enter the number of cases sold: ");
        casesSold = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the sale price per bar: $");
        salePricePerBar = Convert.ToDouble(Console.ReadLine());
    }

    // Method to perform calculations
    public void CalculateProceeds()
    {
        int totalBars = casesSold * BarsPerCase;
        grossRevenue = totalBars * salePricePerBar;
        totalCost = casesSold * CaseCost;
        netEarnings = grossRevenue - totalCost;
        studentGovContribution = netEarnings * StudentGovRate;
        clubProceeds = netEarnings - studentGovContribution;
    }

    // Method to display results
    public void DisplayResults()
    {
        Console.WriteLine("\n--- Sales Summary ---");
        Console.WriteLine($"Cases Sold: {casesSold}");
        Console.WriteLine($"Sale Price per Bar: ${salePricePerBar:N2}");
        Console.WriteLine($"Total Bars Sold: {casesSold * BarsPerCase}");
        Console.WriteLine($"Gross Revenue: ${grossRevenue:N2}");
        Console.WriteLine($"Total Cost of Cases: ${totalCost:N2}");
        Console.WriteLine($"Net Earnings: ${netEarnings:N2}");
        Console.WriteLine($"Student Government Contribution (10%): ${studentGovContribution:N2}");
        Console.WriteLine($"Club Proceeds: ${clubProceeds:N2}");
    }

    // Main method
    static void Main()
    {
        GranolaBarSales sales = new GranolaBarSales();
        sales.DisplayInstructions();
        sales.GetSalesData();
        sales.CalculateProceeds();
        sales.DisplayResults();
    }
}
