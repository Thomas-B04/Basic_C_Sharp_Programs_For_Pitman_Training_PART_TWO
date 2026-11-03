namespace Blackjack
{
    public class Card
    {
        public SuitType Suit { get; private set; }
        public RankType Rank { get; private set; }

        public Card(SuitType suit, RankType rank)
        {
            Suit = suit;
            Rank = rank;
        }
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