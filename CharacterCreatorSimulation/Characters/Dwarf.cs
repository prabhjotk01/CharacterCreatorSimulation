using System;
namespace CharacterCreatorSimulation.Characters
{
    public class Dwarf : Character
    {
        public Dwarf(string name) : base(name)
        {
            Health = 130;
            Defense = 25;
            Speed = 8;
            Strength = 30;
            Intellect = 12;
            Agility = 8;
        }

        public override void Act()
        {
            Console.WriteLine(Name + " swings a powerful hammer.");
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " says: Dwarves never give up!");
        }
    }
}
