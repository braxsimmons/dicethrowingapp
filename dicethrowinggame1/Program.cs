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
