using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public string [] Students { get; set; }

        public int [] Marks { get; set; }


        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Students = new string [] {  "Sam", "Money", "Angel","Jyoti","Jamie", "Rose", "Harry", "Amrit", "Ali", "Romi",};
            Marks = new int[Students.Length];
            ConsoleHelper.OutputHeading("App03 Student Marks");
        
            InputMarks();
            ConvertTOGrades();
            OutputGrades();
        }
        private void InputMarks()
        {
            Console.WriteLine("Please enter the Mark for each Student\n"); 
            int index = 0;

            foreach(string name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"{name}Enter mark > ", 0,100);
                Marks[index] = mark;
            }
        }
        
        private void OutputGrades()
        {
            for(int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine($"{Students[i]} mark ={Marks[i]}");
            }
        }

        private void ConvertTOGrades()
        {
            throw new NotImplementedException();
        }

       
    }
    }

