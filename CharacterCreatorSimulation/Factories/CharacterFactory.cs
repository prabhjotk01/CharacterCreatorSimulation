
using CharacterCreatorSimulation.Characters;

namespace CharacterCreatorSimulation.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string type, string name)
        {
            if (type == "Human")
            {
                return new Human(name);
            }
            else if (type == "Elf")
            {
                return new Elf(name);
            }
            else if (type == "Dwarf")
            {
                return new Dwarf(name);
            }
            else
            {
                return null;
            }
        }
    }
}
