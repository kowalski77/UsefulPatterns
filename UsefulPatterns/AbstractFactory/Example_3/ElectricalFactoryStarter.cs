using System;

namespace UsefulPatterns.AbstractFactory.Example_3
{
    public class ElectricalFactoryStarter
    {
        public void Run()
        {
            IElectricalFactory electricalFactory = new IndianElectricalFactory();
            IFan fan = electricalFactory.GetFan();
            fan.SwitchOn();

            Console.ReadKey();
        }
    }
}