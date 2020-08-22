using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("oldest brother", new Dictionary<string, string>() { { "name", "Cristian" }, { "age", "51" } });
            myFamily.Add("middle brother", new Dictionary<string, string>() { { "name", "Bogdan" }, { "age", "44" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Maria" }, { "age", "75" } });


            foreach (var (relation, details) in myFamily)
            {
                string relativeName = "";
                string relativeAge = "";

                foreach (var (entry1, entry2) in details)
                {
                    //if (entry1 == "name")
                    if(entry1.Equals("name", StringComparison.OrdinalIgnoreCase)) //Anca: better option because thins finds "name" regardless of its capitalization!!
                    {
                        relativeName = entry2;
                    }
                    //else if (entry1 == "age")
                    else if(entry1.Equals("age", StringComparison.OrdinalIgnoreCase))
                    {
                        relativeAge = entry2;
                    }
                }
                Console.WriteLine($"{relativeName} is my {relation} and is {relativeAge} years old.");
            }

            //Another option: --note that the key names have to be exact in this case- so if one of the items had "Name" instead of "name", it would not work!
            foreach (var (relation, details) in myFamily)
            {
                Console.WriteLine($"{details["name"]} is my {details["age"]}-year old {relation}.");
            }

            //and another option with .Select()!!
            myFamily.Select((role) => $"{role.Value["name"]} is my {role.Value["age"]} year old {role.Key}!!!!");
        }
    }
}
