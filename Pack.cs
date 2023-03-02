using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;
        private Random _random;
        private int _i = 0;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();

            for (int Suit = 1; Suit <5; Suit++)
            {
                for (int Value  = 1; Value < 14; Value++)
                {
                    pack.Add(new Card(Value, Suit));
                }
            }
            _random = new Random();
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 0)
            {
                Random random = new Random();
                for (int x = 0; x < 50; x++)
                {
                    int y = random.Next(x + 1);
                    Card temp = _cards[x];
                    _cards[x] = _cards[y];
                    _cards[y] = temp;
                }
            }
            else if (typeOfShuffle == 1)
            {
                //split pack into 2
                List<Card> first = new List<Card>();
                List<Card> second = new List<Card>();

                first.AddRange(_cards.GetRange(0, 25));
                second.AddRange(second.GetRange(26, 51));

                //empty pack
                _cards.Clear();

                //alternate adding cards back into pack from both halves
                for (int x = 0;x < 50; x++)
                {
                    bool flipFlop = false;
                    if (flipFlop == false)
                    {
                        _cards.Add(first[0]);
                        first.RemoveAt(0);
                        flipFlop = true;
                    }
                    else
                    {
                        _cards.Add(second[0]);
                        second.RemoveAt(0);
                        flipFlop = false;
                    }
                }
            }
            else
            {
                //do nothing
            }
        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
