using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceRoller roller = new DiceRoller();
        int[] rollResults = roller.RollDice(numberOfRolls);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

        for (int i = 0; i < rollResults.Length; i++)
        {
            Console.Write($"{i + 2}: ");
            int stars = rollResults[i] * 100 / numberOfRolls; // Convert to percentage
            Console.WriteLine(new string('*', stars));
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        Console.ReadKey();
    }
}

public class DiceRoller
{
    public int[] RollDice(int numberOfRolls)
    {
        int[] results = new int[11]; // For storing counts of sums (2-12)
        Random random = new Random();

        for (int i = 0; i < numberOfRolls; i++)
        {
            int roll = random.Next(1, 7) + random.Next(1, 7); // Two dice rolls
            results[roll - 2]++; // Increment count of the sum
        }

        return results;
    }
}

