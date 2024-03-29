﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name: Lyrica Yoshida
 * ID: 300923951
 * Date: July 25, 2017
 * Description: This is the Deck class
 * It inherits from the CardList abstract class
 * Version: 0.7 - Implemented the ToString method of the Card class
 */

namespace COMP123___S2017__Lesson11B
{
    public class Deck : CardList
    {
        // PRIVATE INSTANCE VARIABLES
        private Random _random;

        // PRIVATE PROPERTIES
        private Random Random
        {
            get
            {
                return this._random;
            }
        }

        // PUBLIC PROPERTIES

        // CONSTRUCTOR

        // PRIVATE METHODS
        
        /// <summary>
        /// This is the Initialize method it sets values for private variables
        /// and public properties as well as other class objects.
        /// </summary>
        protected override void _initialize()
        {
            // initialize the random number generator
            this._random = new Random();

            // This builts a deck
            for(int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for(int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // PUBLIC METHODS 

        /// <summary>
        /// This method overrides the built-in ToString method
        /// </summary>
        /// <returns>
        /// This method returns current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string output = "";

            output += "Deck Constains  Number of Cards: " + this.Count + "\n";
            output += "=====================================\n";

            foreach(Card card in this)
            {
                output += card.ToString() + "\n";
            }
            return output;
        }

        /// <summary>
        /// This method shuffles the deck by using random indices to select two cards at a time
        /// It uses a Fisher-Yates like algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;


            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0, this.Count);
                secondCard = this.Random.Next(0, this.Count);

                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }

        /// <summary>
        /// This method returns the top card of the deck
        /// </summary>
        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0); // this removes the top card from the deck

            // for testing / debugging only
            Console.WriteLine("Dealt 1 card - Size of Deck: " + this.Count);

            return topCard;
        }

        /// <summary>
        /// This method deal top 5 cards from the deck
        /// and returns a hand contains these cards
        /// </summary>
        public Hand Deal5()
        {
            Hand hand = new Hand();
            for(int i =0;i<5;i++)
            {
                hand.Add(Deal1());
            }
            return hand;
        }
    }
}
