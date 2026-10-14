using System;
using CharacterCreatorSimulation.Characters;

namespace CharacterCreatorSimulation.Decorators
{
    public class WizardDecorator : CharacterDecorator
    {
        public WizardDecorator(Character character)
            : base(character)
        {
            Intellect += 15;
        }

        public override void Act()
        {
            character.Act();
            Console.WriteLine(Name + " casts a magic spell!");
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " says: Magic is my power!");
        }
    }
}
