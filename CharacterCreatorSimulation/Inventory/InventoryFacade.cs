
namespace CharacterCreatorSimulation.Inventory
{
    public class InventoryFacade
    {
        private Inventory inventory = new Inventory();

        public void AddItem(string item)
        {
            inventory.AddItem(item);
        }

        public void RemoveItem(string item)
        {
            inventory.RemoveItem(item);
        }

        public void FindItem(string item)
        {
            if (inventory.FindItem(item))
            {
                System.Console.WriteLine(item + " is in the inventory.");
            }
            else
            {
                System.Console.WriteLine(item + " is not in the inventory.");
            }
        }

        public void PrintItems()
        {
            inventory.PrintItems();
        }
    }
}
