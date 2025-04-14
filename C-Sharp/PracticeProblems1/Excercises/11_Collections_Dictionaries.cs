// ---------------------------------------------
// EXERCISE 11: Inheritance and Method Overriding
// Topics: inheritance, base class, override
// ---------------------------------------------

namespace Refresher
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    public class Exercise11
    {
        public static void Run()
        {
            Console.WriteLine("== Inheritance and Method Overriding ==\n");

            // TODO: Create instances of Animal and Dog and call Speak on each
        }
    }
}
