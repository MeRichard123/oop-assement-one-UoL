using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public enum SuitType
    {
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3,
        Spades = 4,
    }
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4 using enum here
        //The 'set' methods for these properties could have some validation
        private SuitType suitValue;
        private int cardValue;

        public int Value
        {
            get
            {
                return cardValue;
            }

            set
            {
                if (value <= 13 && value >= 1)
                {
                    cardValue = value;
                }
                else
                {
                    throw new ArgumentException("Value invalid");
                }
            }
        }
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
