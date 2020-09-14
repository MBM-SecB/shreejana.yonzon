using System.Collections.Generic;
using System;

namespace LearningClasses

{
    public class Generic
    {
        //using list
        void LearnigList()
        {
            List<string> names = new List<string> { "Shree" };

            names.Add("Shree");
            names.Add("Shree");
            names.Add("Shree");
            names.Add("Shree");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
        void LerningDictionary()
        {
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
            countryCapitals.Add("Nepal", "Kathmandu");
            countryCapitals.Add("India", "Delhi");

            foreach (var countryCapital in countryCapitals)
            {
                Console.WriteLine(countryCapital.Value);
            }
        }
    }
}