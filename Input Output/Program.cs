using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int radius = Input();

            // Process
            float volume = Process(radius);

            // Output
            Output(volume);

            Console.ReadLine();
        }

        static int Input()
        {
            Console.Write("Enter an integer number for the sphere radius: ");
            int radius = int.Parse(Console.ReadLine());

            return radius;
        }

        static float Process(int radius)
        {
            return (float)((4 / 3) * Math.PI * Math.Pow(radius, 3));
        }

        static void Output(float volume)
        {
            Console.WriteLine($"The volume of the sphere is: {volume}");
        }
    }
}
