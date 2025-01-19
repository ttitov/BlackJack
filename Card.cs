using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public enum Rank
        {
            Ace = 1, // Could have value 11 as well
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11, // value 10
            Queen = 12, // value 10
            King = 13 // value 10
        }

        public Suit CardSuit { get; private set; }
        public Rank CardRank { get; private set; }
        public string ImagePath { get; private set; }

        public Card(Suit suit, Rank rank, string imagePath)
        {
            CardSuit = suit;
            CardRank = rank;
            ImagePath = imagePath;
        }
    }

}
