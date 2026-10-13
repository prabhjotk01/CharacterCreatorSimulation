
using System;
using CharacterCreatorSimulation.Characters;

namespace CharacterCreatorSimulation.Decorators
{
    public class CharacterDecorator : Character
    {
        protected Character character;

        public CharacterDecorator(Character character)
            : base(character.Name)
        {
            this.character = character;
        }

        public override void Act()
        {
            character.Act();
        }

        public override void Speak()
        {
            character.Speak();
        }

        public new void PrintDetails()
        {
            character.PrintDetails();
        }
    }
}
