using System;

namespace CMP1903M_A01_2223
{
    // store the suit types of the card
    public enum SuitType
    {
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3,
        Spades = 4,
    }

    // store the different faces.
    public enum CardFaces
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    public class Card
    {
        private SuitType suitValue;
        private CardFaces cardValue;

        // constructor for card 
        public Card(CardFaces value, SuitType suit)
        {
            suitValue = suit;
            cardValue = value;
        }

        public void display()
        {
            Console.Write($"{cardValue}-{suitValue}, ");
        }

        // validation method for creating a card ensuring it isn't too big. 
        private bool CheckValue(int value)
        {
            if (value <= 13 && value >= 1)
            {
                return true;
            }
            else if (value > 13)
            {
                Console.WriteLine($"Cannot use Value {value} it is too big.");
                return false;
            }
            else if (value < 1)
            {
                Console.WriteLine($"Cannot use Value {value} it is too small.");
                return false;
            }
            else
            {
                Console.WriteLine("Your value is simply wrong.");
                return false;
            }
        }
        
        // getters and setters for the value.
        public int Value
        {
            get
            {
                // return numberic value of card
                return (int)cardValue;
            }

            set
            {
                // set the numberic value if valid 
                if (CheckValue((int)value)) {
                    cardValue = (CardFaces)value;  
                }
            }
        }

        // get and set for suit
        public SuitType Suit {
            get
            {
                return suitValue;
            }
            set
            {
                suitValue = value;         
            }
        }
    }
}
