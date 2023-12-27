using System;
using System.Collections.Generic;
using System.Linq;

enum Suit
{
    Heart,
    Square,
    Cross,
    Spade
}

enum Value
{
    A,
    K,
    Q,
    J,
    Ten,
    Nine,
    Eight,
    Seven,
    Six,
    Five,
    Four,
    Three,
    Two
}

class Card
{
    public Suit Suit { get; private set; }
    public Value Value { get; private set; }

    public Card(Suit suit, Value value)
    {
        Suit = suit;
        Value = value;
    }

    public override string ToString()
    {
        return $"{Value} of {Suit}s";
    }
}

class CardDeck
{
    private List<Card> cards;

    public CardDeck()
    {
        cards = new List<Card>();
        InitializeDeck();
    }

    private void InitializeDeck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Value value in Enum.GetValues(typeof(Value)))
            {
                cards.Add(new Card(suit, value));
            }
        }
    }

    public void Shuffle()
    {
        Random random = new Random();
        cards = cards.OrderBy(card => random.Next()).ToList();
    }

    public void PrintDeck()
    {
        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }
    }
}

class Program
{
    static void Main()
    {
        CardDeck deck = new CardDeck();
        Console.WriteLine("Original Deck:");
        deck.PrintDeck();

        deck.Shuffle();
        Console.WriteLine("\nShuffled Deck:");
        deck.PrintDeck();
    }
}
