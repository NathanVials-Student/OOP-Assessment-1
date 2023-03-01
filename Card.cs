using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        private int _value;
        private int _suit;
        public int Value {
            get { return _value; }
            set
            { 
                bool validVal = false;
                if (Value > 0)
                {
                    if (Value < 14)
                    {
                        validVal = true;
                    }
                }
                _value = Value;
            }
        }
        public int Suit {
            get { return _suit; }
            set
            {
                bool validSuit = false;
                if (Suit > 0)
                {
                    if (Suit < 14)
                    {
                        validSuit = true;
                    }
                }
                _suit = Suit;
            }
    }
}
