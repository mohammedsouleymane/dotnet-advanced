using System;

namespace ClassLibrary
{
    public class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Divide(int a, int b)
        {
            if(b == 0)
                throw new System.DivideByZeroException();   
            return System.Math.Round((double)a / b, 2);
        }
    }
}
