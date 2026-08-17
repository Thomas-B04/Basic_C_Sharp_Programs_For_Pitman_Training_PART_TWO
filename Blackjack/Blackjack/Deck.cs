namespace Blackjack // Define the Blackjack namespace
{
    public class Deck // Define a public Deck class
    {
        public Deck() // Constructor for the Deck class
        {
            Cards = new List<Card>(); // Initialize the Cards property as an empty list
            List<string> Suits = new List<string> { "Hearts", "Diamonds", "Clubs", "Spades" };
            List<string> Ranks = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in Suits) // Loop through each suit
            {
                foreach (string rank in Ranks) // Loop through each rank for the current suit
                {
                    Card card = new(suit, rank); // Create a new card with the current suit and rank
                    Cards.Add(card); // Add the card to the deck
                }
            }
        }
        public static Deck Shuffle(Deck deck, out int shuffleCount, int times = 1) // Static method to shuffle a deck with optional times parameter
        {
            shuffleCount = 0; // Initialize the shuffle count to zero
            for (int i = 0; i < times; i++) // Loop for the specified number of shuffles
            {
                shuffleCount++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(deck.Cards.Count); // Generate a random index within the remaining cards
                    TempList.Add(deck.Cards[randomIndex]); // Add the randomly selected card to the temp list
                    deck.Cards.RemoveAt(randomIndex); // Remove the card from the original deck
                }

                deck.Cards = TempList;
            }
            return deck;
        }
        public List<Card> Cards { get; set; }
    }
}
