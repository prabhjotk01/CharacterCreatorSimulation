using System;
namespace CharacterCreatorSimulation.Characters
{
    public class Human : Character
    {
        public Human(string name) : base(name)
        {
            Health = 100;
            Defense = 15;
            Speed = 15;
            Strength = 15;
            Intellect = 15;
            Agility = 15;
        }

        public override void Act()
        {
            Console.WriteLine(Name + " is exploring the world.");
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " says: I am a brave Human!");
        }
    }
}
