using System;

namespace IEnumerable_IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtDog)
                {
                    dog.GiveThreat(2);
                }
                else
                {
                    dog.GiveThreat(1);
                }
            }   
        }
    }
}
