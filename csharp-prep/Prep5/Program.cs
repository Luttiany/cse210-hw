using System;

class Program
{
    static void Main(string[] args)


    {
        ShowMessage ();
        string userName = AskUserName();
        int userNumber = AskUserNumber();
        int squareNumber = SquareNumber (userNumber);
        ShowResults (userName, squareNumber);


    
    static void ShowMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string AskUserName()
    {
        Console.WriteLine ("Please, enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int AskUserNumber ()
    {
        Console.WriteLine ("Please, enter your favorite number: ");
        int number = int.Parse(Console.ReadLine ());

        return number;

    }

    static int SquareNumber(int number)

    {
        int square = number * number;

        return square;
    }

    static void ShowResults(string name, int square)

    {
        Console.WriteLine ($"{name}, the square of your number is {square}");
    }
    
    
    }


}