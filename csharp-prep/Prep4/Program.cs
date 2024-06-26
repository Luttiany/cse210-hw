using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int newNumber= -1;

        while (newNumber != 0)

        {
            string response = Console.ReadLine();
            newNumber = int.Parse(response);

            if (newNumber != 0)

            {
            numbers.Add (newNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)

        {
            sum += number;
        }

        Console.WriteLine ($"The total sum is {sum} ");

        // this calculates the greater number in the list.

        int greater = numbers[0];

        foreach (int number in numbers)
        {
            if (greater < number)
            {
                greater = number;
            }
        }

        Console.WriteLine ($"The greater number is {greater}.");
        
        // this calculates the average number.
        float average = ((float) sum) / numbers.Count;
        Console.WriteLine ($"The average number is {average}.");
    

    }
}