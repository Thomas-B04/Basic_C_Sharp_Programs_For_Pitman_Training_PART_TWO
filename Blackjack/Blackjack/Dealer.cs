using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Dealer
    {
        public required string Name { get; set; }
        public required Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> hand)
        {
            hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First());
            Deck.Cards.RemoveAt(0);
        }
    }
}
