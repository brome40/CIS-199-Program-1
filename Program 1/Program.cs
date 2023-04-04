//Grading ID: R7828
//Program 1
//Due 9/22/2020
//CIS 199-01
//This program calculates and outputs the square yards and costs (material, underlayment, labor, and total) of each room the flooring company works on. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double width; //maximun width in feet
            double length; //maximum length in feet
            double woodPrice; //price per square yard of the material
            double sqYards; //area of the room in square yards
            double materialCost; //cost of hardwood plus the 10% waste bonus
            double underlayCost; //cost of the underlayment
            double laborCost; //cost of labor, including a bonus if it was the first room of the job
            double totalCost; //sum of material, underlayment, and labor costs 
            int    underlay; //value representing if underlayment was needed for the job
            int    firstroom; //value representing if this was the first room, and if the bonus should be applied

            const double SQUAREFT_TO_SQUAREYD = 9.0; //constant to easily convert from square feet to square yards
            const double FIRSTROOM_BONUS = 50.00; //50 dollar bonus for the first room of the job
            const double WASTE_RATE = 1.10; //10 percent bonus material cost as the waste rate
            const double UNDERLAY_COST = 4.25; //cost per square yard of the underlayment
            const double LABOR_COST = 3.25; //cost per square yard of the labor

            //This part of the program contains a series of prompts, the entered values are then stored as variables. 
            WriteLine("Welcome to the EZ-Hardwood Flooring Estimator");
            WriteLine();
            Write("Enter the maximum width of the room (in feet):");
            width = double.Parse(ReadLine());
            Write("Enter the maximum length of the room (in feet):");
            length = double.Parse(ReadLine());
            Write("Enter the hardwood price (per sq. yard):");
            woodPrice = double.Parse(ReadLine());
            Write("Enter if underlayment is needed (1 = YES, 0 = NO):");
            underlay = Int32.Parse(ReadLine());
            Write("Is this the first room? (1 = YES, 0 = NO):");
            firstroom = Int32.Parse(ReadLine());
            WriteLine();

            //Calculations taking into account the entered variable values
            sqYards = length * width / SQUAREFT_TO_SQUAREYD;
            materialCost = sqYards * woodPrice * WASTE_RATE;
            underlayCost = sqYards * UNDERLAY_COST;
            laborCost = sqYards * LABOR_COST;

            if(underlay == 0) 
                underlayCost = 0; //underlayment cost is removed if no underlayment was required 
            if(firstroom == 1)
                laborCost += FIRSTROOM_BONUS; //bonus is added to labor cost if it's the first room of the job

            totalCost = materialCost + underlayCost + laborCost;

            //Calculated values are outputed to the console
            WriteLine($"Sq. Yards Needed     {sqYards:F1}");
            WriteLine($"Hardwood Cost:       {materialCost:C}");
            WriteLine($"Underlayment Cost:   {underlayCost:C}");
            WriteLine($"Labor Cost:          {laborCost:C}");
            WriteLine($"Total Cost:          {totalCost:C}");

        }
    }
}
