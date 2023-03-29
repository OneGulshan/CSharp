using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPS
{
    enum Planets //Like gender staticly items bind thats are not changed
    {
        Mercury = 1, //We can set Enums Values also, by it self.
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }

    enum PlanetRadius //Radius of each planet in km
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25363,
        Neptune = 24622,
        Pluto = 1188
    }    

    class Planet
    {
        public static void PrintAllPlanets()//Iterate Enums
        {
            foreach (string name in Enum.GetNames(typeof(Planets)))
            {
                Console.WriteLine(name);
            }
        }
    }

    class Enum2
    {
        public enum Shapes
        {
            Circle,
            Square
        }

        public void peri(int val, Shapes s1)
        {
            if (s1 == 0)
            {
                Console.WriteLine("Circumference of the circle is " + 2 * 3.14 * val);
            }
            else
            {
                Console.WriteLine("Perimeter of the square is " + 4 * val);
            }
        }
    }

    class Enums
    {
        //static void Main()
        //{
        //    Console.WriteLine(Planets.Mercury + " is a planet #" + (int)Planets.Mercury);
        //    Console.WriteLine(Planets.Pluto + " is a planet #" + (int)Planets.Pluto);

        //    string name = PlanetRadius.Earth.ToString();
        //    Console.WriteLine("planet: " + name);

        //    int radius = (int)PlanetRadius.Earth;
        //    Console.WriteLine("planet radius: " + radius + " km");

        //    double volume = Volume(PlanetRadius.Earth);
        //    Console.WriteLine("volume: " + volume + "km^3");

        //    List<Planets> planets = Enum.GetValues(typeof(Planets)).Cast<Planets>().ToList();
        //    Console.WriteLine(string.Join(Environment.NewLine/*OR"\n"*/, planets));

        //    Console.WriteLine();
        //    Planet.PrintAllPlanets();

        //    //-------------------------------------------------------------------

        //    Console.WriteLine();
        //    Enum2 enum2 = new Enum2();
        //    enum2.peri(3, Enum2.shapes.Circle);
        //    enum2.peri(4, Enum2.shapes.Square);
            
        //    Console.ReadLine();
        //}

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);//3 <- this is the power of 3, cast is required if implicitly not handled by compiler
            return volume;
        }
    }
}

//Enums are a special kind of class that contains a grouping of named integer constants pairs.
//we tend to use(उपयोग करते हैं) enums when we have values that we know will not change.
//to get the integer value from an enum item, you must explicitly convert to an int.
//name = integer

