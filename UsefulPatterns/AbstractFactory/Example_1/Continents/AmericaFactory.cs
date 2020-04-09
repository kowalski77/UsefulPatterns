using UsefulPatterns.AbstractFactory.Example_1.Animals;

namespace UsefulPatterns.AbstractFactory.Example_1.Continents
{
    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}