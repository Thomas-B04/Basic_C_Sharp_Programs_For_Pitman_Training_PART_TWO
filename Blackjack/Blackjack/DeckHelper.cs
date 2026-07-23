namespace Blackjack
{
    public static class DeckHelper
    {
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = [];
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }

            deck.Cards = TempList;
            return deck;
        }
    }
}