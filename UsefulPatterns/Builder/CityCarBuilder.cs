namespace UsefulPatterns.Builder
{
    public class CityCarBuilder : ICarBuilder
    {
        private ICar car;

        public CityCarBuilder()
        {
            this.Reset();
        }

        public ICarBuilder AddExtraPower()
        {
            this.car.IncreasePower(10);

            return this;
        }

        public ICarBuilder ChangeEngine()
        {
            this.car.ChangeEngine(Engine.RearWheel);

            return this;
        }

        public ICar Build()
        {
            var finishedCar = this.car;
            this.Reset();

            return finishedCar;
        }

        private void Reset()
        {
            this.car = new Car(Engine.FrontWheel);
        }
    }
}