using System;

namespace Roland.BaseMath
{
    public class Math
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multi(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Div(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentNullException("num2");
            }
            else
            {
                return num1 / num2;
            }
            
        }
    }
}
