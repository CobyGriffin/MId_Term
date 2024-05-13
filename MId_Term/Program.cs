using System.Drawing;
using System.Reflection.Metadata;
using System;
using System.ComponentModel.Design;

namespace MId_Term
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator();
            FinanceCalculator();
            GeometryCalculator();
            CartesianPlane();
        } //Main
        public static void Menu()
        {
            Console.WriteLine("What Calculator do you want to run?");
            Console.WriteLine("1 - Basic Calculator");
            Console.WriteLine("2 - Finance Calculator");
            Console.WriteLine("3 - Geometry Calculator");
            Console.WriteLine("4 - Cartesian Plane");

            string? userInput = Console.ReadLine();

            if (userInput == "1")
            {
                BasicCalculator();
            }
            else if (userInput == "2")
            {
                FinanceCalculator();
            }
            else if (userInput == "3")
            {
                GeometryCalculator();
            }
            else if (userInput == "4")
            {
                CartesianPlane();
            }
            else
            {
                Console.WriteLine("Thank you have a great day");
     
            }
        } //Menu

        public static void BasicCalculator()
        {
            Console.WriteLine("Welcome to Basic Calculator!");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            char? op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator!");
                    return;
            }

            Console.WriteLine("Result: " + result);

        } //BasicCalculator

        public static void FinanceCalculator()
        {
            Console.WriteLine("Welcome to Finance Calculator!");

            // Net Income

            Console.WriteLine("Net Income Calculation:");
            double income= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter yearly cost");
            double costs= Convert.ToDouble(Console.ReadLine());
            double netIncome = income - costs;
            Console.WriteLine("Net Income: " + FormatCurrency(netIncome));

            // Rule of 72

            Console.WriteLine("\nRule of 72 Calculation:");
            double rateOfInterest = Convert.ToDouble(Console.ReadLine());
            double yearsToDouble = 72 / rateOfInterest;
            Console.WriteLine("Years to double your money: " + yearsToDouble);

            // Net Worth

            Console.WriteLine("\nNet Worth Calculation:");
            double assets = Convert.ToDouble(Console.ReadLine());
            double liabilities = Convert.ToDouble(Console.ReadLine());
            double netWorth = assets - liabilities;
            Console.WriteLine("Net Worth: " + FormatCurrency(netWorth));
        }

        static double GetDoubleInput(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToDouble(Console.ReadLine());
        }

        static string FormatCurrency(double amount)
        {
            return string.Format("{0:C}", amount);

        }//FinanceCalculator

        public static void GeometryCalculator()
        {
            double side = Convert.ToDouble(Console.ReadLine());
            double area = side * side;
            double perimeter = 4 * side;
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }

        static void CalculateRectangle()
        {
            double length = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            double area = length * width;
            double perimeter = 2 * (length + width);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }

        static void CalculateCircle()
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Circumference: " + circumference);
        }

        static void CalculateRightCircularCone()
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double volume = (1.0 / 3.0) * Math.PI * radius * radius * height;
            Console.WriteLine("Volume: " + volume);
        }

        static double GetDoubleInput()
        {
            Console.WriteLine();
            return Convert.ToDouble(Console.ReadLine());

        }//GeometryCalculator

        public static void CartesianPlane()
        {
            Console.WriteLine("Welcome to Cartesian Plane Calculator!");

            double x, y;

            // Get user input for coordinates

            Console.Write("Enter the x-coordinate: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the y-coordinate: ");
            y = Convert.ToDouble(Console.ReadLine());

            // Check if the point is on the axes

            if (x == 0 && y == 0)
            {
                Console.WriteLine("The point is on the origin (0,0)");
            }
            else if (x == 0 || y == 0)
            {
                Console.WriteLine("The point is on one of the axes");
            }
            else
            {
                // Check which quadrant the point falls in

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("The point is in Quadrant I");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("The point is in Quadrant II");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("The point is in Quadrant III");
                }
                else
                {
                    Console.WriteLine("The point is in Quadrant IV");
                }
            }
        }//CartesianPlane
    }//Class
}//namespace





       
