using System;
namespace CharacterCreatorSimulation.Characters
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }

        public Character(string name)
        {
            Name = name;
            Health = 100;
            Defense = 10;
            Speed = 10;
            Strength = 10;
            Intellect = 10;
            Agility = 10;
        }

        public virtual void Act()
        {
            Console.WriteLine(Name + " is taking action.");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Hello, I am " + Name + ".");
        }

        public void PrintDetails()
        {
            Console.WriteLine(" Character Details");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Defense: " + Defense);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Intellect: " + Intellect);
            Console.WriteLine("Agility: " + Agility);
        }
    }
}
