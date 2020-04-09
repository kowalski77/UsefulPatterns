using UsefulPatterns.AbstractFactory.Example_1.Animals;

namespace UsefulPatterns.AbstractFactory.Example_1.Continents
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}