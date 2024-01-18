using System;

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
