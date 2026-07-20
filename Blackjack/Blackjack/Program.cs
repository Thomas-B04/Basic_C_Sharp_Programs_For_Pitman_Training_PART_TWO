using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            Deck deck = new Deck();
            
            Console.WriteLine($"Deck has {deck.Cards.Count} cards. And those cards are:");
            foreach (var card in deck.Cards)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }
}
}
