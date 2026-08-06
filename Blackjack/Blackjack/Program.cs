namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            Deck deck = new Deck();
            int shuffleCount;
            deck = Deck.Shuffle(deck, out shuffleCount, 3);

            Console.WriteLine($"Deck has {deck.Cards.Count} cards. And those cards are:");
            foreach (var card in deck.Cards)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
            Console.WriteLine(deck.Cards.Count == 52 ? "COMEPLETION: Deck is complete." : "WARNING: Deck is incomplete.");
            Console.WriteLine($"There are {deck.Cards.Count} cards in the deck.");
            Console.WriteLine($"The deck was shuffled: {shuffleCount} times.");
        }
    }   
}
