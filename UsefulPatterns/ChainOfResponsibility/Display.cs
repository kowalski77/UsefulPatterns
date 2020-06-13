using System;

namespace UsefulPatterns.ChainOfResponsibility
{
    public class Display
    {
        public void Print(int number, Label label)
        {
            if (!string.IsNullOrEmpty(label.Value))
            {
                Console.WriteLine($"Number: {number} is {label.Value}");
            }
        }
    }
}