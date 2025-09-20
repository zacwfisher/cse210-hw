using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is D.");
        }
        else if (gradePercentage < 60)
        {
            Console.WriteLine("Your letter grade is F.");
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }

    }
}