namespace Inventory;

public class Inventory
{
    private List<Item> _items = new List<Item> {};
    private int _maxCapacity;

    public int MaxCapacity
    {
        get
        {
            return _maxCapacity;
        }
        set
        {
            if(value > 0)
            {
                _maxCapacity = value;
            }
            else
            {
                throw new Exception("Max capacity must be a positive value");
            }
        }
    }

    public Inventory(int maxCap)
    {
        this.MaxCapacity = maxCap;
    }

    public void AddItem(string item, string quantity) 
    {
        if (_items.Exists(_ => _.Name == item))
        {
            Item foundItem = _items.Find(_ => _.Name == item)
            {
                foundItem.IncreaseQuantity(Convert.ToInt32(quantity));
            }
        }
        else
        {
            
        }
    }

    public void RemoveItem(string barcode)
    {}

    public void IncreaseQuantity(int amount, string barcode)
    {}

    public void DecreaseQuantity(int amount, string barcode)
    {}

    public void ViewInventory()
    {}

    ~Inventory()
    {
        Console.WriteLine("Inventory destroyed!");
    }
}