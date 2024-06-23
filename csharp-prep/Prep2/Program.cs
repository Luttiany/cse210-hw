using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Please inform your grade percentage:");

        string grade = Console.ReadLine ();
        int percentage = int.Parse (grade);

        

        if (percentage >= 90)
        {
            Console.WriteLine ("Your grade is A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine ("Your grade is B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine ("Your grade is C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine ("Your grade is D");
        }
        else
        {
            Console.WriteLine ("Your grade is F");
        }

        if (percentage >= 70)
        {
            Console.WriteLine ("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine ("Better luck next time, try again!");
        }

    }
}