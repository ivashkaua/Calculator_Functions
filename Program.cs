using System;

namespace _04_Calculator_via_Functions
{
    class Program
    {
        static void Calculator()
        {

            Console.WriteLine("Hello!");
            Console.WriteLine("Book value \"a\"");
            double value_a = ReadLine();
            Console.WriteLine("Book value \"b\"");
            double value_b = ReadLine();
            Console.WriteLine("Number of decimal places");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Book operator +, -, * or /");
            string _operator = Console.ReadLine();
            switch (_operator)
            {
                case "+":
                    Sum(value_a, value_b, r);
                    break;
                case "-":
                    Diff(value_a, value_b, r);
                    break;
                case "*":
                    Multiplication(value_a, value_b, r);
                    break;
                case "/":
                    Division(value_a, value_b, r);
                    break;
                default:
                    Console.WriteLine("You entered an unknown operator");
                    break;

            }
            Console.ReadLine();
            Console.Clear();
        }

        static double Sum(double a, double b, int r)
        {
            double result = Math.Round(a + b,r);
            Console.WriteLine("Your result is " + result);
            return result;
        }

        static double Diff(double a, double b, int r)
        {
            double result = Math.Round(a - b,r);
            Console.WriteLine("Your result is "+ result);
            return result;
        }

        static double Multiplication(double a, double b, int r)
        {
            double result = Math.Round(a * b,r);
            Console.WriteLine("Your result is "+ result);
            return result;
        }

        static double Division(double a, double b, int r)
        {
            double result = Math.Round(a / b,r);
            Console.WriteLine("Your result is "+ result);
            return result;
        }

        static double ReadLine()
        {
            double booking = double.Parse(Console.ReadLine());
            return booking;

        }
        static void Main(string[] args)
        {
            while(true)
            Calculator();
        }
    }
}
