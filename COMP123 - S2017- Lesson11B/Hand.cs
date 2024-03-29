﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Lyrica Yoshida
 * ID: 300923951
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList Abstract class
 * Version: 0.3 - Added the HighestCards method
 */

namespace COMP123___S2017__Lesson11B
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS
        protected override void _initialize()
        {
            // STUB
            // this method is empty
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string output = "";

            output += "Hand Constains  Number of Cards: " + this.Count + "\n";
            output += "=====================================\n";

            foreach (Card card in this)
            {
                output += card.ToString() + "\n";
            }
            return output;
        }

        public void HighestCards()
        {
            var sorted =
                from card in this
                orderby card.Face
                select card;
            Console.WriteLine("The highest card in the hand is: " + sorted.Last().ToString());
        }
    }
}
