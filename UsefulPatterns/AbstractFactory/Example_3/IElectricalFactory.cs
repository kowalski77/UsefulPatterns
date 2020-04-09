namespace UsefulPatterns.AbstractFactory.Example_3
{
    public interface IElectricalFactory
    {
        IFan GetFan();
        ITubeLight GetTubeLight();
    }
}