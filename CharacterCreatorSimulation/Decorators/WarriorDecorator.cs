
using System;
using CharacterCreatorSimulation.Characters;

namespace CharacterCreatorSimulation.Decorators
{
    public class WarriorDecorator : CharacterDecorator
    {
        public WarriorDecorator(Character character)
            : base(character)
        {
            Strength += 10;
            Defense += 10;
        }

        public override void Act()
        {
            character.Act();
            Console.WriteLine(Name + " attacks with a sword!");
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " says: I am a powerful Warrior!");
        }
    }
}
