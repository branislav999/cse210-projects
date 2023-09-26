using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Please input the grade %: ");
        // string input = Console.ReadLine();

        // int percentage = int.Parse(input);

        // if (percentage >= 90) {
        //     Console.WriteLine("Your grade is A ");
        // }
        // else if (percentage >= 80) {
        //     Console.WriteLine("Your grade is B ");
        // }
        // else if (percentage >= 70) {
        //     Console.WriteLine("Your grade is C ");
        // }
        // else if (percentage >= 60) {
        //     Console.WriteLine("Your grade is D ");
        // }
        // else {
        //     Console.WriteLine("Your grade is F ");
        // }

        // if (percentage >= 70) {
        //     Console.WriteLine("Congrats, you have passed the class ");
        // }
        // else {
        //     Console.WriteLine("Unfortunately, you have failed the class. Study harder next time.");
        // }



        Console.Write("Please input the grade %: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string letter;
        int remainder;
        string suffix = "";

        if (percentage >= 90) {
            letter = "A";
        }
        else if (percentage >= 80) {
            letter = "B";
        }
        else if (percentage >= 70) {
            letter = "C";
        }
        else if (percentage >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        remainder = percentage % 10;

        if (remainder >= 7 && letter != "A" && letter != "F")
        {
            suffix = "+";
        }
        else if (remainder <= 3 && letter != "F") 
        {
            suffix = "-";
        }

        Console.WriteLine($"Your grade is {letter}{suffix}. ");
    
    }
}
