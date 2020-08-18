using System;
using System.Collections.Generic;
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

            foreach (var (relation, details) in myFamily)
            {
                foreach (var (name, age) in details)
                {
                    Console.WriteLine($"{name} is my {relation} and is {age[2]} years old.");

                    //ANCA - maybe I can find a predicate that cna help me get the values I need at the time I need them ad then use continue to skip that iteration inside the second loop and start again with the first loop???
                }
            }
        }
    }
}
