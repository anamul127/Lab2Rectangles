using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectange Area = Length * Width
            //Rectangle Perimeter = Length(2) + Width(2)
            //Rectangle Volume = Length * Width * Height

            while (true)
            {
                Console.WriteLine("Please enter the length of the rectangle.");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the rectangle.");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of the rectangle.");
                double height = double.Parse(Console.ReadLine());

                double area = width * length;
                double perimeter = 2 * (width + length);
                double volume = length * width * height;

                Console.WriteLine("The Area of your rectangle is {0}", +area);
                Console.WriteLine("The Perimeter of your rectangle is {0}", +perimeter);
                Console.WriteLine("The Height of your rectangle is {0}", +volume);

                Console.WriteLine("\nWould you like to continue? (y/n)");
                string response;
                response = Console.ReadLine();

                if (response == "y")
                {
                    Console.WriteLine("");
                    continue;
                }
                else if (response == "n")
                {
                    break;
                }
            }

        }
    }
}
