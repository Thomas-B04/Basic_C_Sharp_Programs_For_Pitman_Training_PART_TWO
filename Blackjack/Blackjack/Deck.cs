namespace Blackjack // Define the Blackjack namespace
{
    public class Deck // Define a public Deck class
    {
        public Deck() // Constructor for the Deck class
        {
            Cards = []; // Initialize the Cards property as an empty list

            for (int i = 0; i < 4; i++)// Loop through the four suits
            {
                for (int j = 0; j < 13; j++) //Loop through the thirteen ranks
                {
                    Card card = new((Card.SuitType)i, (Card.RankType)j); // Create a new card with the current suit and rank
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
                List<Card> TempList = [];
                Random random = new();

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
