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
                if (value <= 13 && value >= 1) {
                    cardValue = value;
                }
                else if (value > 13) { 
                    Console.WriteLine($"Cannot use Value {value} it is too big.");
                }
                else if (value < 1) {
                    Console.WriteLine($"Cannot use Value {value} it is too small.");
                }
                else {
                    Console.WriteLine("You value is simply wrong.");
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
