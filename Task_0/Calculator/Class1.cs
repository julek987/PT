using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0) { 
                return x / y;
            }
            else{
                throw new ArgumentException("You cannot divide by zero!");
            }
            
        }

    }
}
