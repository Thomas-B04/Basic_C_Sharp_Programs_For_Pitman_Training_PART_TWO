namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new()
            {
                Players = ["John", "Jane"]
            };

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
