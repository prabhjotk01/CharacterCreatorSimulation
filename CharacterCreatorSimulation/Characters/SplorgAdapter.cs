
using System;
using Artifact_Legacy_Code;

namespace CharacterCreatorSimulation.Characters
{
    public class SplorgAdapter : Character
    {
        private Splorg splorg;

        public SplorgAdapter(string name, string color)
            : base(name)
        {
            splorg = new Splorg(name, color);

            Health = 100;
            Defense = splorg.BubbleDurability * 5;
            Speed = splorg.Speed;
            Strength = splorg.BubbleDurability * 2;
            Intellect = splorg.Smarts;
            Agility = splorg.Finesse;
        }

        public override void Act()
        {
            splorg.SplorgAction();
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " says: " + splorg.Communicate());
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            PrintAdditionalDetails();
        }

        public override void PrintAdditionalDetails()
        {
            Console.WriteLine("Splorg Color: " + splorg.Color);
            Console.WriteLine("Bubble Durability: " + splorg.BubbleDurability);
            Console.WriteLine("Smarts: " + splorg.Smarts);
            Console.WriteLine("Luck: " + splorg.Luck);

            splorg.printDescription();
        }
    }
}
