using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator
{
    internal class Dog
    {
        public string Name  { get; set; }
        public bool IsNaughtDog { get; set; }

        public Dog(string name, bool isNaughtDog)
        {
            Name = name;
            IsNaughtDog = isNaughtDog;
        }

        public void  GiveThreat(int nubmerOfThreats)
        {
            Console.WriteLine($"Dog: {Name} said wuff {nubmerOfThreats} times!");
        }
    }
}
