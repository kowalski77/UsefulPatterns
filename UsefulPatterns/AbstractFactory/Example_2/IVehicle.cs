namespace UsefulPatterns.AbstractFactory.Example_2
{
    public interface IVehicle
    {
        string GetInfo();
    }

    public class Bicycle : IVehicle
    {
        public string GetInfo()
        {
            return "For 1 person";
        }
    }

    public class Tandem : IVehicle
    {
        public string GetInfo()
        {
            return "For 2 people";
        }
    }

    public class MotorBike : IVehicle
    {
        public string GetInfo()
        {
            return "With motor, for one";
        }
    }

    public class Car : IVehicle
    {
        public string GetInfo()
        {
            return "With motor, up to 5 people";
        }
    }
}