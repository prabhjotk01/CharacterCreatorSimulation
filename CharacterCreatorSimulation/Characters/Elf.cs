using System;
namespace CharacterCreatorSimulation.Characters
{
    public class Elf : Character
    {
        public Elf(string name) : base(name)
        {
            Health = 90;
            Defense = 10;
            Speed = 25;
            Strength = 12;
            Intellect = 25;
            Agility = 30;
        }

        public override void Act()
        {
            Console.WriteLine(Name + " moves quickly through the forest.");
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " says: The forest protects us!");
        }
    }
}

