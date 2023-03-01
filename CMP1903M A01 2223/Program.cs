using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            //pack.displayPack();
            Pack.shuffleCardPack(Pack.ShuffleType.FisherYatesShuffle);
            
            Console.WriteLine("Hello!\n");
            Console.WriteLine("Welcome to this set of Card Utilities");
            pack.displayPack();

            Console.WriteLine("\nDealing first 10 cards\n");

            List<Card> d = Pack.dealCard(10);
            pack.displayPack(d);

            while (d.Count > 0)
            {
                Console.WriteLine("\nDealing the next 10 cards\n");
                d = Pack.dealCard(10);
                pack.displayPack(d);
            }


            // hold program in order to be able to read the output. 
            Console.ReadLine();
        }
    }
}
