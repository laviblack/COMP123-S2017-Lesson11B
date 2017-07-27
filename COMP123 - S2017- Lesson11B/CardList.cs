using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Lyrica Yoshida
 * ID: 300923951
 * Date: July 27, 2017
 * Description: This is the abstract superclass CardList
 * Version: 0.1 - Created the CardList abstract class
 */

namespace COMP123___S2017__Lesson11B
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public CardList()
        {
            this._initialize();
        }

        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS
    }
}
