using System;
using System.Collections.Generic;
using System.Linq;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        static private List<Card> pack;
        static private int cardsDealt = 0;
       
        // define a way to generate random numbers within a range using the Random class. 
        private static int RandRange(int from, int to) {
            Random random = new Random(0);
            return random.Next(from, to);
        }

        // store the different types of shuffle in an enum
        public enum ShuffleType
        {
            FisherYatesShuffle = 1,
            RiffleShuffle = 2,
            NoShuffle = 3,
        }

        // contructor method for the Pack itself.
        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();

            // loop over all the different types of Suit
            foreach (SuitType suit in Enum.GetValues(typeof(SuitType)))
            {
                // loop over each possible face
                // 4 suits * 13 faces = 52 cards
                foreach (CardFaces face in Enum.GetValues(typeof(CardFaces)))
                {
                    // create a card using the face and suit
                    Card card = new Card(face, suit);
                    // add the card to the pack.
                    pack.Add(card);
                }
            }
        }

        // getter for the object that holds the cards
        public static List<Card> getCardList()
        {
            return pack;
        }

        // nicer way to diplay the cards rather than an object
        public void displayPack()
        {
            foreach (Card card in pack)
            {
                Console.Write($"{card.Value}-{card.Suit}, ");
            }
        }

        public void displayPack(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.Write($"{card.Value}-{card.Suit}, "); 
            }
        }

        public static void RiffleShuffle()
        {
            // calculate the mid point and round in case length is odd
            decimal half = pack.Count / 2;
            int parts = (int)Math.Floor(half);
            // take the first half of the card
            List<Card> left = pack.Take(parts).ToList();
            // take the second half by skipping first n/2
            List<Card> right = pack.Skip(parts).Take(parts).ToList();
            List<Card> shuffled = new List<Card>();

            // add the the output list in sequence to shuffle 
            for (int i = 0; i < parts; i++)
            {
                shuffled.Add(left[i]);
                shuffled.Add(right[i]);
            }
            // ressign the pack to the shuffled one
            pack = shuffled;
        }

        public static void FisherYatesShuffle()
        {
            for (int currentCardIndex = 0; currentCardIndex < pack.Count - 1; currentCardIndex++)
            {
                // for each card we pick a random card from the current card to the end 
                int randomIndex = RandRange(currentCardIndex, pack.Count);
                // swap the current card with the random card.
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
            if (cardsDealt+amount >= pack.Count)
            {
                Console.Error.WriteLine("Pack doesn't contain enough cards to deal that many");
                return new List<Card>();
            }

            var cards = pack.Skip(cardsDealt).Take(amount).ToList();
            cardsDealt += amount;
            // Deals the number of cards specified by 'amount'
            // since they would have gone through a shuffle by this point we just take the
            // first n cards. 
            return cards;
        }
    }
}
