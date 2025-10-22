/* 
 * Programmer: Stephanie Salzburg, Jonquil Terry, David Segura Aba, Nathan Wenson, Cameron Rickel
 * Date: 10/16/25
 * Purpose: This program is a motorway class that is used as documentation for highway roads. It allows you to provide details to make the travel much easier. 
 * Assignment: Chapter 4 - Programming Exercise 3
 */


namespace GroupExChapter4Ex7Wk7
{
    internal class ParkInformation
    {
        //Getter & Setters
        public string ParkName { get; set; }
        public string LocationType { get; set; }
        public double FacilityFee { get; set; }
        public  int NumEmployees { get; set; }
        public int NumVisitors12 { get; set; }
        public double AnnualBudget { get; set; }

        //Fields
        public string facilities;
        public double resultOfAnnualAndVisit;
        public  double resultOfFee;


        //Constructor 
        public ParkInformation() { 
        //Empty constructor to create the object 
        }

        //Construstors with parameters to hold the information to build the object with information.
        public ParkInformation  ( string ParkName, string LocationType, double FacilityFee, int NumEmployees, int NumVisitors12, double AnnualBudget )
        {
            this.ParkName = ParkName;
            this.LocationType = LocationType;
            this.FacilityFee = FacilityFee;
            this.NumEmployees = NumEmployees;
            this.NumVisitors12 = NumVisitors12;
            this.AnnualBudget = AnnualBudget;

        }


        //String of facilities available at the location
        public string FacilitiesAvailable()
        {

            facilities = "Facilities:" + " Walking trails, Jogging trails, Biking trails \n Food Court, Vending Machines";
            return facilities;
        }
         //Method that calculates the cost per visitor
         public double CostPerVisitor()
        {
            resultOfAnnualAndVisit = AnnualBudget / NumVisitors12;
            return resultOfAnnualAndVisit;

        }
        //Calculates the money earned from feees
        public double MoneyFromFee()
        {
            resultOfFee = FacilityFee * NumVisitors12;
            return resultOfFee;
        }


        //Method to string turns all the information input into a string.
        public override string ToString()
        {
            CostPerVisitor(); 
            MoneyFromFee();    

            return $"Park Name: {ParkName},\nLocation: {LocationType},\nFacilities: {facilities},\nNumber of Employees: {NumEmployees},\nNumber of Visitors: {NumVisitors12},\nAnnual Budget: {AnnualBudget},\nMoney from Fees: {resultOfFee},\nCost per Visitor: {resultOfAnnualAndVisit}";
        }





    }
}
