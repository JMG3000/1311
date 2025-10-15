using System;
using static System.Console;

namespace Garrett_Jacob_M_1311_Motorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle Moto1 = new Motorcycle();
            Moto1.BikeName = "Honda";
            Moto1.BikeYear = 2000;
            Moto1.MaxSpeed = 185;
            Moto1.currentspeed = 0
            Moto1.currentBikeWeight = 650; 

        }


// Function to print motorcycle stats to the screen
        private static void DisplayBikeStats(Motorcycle Moto)
        {
            WriteLine("Motorcycle Name: {0}", Moto.BikeName);
            WriteLine("Motorcycle Name: {0}", Moto.BikeYear);
            WriteLine("Motorcycle Name: {0}", Moto.MaxSpeed);
        }

// Function to get motorcycle stats from user input
        private static void GetBikeInfo(Motorcycle NewMoto)
        {
            WriteLine("Enter the make and/or model of bike >>");
            NewMoto.BikeName = ReadLine();
            WriteLine("Enter the year of the bike >>");
            NewMoto.BikeYear = Convert.ToInt32(ReadLine());
            WriteLine("Enter the max speed of the bike >>");
            NewMoto.MaxSpeed = Convert.ToInt32(ReadLine());
        }

// Function to set the bikes speed to zero.
// add parameter for bikes weight and add an algorithm to slow down the bike based on its speed and weight
        private static int StopBike(int currentspeed)
        {
            currentspeed = 0;
            return currentspeed;
        }
        class Motorcycle
        {
            private int maxspeed;
            private string bikename;
            private int bikeyear;
            private int currentspeed;
            private int currentBikeWeight;


// add functions for increasing speed, decreasing speed, calculating acceleration 

            public int CurrentSpeed
            {
                get
                {
                    return currentspeed;
                }
            }
            public int BikeYear
            {
                get
                {
                    return BikeYear;
                }
                set
                {
                    bikeyear = value;
                }
            }
            public int MaxSpeed
            {
                get
                {
                    return maxspeed;
                }
                set
                {
                    maxspeed = value;
                }
            }
            public string BikeName
            {
                get
                {
                    return bikename;
                }
                set
                {
                    bikename = value;
                }
            }
        }
    }
}
