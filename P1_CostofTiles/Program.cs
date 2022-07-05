using System;

namespace P1_CostofTiles // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuOption;
            double length;
            double width;
            double height;
            double sum;
            double area;
            double costPerUnitOfTile;
            double totalCost;

            Console.Write("Find the Cost of Tile to Cover the Floor \n\n Enter the length in meters: ");
            length = Double.Parse(Console.ReadLine());

            Console.Write(" Enter the width in meters: ");
            width = Double.Parse(Console.ReadLine());

            Console.Write(" Enter the height in meters: ");
            height = Double.Parse(Console.ReadLine());

            Console.Write(" Enter the unit cost per tile in meters: ");
            costPerUnitOfTile = Double.Parse(Console.ReadLine());

            Console.Write("\n What is the area shape you would like to calculate? \n 1) Triangle \n 2) Trapezoid \n 3) Rectangle \n Enter your option number here: ");
            menuOption = Int32.Parse(Console.ReadLine());
            
            switch (menuOption)
            {
                // Calculation matches with https://www.calculator.net/area-calculator.html
                case 1: //Triangle
                    sum = (length + width + height) / 2;
                    area = Math.Sqrt(sum * (sum - length) * (sum - width) * (sum - height));
                    totalCost = Math.Round((area * costPerUnitOfTile),2);
                    Console.WriteLine($"\n The total cost for covering a Tringle area of {area} square meters is ${totalCost}.");
                    break;

                case 2: //Trapezoid
                    area = ((length + width) / 2) * height;
                    totalCost = Math.Round((area * costPerUnitOfTile),2);
                    Console.WriteLine($"\n The total cost for covering a Trapezoid area of {area} square meters is ${totalCost}.");
                    break;

                case 3: //Rectangle
                    area = length * width;
                    totalCost = Math.Round((area * costPerUnitOfTile),2);
                    Console.WriteLine($"\n The total cost for covering a Rectangle area of {area} square meters is ${totalCost}.");
                    break;
                   
                default: //Invalid Option
                    Console.WriteLine("\n Invalid option. \n Try again!");
                    break;
            }

        }
    }
}