namespace Blackjack
{
    public class Player
    {
        public List<Card> Hand { get; set; } = []; // Property to hold the player's hand of cards
        public int Balance { get; set; } // Property to hold the player's balance
        public required string Name { get; set; } // Property to hold the player's name
        public bool IsActivelyPlaying { get; set; } // Property to indicate if the player is actively playing

    }
}
