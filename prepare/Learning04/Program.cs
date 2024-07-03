using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newStudent = new Assignment("Shaun Marquis", "Multiplication");

        Console.WriteLine(newStudent.GetSummary());

        MathAssignment shaunWork = new MathAssignment("Shaun Marquis","Science","7.3","8-10");

        Console.WriteLine(shaunWork.GetSummary());
        Console.WriteLine(shaunWork.GetHomeworkList());

        WritingAssignment shaunWrite = new WritingAssignment("Shaun Marquis","USA History","Why the US is the Best");

        Console.WriteLine(shaunWrite.GetSummary());
        Console.WriteLine(shaunWrite.GetWritingInformation());
    }
}