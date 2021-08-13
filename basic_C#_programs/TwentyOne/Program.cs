using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck = Shuffle(deck, 3); //Shuffle(deck: deck, times: 3) //named parameters.

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //public - access anywhere
        //static - dont want to create object of class before calling this method
        //Deck - type it is returning (above returns nothing - void
        public static Deck Shuffle(Deck deck, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
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
