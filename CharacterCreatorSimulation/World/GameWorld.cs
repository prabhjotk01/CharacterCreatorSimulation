using System;
using System.Collections.Generic;
using CharacterCreatorSimulation.Characters;

namespace CharacterCreatorSimulation.World
{
    public class GameWorld
    {
        private static GameWorld instance;

        public List<Character> Characters { get; set; }

        public int WorldTime { get; set; }

        private GameWorld()
        {
            Characters = new List<Character>();
            WorldTime = 0;
        }

        public static GameWorld Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameWorld();
                }
                    return instance;
            }
        }

        public void AddCharacter(Character character)
        {
            Characters.Add(character);
        }

        public void AdvanceTime()
        {
            WorldTime++;
            Console.WriteLine("World time is now: " + WorldTime);
        }
    }
}
