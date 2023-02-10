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
            Card card = new Card();
            card.Value = 20;
            card.Suit = SuitType.Clubs;
            Console.WriteLine(card);

            // hold program idk why lol
            Console.ReadLine();
        }
    }
}
