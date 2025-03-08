using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Fraction
    {
        public int Divident;
        public int Diviser;

        public Fraction (int divident, int diviser)
        {
            this.Divident = divident;
            this.Diviser = diviser;
        }
        public double Calculate()
        {
         
         
                double results;
            results = Diviser / Divident;
            return results;
            
        }
        public void Display()
        {
            double result = Calculate();
            Console.WriteLine($"Result: {Diviser}/{Divident}={result}");
        }
    }
}
