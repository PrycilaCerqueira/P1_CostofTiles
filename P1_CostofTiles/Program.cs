using System;

namespace P1_CostofTiles // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double costPerUnitOfTile;
            double totalCost;

            Console.WriteLine("Find the Cost of Tile to Cover W x L Floor");
            
            Console.Write("Enter the length in square meters: ");
            length = Int32.Parse(Console.ReadLine());
            
            Console.Write("Enter the width in square meters: ");
            width = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the unit cost per tile in square meters: ");
            costPerUnitOfTile = Int32.Parse(Console.ReadLine());

            totalCost = (length * width) * costPerUnitOfTile;

            Console.WriteLine($"The total cost is ${totalCost}");
        }
    }
}