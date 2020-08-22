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
            myFamily.Add("grandmother", new Dictionary<string, string>() { { "name", "Ana" }, { "age", "84" } });
            myFamily.Add("grandfather", new Dictionary<string, string>() { { "name", "Pavel" }, { "age", "92" } });

            //just to test - the following way to initialize the Dictionary items works ... :
            //myFamily.Add("grandfather", new Dictionary<string, string>() { { "Pavel", "92" } });

            foreach (var (relation, details) in myFamily)
            {
                //string relationDetails = string.Join(",", details);
                //Console.WriteLine($"{relationDetails} is my {relation} and is {relationDetails} years old.");
                string relativeName = "";
                string relativeAge = "";

                foreach (var (entry1, entry2) in details)
                {
                    if (entry1 == "name")
                    {
                        relativeName = entry2;
                    }
                    else if (entry1 == "age")
                    {
                        relativeAge = entry2;
                    }
                }
                Console.WriteLine($"{relativeName} is my {relation} and is {relativeAge} years old.");

            }
        }
    }
}
