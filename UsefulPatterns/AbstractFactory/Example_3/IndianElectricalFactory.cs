namespace UsefulPatterns.AbstractFactory.Example_3
{
    public class IndianElectricalFactory : IElectricalFactory
    {
        public IFan GetFan()
        {
            return new IndianFan();
        }

        public ITubeLight GetTubeLight()
        {
            return new IndianTubeLight();
        }
    }
}