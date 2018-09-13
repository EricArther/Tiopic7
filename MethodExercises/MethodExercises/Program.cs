using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(One(-7));

            //Console.Write("input the distance in miles. ");
            //Console.WriteLine($"{Two(decimal.Parse(Console.ReadLine()))} km");

            //Console.Write("enter the radius. ");
            //int radius = int.Parse(Console.ReadLine());
            //Console.WriteLine($"the circumference is {ThreeOne(radius)}");
            //Console.WriteLine($"the area is {ThreeTwo(radius)}");

            Console.Write("enter a number. ");
            Console.WriteLine(Four(int.Parse(Console.ReadLine())));

            Console.ReadKey();
        }

        public static int One(int i)
        {
            return i * -1;
        }

        public static decimal Two(decimal d)
        {

            return d / (decimal)0.62137;
            
        }

        public static double ThreeOne(double d)
        {
            return d * 3.1416 * 2;
            
        }

        public static double ThreeTwo(double d)
        {
            return d * d * 3.1416;
            
        }

        public static string Four(int i)
        {
            string[] week = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            return week[i - 1];
        }
    }
}
