using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        static private List<Card> pack;
       
        private static Random random = new Random(0);
        private static int RandRange(int from, int to) {
            return random.Next(from, to);
        }

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

        public enum ShuffleType
        {
            FisherYatesShuffle = 1,
            RiffleShuffle = 2,
            NoShuffle = 3,
        }

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();

            foreach (var suit in Enum.GetValues(typeof(SuitType)))
            {
                foreach (var face in Enum.GetValues(typeof(CardFaces)))
                {
                    Card card = new Card();
                    card.Suit = (SuitType)suit;
                    card.Value = (int)face;
                    pack.Add(card);
                }
            }
        }

        public void displayPack()
        {
            foreach (Card card in pack)
            {
                Console.Write($"{card.Value}-{card.Suit}, ");
            }
        }

        public static void RiffleShuffle()
        {
            decimal half = pack.Count / 2;
            int parts = (int)Math.Floor(half);
            List<Card> left = pack.Skip(0).Take(parts).ToList();
            List<Card> right = pack.Skip(parts).Take(parts).ToList();
            List<Card> shuffled = new List<Card>();

            for (int i = 0; i < parts; i++)
            {
                shuffled.Add(left[i]);
                shuffled.Add(right[i]);
            }
            pack = shuffled;
        }

        public static void FisherYatesShuffle()
        {
            for (int i = 0; i < pack.Count - 1; i++)
            {
                int randomIndex = RandRange(i, pack.Count);
                Card temp= pack[i];
                pack[i] = pack[randomIndex];
                pack[randomIndex] = temp;
            }
        }

        public static bool shuffleCardPack(ShuffleType typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            switch (typeOfShuffle)
            {
                case ShuffleType.NoShuffle:
                    break;

                case ShuffleType.RiffleShuffle:
                    RiffleShuffle();
                    break;

                case ShuffleType.FisherYatesShuffle:
                    FisherYatesShuffle();
                    break;
            }
            return true;
        }
        public static Card deal()
        {
            //Deals one card
            return new Card();
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> items = new List<Card>();
            items.Add(new Card());
            return items;
        }
    }
}
