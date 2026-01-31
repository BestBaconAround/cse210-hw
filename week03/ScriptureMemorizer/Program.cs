using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDS CORE REQUIREMENTS (creativity):
        // 1) Multiple scriptures are available and one is randomly selected at program start.
        // 2) A progress indicator shows how many words are hidden (percent) each round.
        // Both features are fully functional.

        List<Scripture> scriptures = BuildScriptureLibrary();
        Random rng = new Random();

        Scripture scripture = scriptures[rng.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine($"Hidden: {scripture.GetHiddenPercent():0}%");
            Console.WriteLine();
            Console.Write("Press Enter to hide words, or type 'quit' to exit: ");

            string input = Console.ReadLine() ?? "";

            if (input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                // Final display requirement: show the scripture fully hidden, then end.
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine($"Hidden: {scripture.GetHiddenPercent():0}%");
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Program ending.");
                break;
            }

            // Hide a few random words each round.
            // You can tweak this number for difficulty.
            scripture.HideRandomWords(countToHide: 3, rng);
        }
    }

    private static List<Scripture> BuildScriptureLibrary()
    {
        // You can add more scriptures here easily.
        return new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."
            )
        };
    }
}
