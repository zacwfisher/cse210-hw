using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John Doe", "Math");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("John Doe", "Math", "Section 1.1", "1-10");
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(homeworkList);
        
        WritingAssignment writingAssignment = new WritingAssignment("John Doe", "English", "The Great Gatsby");
        string writingInfo = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingInfo);
    }
}