using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> cards;
        private Random random;
        public const int NUMBER_OF_DECKS = 6; // Six decks as a standard in UK
        public const int CARDS_IN_SINGLE_DECK = 52;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();
            InitializeMultipleDecks();
        }

        private void InitializeMultipleDecks()
        {
            // Create 6 decks
            for (int deckNumber = 0; deckNumber < NUMBER_OF_DECKS; deckNumber++)
            {
                foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
                {
                    foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                    {
                        string rankStr = RankToString(rank);
                        string suitStr = suit.ToString().ToLower();
                        string resourceName = $"{rankStr}_of_{suitStr}";
                        cards.Add(new Card(suit, rank, resourceName));
                    }
                }
            }
            Shuffle();
        }

        private string RankToString(Card.Rank rank)
        {
            switch (rank)
            {
                case Card.Rank.Ace: return "ace";
                case Card.Rank.Two: return "2";
                case Card.Rank.Three: return "3";
                case Card.Rank.Four: return "4";
                case Card.Rank.Five: return "5";
                case Card.Rank.Six: return "6";
                case Card.Rank.Seven: return "7";
                case Card.Rank.Eight: return "8";
                case Card.Rank.Nine: return "9";
                case Card.Rank.Ten: return "10";
                case Card.Rank.Jack: return "jack";
                case Card.Rank.Queen: return "queen";
                case Card.Rank.King: return "king";
                default: throw new ArgumentException("Invalid rank");
            }
        }

        //The Fisher-Yates shuffle algorithm
        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = cards[k];
                cards[k] = cards[n];
                cards[n] = temp;
            }
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("No cards left in deck!");
            }

            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }

        public bool NeedsReshuffle()
        {
            // Reshuffle when less than 20% of cards remain
            return cards.Count < (NUMBER_OF_DECKS * CARDS_IN_SINGLE_DECK * 0.2);
        }
    }
}
