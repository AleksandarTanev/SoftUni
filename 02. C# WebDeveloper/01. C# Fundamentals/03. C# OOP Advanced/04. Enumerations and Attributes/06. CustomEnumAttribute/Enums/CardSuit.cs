﻿namespace _06.CustomEnumAttribute.Enums
{
    using Atributes;

    [TypeAttribute("Enumeration", "Suit", "Provides suit constants for a Card class.")]
    public enum CardSuit
    {
        Clubs = 0,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}
