using System;
using UsefulPatterns.AbstractFactory.Example_1.Continents;

namespace UsefulPatterns.AbstractFactory.Example_1
{
    public class AnimalsAbstractFactoryStarter
    {
        public void Run()
        {
            Console.WriteLine("Animals and continents factories");

            ContinentFactory africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadKey();
        }
    }
}