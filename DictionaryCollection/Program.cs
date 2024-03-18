using System;

namespace WDictionary
{
    internal class DictionaryCollection
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Names = new Dictionary<string, string>();

            Names.Add("Doe", "John");
            Names.Add("Appleseed", "Johnny");
            Names.Add("Flinstone", "Freddy");
            Names.Add("TuTu", "Tori");
            Names.Add("Moore", "Milo");
            
            //keys
            Console.WriteLine("Names Keys");
            Dictionary<string, string>.KeyCollection keys = Names.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            //val
            Console.WriteLine("Names Values");
            Dictionary<string, string>.ValueCollection values = Names.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();


            //keys and val
            Console.WriteLine("Names Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in Names)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();

            //remove
            Console.WriteLine("Enter the name you need to remove (last)");
            string lastName = Console.ReadLine();
            if (Names.ContainsKey(lastName))
            {
                Names.Remove(lastName);
            }

            //display
            Console.WriteLine("Names in your list");
            foreach (KeyValuePair<string, string> kvp in Names)
            {
                Console.WriteLine($"Position: {kvp.Key}   Salary: " + String.Format("{0:C}", kvp.Value));
            }
            Console.WriteLine();
        }
    }
}