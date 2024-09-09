using System;
using System.Collections.Generic;

namespace Lists_Wixson_hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of games
            List<string> games = new List<string>
            {
                "CS:GO",
                "Halo 3",
                "BorderLands 3",
                "Fifa 22",
                "Minecraft"
            };

            // Create an array of other games
            string[] otherGames = new string[]
            {
                "Tiny Tina's Wonderland",
                "Farcry 3"
            };

            // Print the initial list of games
            Console.WriteLine("Initial games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Add the other games to the list
            games.AddRange(otherGames);

            // Print the updated list of games
            Console.WriteLine("\nUpdated games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Check if "Halo" is in the list
            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHEIF IS IN THE HOUSE!!");
            }
            else
            {
                // Add "Halo" if it's not found
                games.Add("Halo");
            }

            // Remove a game at a specific index
            int myInt = 6;
            if (myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }

            // Print the updated list
            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Sort the list
            games.Sort();

            // Print the sorted list
            Console.WriteLine("\nSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Copy the list to an array
            string[] newList = new string[games.Count];
            games.CopyTo(newList);

            // Clear the original list
            games.Clear();

            // Print the new array
            Console.WriteLine("\nNew List:");
            foreach (string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
