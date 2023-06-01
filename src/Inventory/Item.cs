namespace src.Inventory.Inventory;

public class Item
{
    private string _barcode;
    private string _name;
    private int _quantity;

    public string Name
    {
        get
        {
            return _name;
        }
        set{
            if (value.Length > 5)
            {
                _name = value;
            }
            else
            {
                throw new Exception("Name must be at least 6 letters long");
            }
        }
    }
    public string Barcode
    {
        get
        {
            return _barcode;
        }
    }
    public int Quantity
    {
        get
        {
            return _quantity;
        }
        set
        {
            if(value >= 0)
            {
                _quantity = value;
            }
            else
            {
                throw new Exception("Quantity cannot be negative");
            }
        }
    }

    public Item(string barcode, string name)
    {
        this._barcode = barcode;
        this.Name = name;
        this.Quantity = 0;
    }

    public void IncreaseQuantity(int newAmount)
    {
        this.Quantity = this.Quantity + newAmount;
    }

    public void DecreaseQuantity(int newAmount)
    {
        this.Quantity = this.Quantity - newAmount;
    }

    public override string ToString()
    {
        return $"Item: {this.Barcode}: {this.Name} Amount: {this.Quantity}";
    }
}