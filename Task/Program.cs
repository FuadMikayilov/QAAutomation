using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the x-coordinate of point A: ");
            double xA = double.Parse(Console.ReadLine());
            Console.Write("Enter the y-coordinate of point A: ");
            double yA = double.Parse(Console.ReadLine());
           

            Console.Write("Enter the x-coordinate of point B: ");
            double xB = double.Parse(Console.ReadLine());
            Console.Write("Enter the y-coordinate of point B: ");
            double yB = double.Parse(Console.ReadLine());
            

            Console.Write("Enter the x-coordinate of point C: ");
            double xC = double.Parse(Console.ReadLine());
            Console.Write("Enter the y-coordinate of point C: ");
            double yC = double.Parse(Console.ReadLine());
            

            Console.WriteLine("=================================================");

            double side1 = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
            double side2 = Math.Sqrt(Math.Pow(xC - xB, 2) + Math.Pow(yC - yB, 2));
            double side3 = Math.Sqrt(Math.Pow(xA - xC, 2) + Math.Pow(yA - yC, 2));

            
            string isEquilateral = "";
            string isIsosceles = "";
            string isRight = "";
            bool checkIsRight = side1 + side2 > side3 &&
                side1 + side3 > side2 &&
                side2 + side3 > side1;
            if (!(side1 == side2 && side2 == side3))
            {
                isEquilateral = "NOT";
            }

            if(!(side1 == side2 || side2 == side3 || side1 == side3))
            {
                isIsosceles = "NOT";
            }

            if (!checkIsRight)
            {
                isRight = "NOT";
            }
            Console.WriteLine("Length of AB is: '{0}'", side1);
            Console.WriteLine("Length of BC is: '{0}'", side2);
            Console.WriteLine("Length of CA is: '{0}'", side3);

            Console.WriteLine("============Result is in below...=================");

            Console.WriteLine("Triangle IS {0}'Equilateral'", isEquilateral);
            Console.WriteLine("Triangle IS {0}'Isosceles'", isIsosceles);
            Console.WriteLine("Triangle IS {0}'Right'", isRight);

            Console.WriteLine("===================================================");

            double perimeter = side1 + side2 + side3;
            Console.WriteLine("Perimeter: '{0}'", perimeter);

            Console.WriteLine("===================================================");

            Console.WriteLine($"Parity numbers in the range from 0 to {perimeter}:");
            for (double i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
