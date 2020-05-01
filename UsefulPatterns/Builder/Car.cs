using System.Globalization;
using System.Text;

namespace UsefulPatterns.Builder
{
    public class Car : ICar
    {
        public Engine Engine { get; private set; }
        public double Power { get; private set; }

        public Car(Engine engine)
        {
            this.Engine = engine;
            this.Power = 100;
        }

        public void ChangeEngine(Engine engine)
        {
            this.Engine = engine;
        }

        public void IncreasePower(double value)
        {
            this.Power += value;
        }

        public string Debug()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder
                .Append("Engine: ")
                .AppendLine(this.Engine.ToString())
                .Append("Power: ")
                .AppendLine(this.Power.ToString(CultureInfo.InvariantCulture))
                .AppendLine();

            return stringBuilder.ToString();
        }
    }
}