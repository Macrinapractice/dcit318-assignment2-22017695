using System;

namespace InheritanceAndOverriding
{
    // Base class
    class Animal
    {
        // Base method marked virtual so derived classes can override it
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class: Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class: Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            var animal = new Animal();
            var dog = new Dog();
            var cat = new Cat();

            // Call MakeSound on each
            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
