using UsefulPatterns.AbstractFactory.Example_1.Animals;
using UsefulPatterns.AbstractFactory.Example_1.Continents;

namespace UsefulPatterns.AbstractFactory.Example_1
{
    public class AnimalWorld
    {
        private readonly Herbivore herbivore;
        private readonly Carnivore carnivore;

        public AnimalWorld(ContinentFactory continentFactory)
        {
            this.herbivore = continentFactory.CreateHerbivore();
            this.carnivore = continentFactory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            this.carnivore.Eat(this.herbivore);
        }
    }
}