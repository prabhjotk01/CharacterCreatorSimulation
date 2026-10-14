using System;
using System.Collections.Generic;

namespace CharacterCreatorSimulation.Inventory
{
    public class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine(item + " added to inventory.");
        }

        public void RemoveItem(string item)
        {
            if (items.Remove(item))
            {
                Console.WriteLine(item + " removed from inventory.");
            }
            else
            {
                Console.WriteLine(item + " was not found.");
            }
        }

        public bool FindItem(string item)
        {
            return items.Contains(item);
        }

        public void PrintItems()
        {
            Console.WriteLine("\n--- Inventory ---");

            if (items.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
            else
            {
                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
