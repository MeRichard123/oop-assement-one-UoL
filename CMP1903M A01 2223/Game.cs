using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    // additional class to mimic a basic game for testing.
    internal class Game
    {
        // define the arrays to store player cards
        private static List<Card> playerHand = new List<Card>();
        private static List<Card> PCHand = new List<Card>();
        private static Pack gamePack;

        // instansiate a pack
        public Game()
        {
            gamePack = new Pack();
        }

        // shuffle options 
        private void shuffleCards()
        {
            Console.WriteLine("Pick a method of shuffle: ");
            Console.WriteLine(@"
                1. Riffle Shuffle 
                2. Fischer-Yates Shuffle
                3. Don't shuffle
                ");
            int shuffleNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Shuffling Cards...");

            switch (shuffleNumber)
            {
                case 1:
                    Pack.shuffleCardPack(Pack.ShuffleType.RiffleShuffle);
                    break;
                case 2:
                    Pack.shuffleCardPack(Pack.ShuffleType.FisherYatesShuffle);
                    break;
                case 3:
                    Pack.shuffleCardPack(Pack.ShuffleType.NoShuffle);
                    break;
                default:
                    Console.WriteLine("Bad Option");
                    break;
            }

            gamePack.displayPack();

        }

        // deal cards to players
        private void dealPlayerCards()
        {
            Console.WriteLine("\n \nDealing You and the Computer 10 Cards");
            List<Card> dealtP = Pack.dealCard(10);
            playerHand.AddRange(dealtP);

            Console.WriteLine("Your cards are: \n");
            gamePack.displayPack(playerHand);

            List<Card> dealtPC = Pack.dealCard(10);
            PCHand.AddRange(dealtPC);
        }

        // game loop
        public void Play()
        {
            Console.WriteLine("Welcome to this Test Card Game");

            shuffleCards();
            dealPlayerCards();

            int playerScore = 0;
            int computerScore = 0;
            int rounds = 0;

            while (rounds < 5)
            {
                Console.WriteLine("\n Select a Card: \n");
                for (int i = 1; i < playerHand.Count + 1; i++)
                {
                    Console.WriteLine($"{i}) {playerHand[i-1].ToString()}");
                }
                try
                {
                    int SelectedCard = int.Parse(Console.ReadLine()) - 1;
                    if (SelectedCard >= 0 && SelectedCard < 10)
                    {
                        Card selected = playerHand[SelectedCard];
                        Random rn = new Random();
                        int RandomCard = rn.Next(0, PCHand.Count - 1);
                        Card AISelect = PCHand[RandomCard];

                        Console.WriteLine($"You Selected: {selected.ToString()}");
                        Console.WriteLine($"Computer Selected: {AISelect.ToString()}");

                        if (selected.Value > AISelect.Value)
                        {
                            playerScore++;
                            Console.WriteLine("You win this round!");
                        }
                        else
                        {
                            computerScore++;
                            Console.WriteLine("Computer Won this Round");
                        }
                    }
                    rounds++;
                }catch(FormatException) { 
                    Console.WriteLine("Invalid Input");
                 }
            }
            if (playerScore > computerScore)
            {
                Console.WriteLine("\nYou Win!");
                Console.WriteLine($"Your Score: {playerScore}");
                Console.WriteLine($"Computer Score: {computerScore}");
            }
            else
            {
                Console.WriteLine("\nYou Lost");
                Console.WriteLine($"Your Score: {playerScore}");
                Console.WriteLine($"Computer Score: {computerScore}");
            }

        }
    }
}
