using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExcercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("weight in kg? ");
            //double w = double.Parse(Console.ReadLine());
            //Console.Write("height in m? ");
            //double h = double.Parse(Console.ReadLine());

            //Console.WriteLine($"your BMI is {One (w,h)}");
            //Console.WriteLine(Two(One(w, h)));

            //Console.Write("what is the number of the ending cent? ");
            //Console.WriteLine(Three(double.Parse(Console.ReadLine())));

            //Console.WriteLine("which language do you want");
            //Console.WriteLine("1. Maori");
            //Console.WriteLine("2. Japanese");
            //Console.WriteLine("3. Hindi");
            //Console.WriteLine("4. French");
            //Console.WriteLine("5. Samoan");
            //Console.Write("enter a number. ");
            //Console.WriteLine(Four(int.Parse(Console.ReadLine())));


            Console.Write("first number? ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("second number? ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("operation? ");
            string operation = Console.ReadLine();
            Console.WriteLine(Five(first, second, operation));

            Console.ReadKey();
        }

        public static double One(double w, double h)
        {
            return w / (h * h);
        }

        public static string Two(double d)
        {
            if (d < 18.5)
            {
                return "underweight. eat more.";
            }
            else if (d >= 18.5 && d < 25)
            {
                return "normal weight. good jpb.";
            }
            else if (d >= 25 && d < 30)
            {
                return "overweight. do some ecercise";
            }
            else
            {
                return "obese. not good";
            }
        }

        public static string Three(double d)
        {
            switch (d)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "down";
                case 6:
                case 7:
                case 8:
                case 9:
                    return "up";
                case 0:
                    return "zero";
                default:
                    return "error";
            }
        }

        public static string Four(int i)
        {
            string[] sl = { "Kia Ora", "Kon'Nichiwa", "Namaste", "Bonjour", "Talofa" };
            return sl[i - 1];
        }

        public static int Five(int i, int ii, string s)
        {
            switch (s)
            {
                case "+":
                    return i + ii;
                case "-":
                    return i - ii;
                case "*":
                    return i * ii;
                case "/":
                    return i / ii;
                case "%":
                    return i % ii;
                default:
                    return 0;
            }
        }
    }


}
