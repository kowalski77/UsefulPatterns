using System;
using System.Collections.Generic;

namespace UsefulPatterns.Decorator.Example_1
{
    public class Available : Decorator
    {
        private int numAvailable;
        private readonly List<string> customers = new List<string>();

        public Available(RestaurantDish dish, int numAvailable) : base(dish)
        {
            this.numAvailable = numAvailable;
        }

        public void OrderItem(string name)
        {
            if (this.numAvailable > 0)
            {
                this.customers.Add(name);
                this.numAvailable--;
            }
            else
            {
                Console.WriteLine("\nNot enough ingredients for " + name + "'s order!");
            }
        }

        public override void Display()
        {
            base.Display();

            foreach (var customer in this.customers)
            {
                Console.WriteLine("Ordered by " + customer);
            }
        }
    }
}