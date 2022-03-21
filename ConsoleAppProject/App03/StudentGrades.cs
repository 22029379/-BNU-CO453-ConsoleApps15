using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03

{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    ///  This Project has been modified by:
    /// Narinder kaur 01/02/2022
    /// </summary>
    public class StudentGrades
    {
        public const int MINIMUM_MARK = 0;
        public const int MAXIMUM_MARK = 100;
        public const int PERCENTAGE = 100;

        public const int LowestGradeF = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int HighestGradeA = 70;
        public const int HighestMark = 100;

        //student names
        public string[] Students { get; set; }

        //student marks
        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        public int Total { get; set; }

        public Grades Grades
        {
            get => default;
            set
            {
            }
        }



        /// <summary>
        /// In this method run the programme with 10 student and their Marks.
        /// </summary>
        public void Run()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            {
                Students = new string[]
                {
                "Sam", "Money", "Angel","Jyoti","Jamie", "Rose",
                "Harry", "Amrit", "Ali", "Romi",
                };

                GradeProfile = new int[(int)Grades.A + 1];

                Marks = new int[]
                {
                75,45,35,70,22,85,0,56,39,40
                };
            }
            ConsoleHelper.OutputHeading("App03 Student Marks");

            InputMarks();
            OutputHeader();
            OutputGrades();
            OutputStatistics();
            OutputGradesProfile();

            Program.Run();
        }

        private void OutputGrades()
        {
            ConsoleHelper.OutputTitle("List of Student Marks and Grades");

            for (int i = 0; i < Marks.Length; i++)
            {
                Grades outputGrade = CalculateGradeProfile(Marks[i]);
                Console.WriteLine($"{Students[i]}-------Mark = {Marks[i]} Grade = {outputGrade}");
            }
        }


        private void OutputStatistics()
        {
            Mean = (double)Marks.Sum() / (double)Marks.Length;
            Minimum = Marks.Min();
            Maximum = Marks.Max();

            ConsoleHelper.OutputTitle("Statistics");
            Console.WriteLine($"Mean Mark; {Mean} \nMinimum Mark: {Minimum} \nMaximumMark: {Maximum}");
            ConsoleHelper.OutputTitle("Overall Grades:");

            for (int i = 0; i < GradeProfile.Length; i++)
            {
                Console.WriteLine($"Grade {Enum.GetName(typeof(Grades), i + 1)}----{GradeProfile[i]}%");
            }
            Console.WriteLine("\nPress enter to go back to the main option");
            Console.ReadLine();
        }

        /// <summary>
        /// Output Heading of Program
        /// </summary>
        private void OutputHeader()

        {
            Console.WriteLine("_______________________________________");
            Console.WriteLine("          App03 Student Grades         ");
            Console.WriteLine("            by Narinder Kaur           ");
            Console.WriteLine("_______________________________________");
        }

        private void InputMarks()
        {
            Console.WriteLine("Please enter the Mark for each Student\n");
            for(int index = 0; index < Marks.Length; index++)
            {
                Marks[index] = (int)ConsoleHelper.InputNumber($"Please enter a percentage Marks"+
                    $"for: {Students[index]} > ",0, 100);
            }

            
        }



        public Grades ConvertToGrades(int mark)
        {

            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < HighestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= HighestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            return Grades.X;
        }
        /// <summary>
        /// 
        /// </summary>
        public Grades CalculateGradeProfile(int mark)
        {
            Grades grade = ConvertToGrades(mark);
            GradeProfile[(int)grade - 1] = GradeProfile[(int)grade - 1] + (PERCENTAGE / Marks.Length);
            return grade;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrades(mark);
                GradeProfile[(int)grade]++;
            }

        }

        private void OutputGradesProfile()
        {
            Grades grade = Grades.None;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }
        }
    }
}











