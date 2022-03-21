namespace ConsoleAppProject.App03
{
    public interface IStudentGrades
    {
        int[] GradeProfile { get; set; }
        int[] Marks { get; set; }
        int Maximum { get; set; }
        double Mean { get; set; }
        int Minimum { get; set; }
        string[] Students { get; set; }
        int Total { get; set; }

        void CalculateGradeProfile();
        Grades CalculateGradeProfile(int mark);
        Grades ConvertToGrades(int mark);
        void Run();
    }
}