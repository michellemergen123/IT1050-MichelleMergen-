using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fido
{
    /*Scope is located in public.  Public defines the methods scope.
     * Static v non-static.  Determines whether we can call it from the same file as main method or without creating an object.  This example is static and can be called without creating another object in the class.
     * Return:  returns height *width, determines the type of value returned, if nothing was specified there would be no return value
     * Parameters:  The area within the (), it states the name and type of parameters-double height, double width.  
     * Method Body:  The area that must be executed:  return height * width.
     * 
     * The difference between a user-defined method and a method that is provided with a framework is ThreadStaticAttribute is that user-defined methods are custom methods that we write while framework provided 
     * methods provide meaninful methods for a platform or framework.  They are provided by the framework and can be reused.  
     * 
     * Static and non-static methods:  A static method does not have access to any of the objects non-static fields while non-static methods can access all non-static fields of an object.
     * 
method that applies to the class*/

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
