using System;

namespace tower_of_hanoi
{
    /// <summary>
    /// This is a very basic implementation of the recursion logic in the Tower of Hanoi game.
    /// I call the three towers/pegs Source, Destination and Auxilliary.
    /// 
    /// Made by Danny.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfDiscs = GetUserInput();
            Console.WriteLine("");
            MakeMove(amountOfDiscs, "Source", "Destination", "Auxilliary");
            double amountOfMoves = Math.Pow(2, amountOfDiscs) - 1;
            Console.WriteLine("Done!");
            Console.WriteLine("\nAmount of moves used to complete: " + amountOfMoves);
        }

        /// <summary>
        /// Moves a dics from one tower to the other.
        /// </summary>
        /// <param name="discs">Amount of discs to move.</param>
        /// <param name="source">Source tower.</param>
        /// <param name="dest">Destination tower.</param>
        /// <param name="aux">Auxilliary tower.</param>
        private static void MakeMove(int discs, String source, String dest, String aux)
        {
            if (discs == 1)
            {
                Console.WriteLine("Moved disc from " + source + " to " + dest);
            }
            else
            {
                MakeMove(discs - 1, source, aux, dest);
                Console.WriteLine("Moved disc from " + source + " to " + dest);
                MakeMove(discs - 1, aux, dest, source);
            }
        }

        /// <summary>
        /// Gets the user input ie. amount discs to use.
        /// </summary>
        /// <returns>The user input.</returns>
        private static int GetUserInput()
        {
            int input;
            while (true)
            {
                Console.WriteLine("Enter amount of discs:");
                try
                {
                    input = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You didn't correctly enter an integer. Try again:");
                    continue;
                }

            }

            return input;
        }
    }
}
