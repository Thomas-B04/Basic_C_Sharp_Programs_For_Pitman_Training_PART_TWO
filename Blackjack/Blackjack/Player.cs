namespace Blackjack
{
    public class Player
    {
        // Properties of the Player class
        public List<Card> Hand { get; set; } = []; 
        public int Balance { get; set; } 
        public required string Name { get; set; } 
        public bool IsActivelyPlaying { get; set; }

        // Overloaded + operator to add a player to a game
        public static Game operator +(Game game, Player player) 
        {
            game.Players.Add(player); // Add the player to the game's list of players
            return game; // Return the updated game
        }

        // Overloaded - operator to remove a player from a game
        public static Game operator -(Game game, Player player) 
        {
            game.Players.Remove(player); // Remove the player from the game's list of players
            return game; // Return the updated game
        }
    }
}
