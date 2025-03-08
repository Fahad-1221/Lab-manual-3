using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Trip
    {
        public string Destination;
        public double DTravelled;
        public double GasCost;
        public int NumGallons;
        double Cost1;
        double Cost2;

        public Trip()
        {
            Destination = "Lahore";
            DTravelled = 167;
            GasCost = 12000;
            NumGallons = 23;

        }
        public void Cost()
        {
            Cost1 = NumGallons/ DTravelled;
            Cost2 = GasCost / NumGallons;
        }
        public void Display()
        {
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Total Travelled Distance: {DTravelled}");
            Console.WriteLine($"Total Cost of Gas: {GasCost }");
            Console.WriteLine($"Total number of Gallons: {NumGallons }");
            Cost();
            Console.WriteLine($"Miles per Gallon: {Cost1}");
            Console.WriteLine($"Cost per Mile: {Cost2}");
        }
    }
}
