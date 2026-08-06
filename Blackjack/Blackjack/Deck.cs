namespace Blackjack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string> { "Hearts", "Diamonds", "Clubs", "Spades" };
            List<string> Ranks = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in Suits)
            {
                foreach (string rank in Ranks)
                {
                    Card card = new(suit, rank);
                    Cards.Add(card);
                }

                //Cards = new List<Card>();
                //Card cardOne = new Card("Hearts", "Ace");
                //Cards.Add(cardOne);
            }
        }
        public List<Card> Cards { get; set; }
    }
}
