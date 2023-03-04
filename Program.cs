using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
            //test pack initialisation
            Pack pack = new Pack();

            //test first shuffle
            pack.shuffleCardPack(0);

            //test second shuffle
            pack.shuffleCardPack(1);

            //test one card deal
            pack.deal();

            //test several card deal
            pack.dealCard(3);

        }
    }
}
