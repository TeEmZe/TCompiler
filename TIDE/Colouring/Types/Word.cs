﻿namespace TIDE.Colouring.Types
{
    public class Word
    {
        public Word(string value, int positionInWordArray, int position)
        {
            Value = value;
            PositionInWordArray = positionInWordArray;
            Position = position;
        }

        public int PositionInWordArray { get; }
        public string Value { get; }
        public int Position { get; }
    }
}