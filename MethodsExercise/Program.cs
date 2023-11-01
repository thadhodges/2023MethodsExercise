namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Mad Libs game!");

            // Prompt the user for various inputs
            Console.Write("Enter an adjective: ");
            string? adjective1 = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string? noun1 = Console.ReadLine();

            Console.Write("Enter a verb (past tense): ");
            string? verb1 = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            string? adverb = Console.ReadLine();

            Console.Write("Enter a noun (plural): ");
            string? pluralNoun = Console.ReadLine();

            Console.Write("Enter a verb (present tense): ");
            string? verb2 = Console.ReadLine();

            // Construct the Mad Libs story
            string madLibsStory = $"Today, I saw a {adjective1} {noun1} that {verb1} {adverb} " +
                                  $"across the park. Later, it joined a group of {pluralNoun} " +
                                  $"and they all started to {verb2} together.";

            // Display the resulting story
            Console.WriteLine("\nHere's your Mad Libs story:");
            Console.WriteLine(madLibsStory);

            Console.ReadLine(); // Wait for user to press Enter to exit

        }
    }
}
