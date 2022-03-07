using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Narinder Kaur version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
       
        public const string MILES = "Miles";
        public const string FEET = "Feet";
        public const string METRES = "Metres";
        

        private double fromDistance;
        private double toDistance;

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        /// <summary>
        /// This method will output a heading, ask for the 
        /// input for miles calculate and output the same
        /// distance in feet. 
        /// </summary>
        /// 
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            ConsoleHelper.OutputHeading("App01 Distance Converter", "Narinder Kaur");

            fromUnit = SelectUnit("Please select your from unit");
            toUnit = SelectUnit("Please select your to unit");

            Console.WriteLine($" \n You are converting from {fromUnit} to {toUnit} \n");

            fromDistance = ConsoleHelper.InputNumber("please enter the from distance in {feet} >");

            ConvertDistance();
            OutputDistance();

        }
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} = {toDistance} { toUnit}!");
        }

        private void ConvertDistance()
        {
            if (fromUnit == DistanceUnits.Miles &&
               toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Metres &&
                    toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance *METRES_IN_MILES;
            }
        }

        private DistanceUnits SelectUnit(string prompt)
        {
            string[] choices =
            {
                $"{DistanceUnits.Miles}",
                $"{DistanceUnits.Feet}",
                $"{DistanceUnits.Metres}",
            };
            Console.WriteLine($"\n{prompt}\n");
            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                return DistanceUnits.Miles;
            }
            else if (choice == 2)
            {
                return DistanceUnits.Feet;
            }
            else if (choice == 3)
            {
                return DistanceUnits.Metres;
            }
            else return DistanceUnits.NoUnit;
        }
        private double InputDistance(DistanceUnits unit)
        {
            Console.Write($"Please input the distance in {unit}>  ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
    }
  }
}


        