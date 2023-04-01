using System;
using Interface;


namespace MinorClasses
{
    public class LargeMug : IMug
    {
        public LargeMug(int height, int radius)
        {
            MugSize = new();
            Empty = false;
            MugSize.Height = height;
            MugSize.Radius = radius;
        }
        public Size MugSize { get; set; }
        public bool Empty { get; set; }
        public IMug ShallowCopy()
        {
            return MemberwiseClone() as LargeMug;
        }
        public IMug DeepCopy()
        {
            LargeMug clone = new(MugSize.Height, MugSize.Radius)
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
