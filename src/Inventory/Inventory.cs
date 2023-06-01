namespace src.Inventory.Inventory;

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

    public void AddItem(Item item, int quantity) 
    {
        if(!_items.Contains(item) && _items.Count < this.MaxCapacity)
        {  
            if(_items.Exists(listItem => listItem.Barcode == item.Barcode))
            {
                throw new Exception($"Item with barcode {item.Barcode} exists already!");
            }
            else
            {
                _items.Add(item);
            }
        }
                else
        {
            throw new Exception("Max capacty of inventory reached. Remove some item first.");
        }
        item.IncreaseQuantity(quantity);
        Console.WriteLine($"New item added: {item.Name}, amount: {item.Quantity}");
    }

    public void RemoveItem(string barcode)
    {
        Console.WriteLine($"Removing item with barcode {barcode}...");
        if(!_items.Exists(item => item.Barcode == barcode))
        {
            throw new Exception($"Item with barcode {barcode} does not exist.");
        }
        else
        {
            _items = _items.Where(item => item.Barcode != barcode).ToList();
            Console.WriteLine("Item removed!");
        }
    }

    public void IncreaseQuantity(int amount, string barcode)
    {
        Item? item = _items.Find(item => item.Barcode == barcode);
        if(item != null)
        {
            item.IncreaseQuantity(amount);
        }
        else
        {
            throw new Exception($"Item with barcode {barcode} doesn't exist.");
        }
    }

    public void DecreaseQuantity(int amount, string barcode)
    {
        Item? item = _items.Find(item => item.Barcode == barcode);
        if(item != null)
        {
            item.DecreaseQuantity(amount);
        }
        else
        {
            throw new Exception($"Item with barcode {barcode} doesn't exist.");
        }
    }

    public void ViewInventory()
    {
        foreach(Item item in _items)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public string GetInventoryLength()
    {
        return $"Inventory has {this._items.Count} items out of max capacity of {this.MaxCapacity}";
    }

    ~Inventory()
    {
        Console.WriteLine("Inventory destroyed!");
    }
}