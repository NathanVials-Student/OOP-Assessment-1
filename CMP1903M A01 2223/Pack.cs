using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        //Initialise the card pack here
        public static List<Card> pack = new List<Card>();
        private Random _random;
        private static int _i = 0;

        public Pack()
        {
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
                    Card temp = pack[x];
                    pack[x] = pack[y];
                    pack[y] = temp;
                }
                return true;
            }
            else if (typeOfShuffle == 1)
            {
                //split pack into 2
                List<Card> first = new List<Card>();
                List<Card> second = new List<Card>();

                first.AddRange(pack.GetRange(0, 26));
                second.AddRange(pack.GetRange(26, 26));

                //empty pack
                pack.Clear();

                //alternate adding cards back into pack from both halves
                bool flipFlop = false;
                for (int x = 0;x < 50; x++)
                {
                    if (flipFlop == false)
                    {
                        pack.Add(first[0]);
                        first.RemoveAt(0);
                        flipFlop = true;
                    }
                    else
                    {
                        pack.Add(second[0]);
                        second.RemoveAt(0);
                        flipFlop = false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Card deal()
        {
            //Deals one card
            Card card = pack[_i];
            _i++;
            return card;

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> deal = pack.GetRange(_i, amount);
            _i += amount;
            return deal;
        }
    }
}
