using System;

namespace MeasurementOfRoom
{
    class Program
    {
        static void Main(string[] args)
        {

        begin_label:

            double length, width, height = 0.0;
            double volume, area, perimeter = 0.0;

            Console.Clear();

            Console.WriteLine("\t\tWelcome to Grand Circus' Room Detail Generator!\n\n");

            //User input length
            Console.Write("\n\n\nRoom length:  ");

            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.Write("\n\aThere was an error.\n\nEnter a valid decimal as room length:  ");
            }

            //User input width
            Console.Write("\n\n\nRoom width:  ");

            while (!double.TryParse(Console.ReadLine(), out width))
            {
                Console.Write("\n\aThere was an error.\n\nEnter a valid decimal as room width:  ");
            }

            //User input height
            Console.Write("\n\n\nRoom height:  ");

            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("\n\aThere was an error.\n\nEnter a valid decimal as room width:  ");
            }

            area = length * width;
            perimeter = (length * 2) + (width * 2);
            volume = area * height;

            Console.WriteLine("\n\n\nL: {0}   W: {1}    H: {2}" +
                "\n\n\nArea: {3} units square\n\nPerimeter: {4} unit\n\nVolume: {5} units cube\n\n",
                length, width, height, area, perimeter, volume);

            Console.Write("Enter <N> to quit: ");

            if (Console.ReadLine().ToLower() != "n")
            {
                goto begin_label;
            }
        }
    }
}
