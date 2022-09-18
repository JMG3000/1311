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
            DisplayBikeStats(Moto1);
            //GetBikeInfo(Moto1);
            //Motorcycle Moto2 = new Motorcycle();
            //GetBikeInfo(Moto2);
            //DisplayBikeStats(Moto1);
            //DisplayBikeStats(Moto2);
        }
        private static void DisplayBikeStats(Motorcycle Moto)
        {
            WriteLine("Motorcycle Name: {0}", Moto.BikeName);
            WriteLine("Motorcycle Name: {0}", Moto.BikeYear);
            WriteLine("Motorcycle Name: {0}", Moto.MaxSpeed);
        }
        private static void GetBikeInfo(Motorcycle NewMoto)
        {
            WriteLine("Enter the make and/or model of bike >>");
            NewMoto.BikeName = ReadLine();
            WriteLine("Enter the year of the bike >>");
            NewMoto.BikeYear = Convert.ToInt32(ReadLine());
            WriteLine("Enter the max speed of the bike >>");
            NewMoto.MaxSpeed = Convert.ToInt32(ReadLine());
        }
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
