using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name: Lyrica Yoshida
 * ID: 300923951
 * Date: July 25, 2017
 * Description: This is a demo for Lesson 11
 * Version: 0.3 - Tested the Shuffle method of the Deck class
 */

namespace COMP123___S2017__Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());
        }
    }
}
