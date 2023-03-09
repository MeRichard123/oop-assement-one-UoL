using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.Play();
            // hold program in order to be able to read the output. 
            Console.ReadLine();
        }
    }
}
