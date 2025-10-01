using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroupExWk4
{

    internal class Person
    {


        public double UserWeightInputed;
        public double UserHeightInputed;
        public double HeightNumber;
        public double SquaredMeterNumber;
        public double DivisionOfHeightAndWeight;
        public double KgConversion;
        public double ImperialConversionWeight;
        public double InchesConversionToMeters;
        public double SquaredInchesNumber;
        public double BMIMetric;
        public double BMIImperial;


        public void PersonInformation()
        {

           
            Console.Write("What is your weight? ");
            UserWeightInputed  = Convert.ToDouble(Console.ReadLine());

            //Metric Conversion to KG
            KgConversion = UserWeightInputed * 0.45359237;
            Console.WriteLine("");




            ///////////////////////////////////////////////////////////////////////////


            Console.Write("Enter your height in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your remaining height in inches: ");
            double inches = Convert.ToDouble(Console.ReadLine());

            //Converting inches to Meters
            InchesConversionToMeters = UserHeightInputed * 0.0254;

            Console.WriteLine("This is inches to meters: " + InchesConversionToMeters);


            //Squaring regular inches.
            SquaredInchesNumber = Math.Pow(UserHeightInputed, 2);




            //FINAL CALULATIONS

            //Metric 
            BMIMetric = KgConversion / (Math.Pow(InchesConversionToMeters, 2));


            //Imperial
            BMIImperial = (UserWeightInputed * 703) / (Math.Pow(UserHeightInputed, 2));

            

        }



    }
    internal class BMIOutPut
    {

        public void  BMIDisplayerMetric(double BMIMetric)
        {
            if (BMIMetric < 18.5)
                Console.WriteLine("Under Weight");
            else if (BMIMetric >= 18.5 && BMIMetric <= 24.9)
                Console.WriteLine("Normal");
            else if (BMIMetric >= 25 && BMIMetric <= 29.9)
                Console.WriteLine("OverWeight");
            else
                Console.WriteLine("Obese");

            Console.WriteLine($"Your BMI Metric:   {BMIMetric}");

            
        }

        public void BMIDisplayerImperial(double BMIImperial)
        {
            if (BMIImperial < 18.5)
                Console.WriteLine("Under Weight");
            else if (BMIImperial >= 18.5 && BMIImperial <= 24.9)
                Console.WriteLine("Normal");
            else if (BMIImperial >= 25 && BMIImperial <= 29.9)
                Console.WriteLine("OverWeight");
            else
                Console.WriteLine("Obese");

            Console.WriteLine($"Your BMIImperial:   {BMIImperial}");

        }





        static void Main(string[] args)
        {
            // Create Person object and collect input
            Person p = new Person();
            p.PersonInformation(); // calculates BMIMetric and BMIImperial

            // Create BMICalculator object
            BMIOutPut b = new BMIOutPut();

            // Display BMI categories
            b.BMIDisplayerMetric(p.BMIMetric);
            b.BMIDisplayerImperial(p.BMIImperial);
        }


    }

}
    


