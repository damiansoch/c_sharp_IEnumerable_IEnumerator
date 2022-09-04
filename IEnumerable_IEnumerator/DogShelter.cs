using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator
{
    internal class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper",false),
                new Dog("Sif",true),
                new Dog("Oreo",false),
                new Dog("Pixel",true),
                new Dog("Luna",false),

            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)dogs).GetEnumerator();
        }
    }
}
