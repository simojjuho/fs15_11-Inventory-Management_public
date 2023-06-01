using System;
using src.Inventory.Inventory;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory(3);
            inventory.AddItem(new Item("1234", "Johnny Depp doll"), 4);
            inventory.AddItem(new Item("2345", "Aryana Grande doll"), 41);
            inventory.AddItem(new Item("3456", "Jennifer Aniston doll"), 3);
            try
            {
                inventory.AddItem(new Item("1234", "Dwayne \"The Rock\" Johnson doll"), 1);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Printer printer = new Printer();
            printer.PrintInventory(inventory);
            try
            {
                inventory.RemoveItem("2345");    
            }
            catch (System.Exception ex)
            {
                 Console.WriteLine(ex.Message);
            }
             try
            {
                inventory.RemoveItem("5678");    
            }
            catch (System.Exception ex)
            {
                 Console.WriteLine(ex.Message);
            }
            inventory.IncreaseQuantity(4, "1234");
            inventory.DecreaseQuantity(1, "3456");
            try {
                inventory.DecreaseQuantity(9, "1234");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                inventory.AddItem(new Item("3456", "Jack Nicholson doll"), 7);
            }
            catch (System.Exception ex)
            {
                 Console.WriteLine(ex.Message);
            }
            printer.PrintInventory(inventory);
        }
    }
}