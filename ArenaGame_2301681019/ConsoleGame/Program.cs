using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0, threeWins = 0, fourWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                Hero one = new Knight("Sir Lancelot");
                Hero two = new Rogue("Robih Hood");
                Hero three = new Mage("Louis Minci");
                Hero four = new Barbarian("Kaedehara Kazuha");

                Console.WriteLine($"Arena fight between: {one.Name}, {two.Name}, " +
                    $"{three.Name} and {four.Name}");
                Arena arena = new Arena(one, two, three, four);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) { oneWins++; }
                if (winner == two) { twoWins++; }
                if (winner == three) { threeWins++; }
                else fourWins++;
            }

            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");
            Console.WriteLine($"Three has {threeWins} wins.");
            Console.WriteLine($"Four has {fourWins} wins.");

            Console.ReadLine();
        }
    }
}
