using System;

namespace UsefulPatterns.AbstractFactory.Example_1.Animals
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}