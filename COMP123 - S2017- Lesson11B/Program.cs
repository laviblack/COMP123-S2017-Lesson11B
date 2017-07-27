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
 * Version: 0.4 - Tested the Deal1 method of the Deck class
 */

namespace COMP123___S2017__Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //Hand hand = new Hand();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());

            //hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());
            //Console.WriteLine();
            //hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());

            //Console.WriteLine();
            //Console.WriteLine(deck.ToString());

            Hand hand = deck.Deal5();
            Console.WriteLine(hand.ToString());

            Console.WriteLine();
            Console.WriteLine(deck.ToString());

            hand.HighestCards();
        }
    }
}
