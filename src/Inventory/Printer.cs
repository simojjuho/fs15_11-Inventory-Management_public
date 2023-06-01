using System;
using System.Text;
namespace src.Inventory.Inventory;

class Printer
{
    public void PrintItem(Item item)
    {
        Console.WriteLine($"Item: {item.Name} --- {item.Barcode}");
    }

    public void PrintInventory(Inventory inventory)
    {
        Console.WriteLine("Inventory:");
        inventory.ViewInventory();
        Console.WriteLine(inventory.GetInventoryLength());
    }
}