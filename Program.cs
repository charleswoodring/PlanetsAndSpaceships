using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            //Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            foreach (string planet in planetList)
            {
                // Console.WriteLine(planet);
            }
            // Create another List that contains that last two planet of our solar system.
            List<string> planetList2 = new List<string>() { "Uranus", "Neptune" };
            foreach (string planet2 in planetList2)
            {
                // Console.WriteLine(planet2);
            }

            // Combine the two lists by using AddRange().
            planetList.AddRange(planetList2); //add 2nd list to the end of first list

            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Earth"); //add Earth to 2nd index
            planetList.Insert(1, "Venus"); //add Venus to 2nd index (pushes Earth to 3rd)

            // Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto"); //remove Pluto by name
            planetList.Remove(0, 8); //remove Pluto by index

            foreach (string combinedPlanetList in planetList) // loop over each item and add to combined
            {
                Console.WriteLine(combinedPlanetList); // write combined to console
            }

            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = planetList.GetRange(0, 4); // create new list rocky from existing list
            foreach (string planet in rockyPlanets) // loops do not need a ;
            {
                Console.WriteLine(planet); //write to console
            }

        }
    }
}