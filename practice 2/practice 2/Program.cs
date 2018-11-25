using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fido
{


    class Dog
    {
        public void bark(string dogsName)
        {
            Console.WriteLine(dogsName + " is Barking");
        }

        public void doTrick(string dogsName)
        {
            Console.WriteLine("{0} is so smart!  {0} is fetching");
        }
    }

    class Program
    {
        private static int trickName;

        static void Main(string[] args)
        {
            Dog fido = new Dog();

            fido.bark("Fido");
            fido.doTrick("Fido");
            Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", fido, trickName); ;
            Console.ReadKey();

        }
    }
}