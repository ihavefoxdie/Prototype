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
            LargeMug clone = this.MemberwiseClone() as LargeMug;
            clone.MugSize = new()
            {
                Height = this.MugSize.Height,
                Radius = this.MugSize.Radius
            };
            return clone;
        }
        public void Drink()
        {
            Empty = true;
        }
    }
}
