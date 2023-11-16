using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment();
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment();
        Console.WriteLine(writing.GetWritingInformation());
        
    }
}