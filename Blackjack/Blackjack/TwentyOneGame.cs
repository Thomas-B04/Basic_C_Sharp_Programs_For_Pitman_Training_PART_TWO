namespace Blackjack
{
    public class TwentyOneGame : Game, IWalkAway // Inherits from Game and implements IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Players in the TwentyOne game:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
