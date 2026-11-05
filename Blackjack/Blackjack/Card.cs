namespace Blackjack
{
    public struct Card(Card.SuitType suit, Card.RankType rank)
    {
        public SuitType Suit { get; private set; }
        public RankType Rank { get; private set; }


        public enum SuitType
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }
        public enum RankType
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
    }
}