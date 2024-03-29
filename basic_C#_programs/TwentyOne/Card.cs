﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        //properties
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()
        {
           return string.Format("{0} of {1}", Face, Suit);
        }
    }

    public enum Suit //default value assigned starting from 0
    {
        Clubs,//=4, can assign own values
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}