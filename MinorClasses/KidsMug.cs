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
            Color = new()
            {
                R = r,
                G = g,
                B = b
            };
        }
        public int Size { get; set; }
        public bool Empty { get; set; }
        public IMug ShallowCopy()
        {
            return MemberwiseClone() as KidsMug;
        }
        public IMug DeepCopy()
        {
            KidsMug clone = new(Color.R, Color.G, Color.B)
            {
                Empty = this.Empty
            };

            return clone;
        }

        public void Drink()
        {
            Empty = true;
        }
    }
}
