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

            Console.Write("\n What is the area shape you would like to calculate? \n 1) Triangle \n 2) Square \n 3) Rectangle \n Enter your option number here: ");
            menuOption = Int32.Parse(Console.ReadLine());
            
            switch (menuOption)
            { 
                case 1: //Triangle
                    area = (length * height) / 2;
                    totalCost = area * costPerUnitOfTile;
                    Console.WriteLine($"\n The total cost for covering a Tringle area of {area}m is ${totalCost}");
                    break;


            
            }


            //totalCost = (length * width) * costPerUnitOfTile;

            //Console.WriteLine($"The total cost is ${totalCost}");
        }
    }
}