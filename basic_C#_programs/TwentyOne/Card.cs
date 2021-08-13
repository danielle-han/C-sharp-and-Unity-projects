using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //constructor
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        //properties
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}