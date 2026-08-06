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
        public static Deck Shuffle(Deck deck, out int shuffleCount, int times = 1)
        {
            shuffleCount = 0;
            for (int i = 0; i < times; i++)
            {
                shuffleCount++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }

                deck.Cards = TempList;
            }
            return deck;
        }
        public List<Card> Cards { get; set; }
    }
}
