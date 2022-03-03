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

        private double miles;
        private double feet;
        private string number;

        /// <summary>
        /// This method will output a heading, ask dfor the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine("  " + miles + "miles is" + feet + "feet");
            Console.WriteLine();
        }

        private void CalculateFeet()
        {
            feet = miles * 5200; 
        }
        
        /// <summary>
         /// Output a message to the user to enter the miles
         /// and then read it in an a string and correct it tp a double 
         /// </summary>
        private void InputMiles()
        {
            Console.WriteLine();
            Console.WriteLine("  Please enter your distance as miles >  ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine();
            Console.WriteLine("         ===========================");
            Console.WriteLine("         App01:  Distance Converter     ");
            Console.WriteLine("               by Narinder Kaur         ");
            Console.WriteLine("         ===========================");
            Console.WriteLine();
        }
    }
}
