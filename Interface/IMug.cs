using System;

namespace Interface
{
    public interface IMug
    {
        IMug ShallowCopy();
        IMug DeepCopy();
        void Drink();
    }
}
