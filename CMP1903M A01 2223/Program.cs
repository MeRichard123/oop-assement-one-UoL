using System;
using System.Collections.Generic;
using System.Linq;
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
            
            //Pack.shuffleCardPack(Pack.ShuffleType.RiffleShuffle);
            
            Console.WriteLine("Hello!\n");
            Console.WriteLine("Welcome to this set of Card Utilities");
            //pack.displayPack();
            // hold program idk why lol
            Console.ReadLine();
        }
    }
}
