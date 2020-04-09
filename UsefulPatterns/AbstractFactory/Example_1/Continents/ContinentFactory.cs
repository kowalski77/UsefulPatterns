using UsefulPatterns.AbstractFactory.Example_1.Animals;

namespace UsefulPatterns.AbstractFactory.Example_1.Continents
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}