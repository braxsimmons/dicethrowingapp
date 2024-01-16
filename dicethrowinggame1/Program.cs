using System;

class Program
{
    static void Main()
    {
        // Greeting message for the user
        Console.WriteLine("Welcome to the dice throwing simulator!");

        // Prompting the user to input the number of dice rolls
        Console.Write("How many dice rolls would you like to simulate? ");
        // Reading and parsing the user's input
        int numberOfRolls = int.Parse(Console.ReadLine());

        // Creating an instance of DiceRoller
        DiceRoller roller = new DiceRoller();
        // Calling RollDice method to simulate dice rolls
        int[] rollResults = roller.RollDice(numberOfRolls);

        // Displaying the results
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

        // Looping through each possible dice roll sum
        for (int i = 0; i < rollResults.Length; i++)
        {
            // Displaying the roll sum
            Console.Write($"{i + 2}: ");
            // Calculating the percentage
            int stars = rollResults[i] * 100 / numberOfRolls;
            // Displaying the *
            Console.WriteLine(new string('*', stars));
        }

        // End message for the user
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        // Waits for a key press before closing
        Console.ReadKey();
    }
}

public class DiceRoller
{
    public int[] RollDice(int numberOfRolls)
    {
        // Array to store the count of each possible sum (2-12) of two dice rolls
        int[] results = new int[11];
        // Creating a Random object for generating random numbers
        Random random = new Random();

        // Looping for the number of rolls inputted by the user
        for (int i = 0; i < numberOfRolls; i++)
        {
            // Simulating two dice rolls and summing them up
            int roll = random.Next(1, 7) + random.Next(1, 7);
            // Incrementing the count of the sum in array
            results[roll - 2]++;
        }

        // Return the array of roll sums
        return results;
    }
}
