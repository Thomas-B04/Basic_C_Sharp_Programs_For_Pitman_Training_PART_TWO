namespace Blackjack
{
    public class Player
    {
        public List<Card> Hand { get; set; } = []; // Property to hold the player's hand of cards
        public int Balance { get; set; } // Property to hold the player's balance
        public required string Name { get; set; } // Property to hold the player's name
        public bool IsActivelyPlaying { get; set; } // Property to indicate if the player is actively playing

        public static Game operator +(Game game, Player player) // Overloaded + operator to add a player to a game
        {
            game.Players.Add(player); // Add the player to the game's list of players
            return game; // Return the updated game
        }   

        public static Game operator -(Game game, Player player) // Overloaded - operator to remove a player from a game
        {
            game.Players.Remove(player); // Remove the player from the game's list of players
            return game; // Return the updated game
        }
    }
}
