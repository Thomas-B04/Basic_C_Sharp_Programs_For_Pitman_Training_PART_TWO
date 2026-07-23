using System;
using System.Security.Cryptography.X509Certificates;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            Deck deck = new Deck();
            deck = DeckHelper.Shuffle(deck);

            Console.WriteLine($"Deck has {deck.Cards.Count} cards. And those cards are:");
            foreach (var card in deck.Cards)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }
    }
}
