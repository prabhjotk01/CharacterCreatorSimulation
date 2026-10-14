using System;
using CharacterCreatorSimulation.Characters;
using CharacterCreatorSimulation.Factories;
using CharacterCreatorSimulation.Decorators;
using CharacterCreatorSimulation.Inventory;
using CharacterCreatorSimulation.World;

namespace CharacterCreatorSimulation.Controllers
{
    public class GameController
    {
        private CharacterFactory factory = new CharacterFactory();
        private GameWorld world = GameWorld.Instance;
        private InventoryFacade inventory = new InventoryFacade();
        private Character character;

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== CHARACTER CREATOR ===");
                Console.WriteLine("1. Create Character");
                Console.WriteLine("2. Add Specialization");
                Console.WriteLine("3. Manage Inventory");
                Console.WriteLine("4. Show Character Details");
                Console.WriteLine("5. Run Simulation");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateCharacter();
                        break;
                    case "2":
                        AddSpecialization();
                        break;
                    case "3":
                        ManageInventory();
                        break;
                    case "4":
                        ShowDetails();
                        break;
                    case "5":
                        RunSimulation();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private void CreateCharacter()
        {
            Console.Write("Enter character name: ");
            string name = Console.ReadLine();

            Console.WriteLine("1. Human");
            Console.WriteLine("2. Elf");
            Console.WriteLine("3. Dwarf");
            Console.Write("Choose character type: ");

            string typeChoice = Console.ReadLine();
            string type = "";

            if (typeChoice == "1")
                type = "Human";
            else if (typeChoice == "2")
                type = "Elf";
            else if (typeChoice == "3")
                type = "Dwarf";
            else
            {
                Console.WriteLine("Invalid character type.");
                return;
            }

            character = factory.CreateCharacter(type, name);

            if (character != null)
            {
                world.AddCharacter(character);
                Console.WriteLine("Character created successfully!");
                character.PrintDetails();
            }
        }

        private void AddSpecialization()
        {
            if (character == null)
            {
                Console.WriteLine("Create a character first.");
                return;
            }

            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Wizard");
            Console.Write("Choose specialization: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                character = new WarriorDecorator(character);
                Console.WriteLine("Warrior specialization added!");
            }
            else if (choice == "2")
            {
                character = new WizardDecorator(character);
                Console.WriteLine("Wizard specialization added!");
            }
            else
            {
                Console.WriteLine("Invalid specialization.");
            }
        }

        private void ManageInventory()
        {
            Console.WriteLine("\n1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Find Item");
            Console.WriteLine("4. Show Inventory");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter item name: ");
                inventory.AddItem(Console.ReadLine());
            }
            else if (choice == "2")
            {
                Console.Write("Enter item name: ");
                inventory.RemoveItem(Console.ReadLine());
            }
            else if (choice == "3")
            {
                Console.Write("Enter item name: ");
                inventory.FindItem(Console.ReadLine());
            }
            else if (choice == "4")
            {
                inventory.PrintItems();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        private void ShowDetails()
        {
            if (character == null)
            {
                Console.WriteLine("Create a character first.");
                return;
            }

            character.PrintDetails();
        }

        private void RunSimulation()
        {
            if (character == null)
            {
                Console.WriteLine("Create a character first.");
                return;
            }

            character.Act();
            character.Speak();
            world.AdvanceTime();
        }
    }
}
