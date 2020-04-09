namespace UsefulPatterns.Decorator.Example_1
{
    public class Decorator : RestaurantDish
    {
        protected readonly RestaurantDish Dish;

        public Decorator(RestaurantDish dish)
        {
            this.Dish = dish;
        }

        public override void Display()
        {
            this.Dish.Display();
        }
    }
}