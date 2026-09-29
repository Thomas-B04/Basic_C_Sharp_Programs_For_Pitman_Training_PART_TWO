namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame
            {
                Players = [] // Initialize the Players list
            };
            Player player = new() { Name = "John Doe" };// Create a new player
            game += player; // Add player to the game using overloaded + operator
            game -= player; // Remove player from the game using overloaded - operator

            // List players in the game
            game.ListPlayers();

            // Deck setup and shuffling
            Deck deck = new();
            deck = Deck.Shuffle(deck, out int shuffleCount, 3);

            foreach (var card in deck.Cards)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }

            Console.WriteLine($"The deck was shuffled: {shuffleCount} times.");
        }
    }
}
