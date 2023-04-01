using System;
using Interface;


namespace MinorClasses
{
    public class KidsMug: IMug
    {
        public Colors Color { get; set; }
        public KidsMug(int r, int g, int b)
        {
            Empty = false;
            Size = 5;
            Color = new();
            Color.R = r;
            Color.G = g;
            Color.B = b;
        }
        public int Size { get; set; }
        public bool Empty { get; set; }
        public IMug ShallowCopy()
        {
            return MemberwiseClone() as KidsMug;
        }
        public IMug DeepCopy()
        {
            KidsMug clone = MemberwiseClone() as KidsMug;
            clone.Color = new()
            {
                R = Color.R,
                G = Color.G,
                B = Color.B
            };
            return clone;
        }

        public void Drink()
        {
            Empty = true;
        }
    }
}
