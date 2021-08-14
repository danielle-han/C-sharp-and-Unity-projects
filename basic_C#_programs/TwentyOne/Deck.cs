using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            
            for (int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //casting Face
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }

        public List<Card> Cards { get; set; }

        //public - access anywhere
        //static - dont want to create object of class before calling this method
        //Deck - type it is returning (above returns nothing - void
        public void Shuffle( int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
               Cards = TempList;
            }
          
        }

        //out paras go before optional ones. 
        //out paras: throw value out to var defined
        //ex: 
        //int TimesShuffled = 0;
        //Shuffle (Deck deck, out int TimesShuffled, int times = 1) {
        //TimesShuffled = 0;
        //....(in loop) TimesShuffled++;}
        //sends timesShuffled value to var TimesShuffled outside of method.

        //overloading method
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
