using System;
using System.Collections.Generic;
using System.Linq;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        static private List<Card> pack;
       
        private static int RandRange(int from, int to) {
            Random random = new Random(0);
            return random.Next(from, to);
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

            foreach (SuitType suit in Enum.GetValues(typeof(SuitType)))
            {
                foreach (CardFaces face in Enum.GetValues(typeof(CardFaces)))
                {
                    Card card = new Card(face, suit);
                    pack.Add(card);
                }
            }
        }


        public static List<Card> getCardList()
        {
            return pack;
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
            List<Card> left = pack.Take(parts).ToList();
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
            for (int currentCardIndex = 0; currentCardIndex < pack.Count - 1; currentCardIndex++)
            {
                int randomIndex = RandRange(currentCardIndex, pack.Count);
                Card currentCard = pack[currentCardIndex];
                pack[currentCardIndex] = pack[randomIndex];
                pack[randomIndex] = currentCard;
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
            // being honest I don't know why this isn't a void function
            // but I going to assume that the template code has knowledge
            // which I do not yet posess.  
            return true;
        }
        public static Card deal()
        {
            //Deals one card, since they are shuffed we can just take one from the top.
            return pack[0];
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            // since they would have gone through a shuffle by this point we just take the
            // first n cards. 
            // this might need to be able to deal to mutliple players!!
            // might need at skip by amount after the first deal
            return pack.Take(amount).ToList();
        }
    }
}
