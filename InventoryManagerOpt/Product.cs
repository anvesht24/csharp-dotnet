namespace InventoryManagerOpt;

public abstract class Product
{
    public string Name{get;set;}
    public double Price{get;set;}
    public double Quantity{get;set;}

    protected Product(string pname,double pprice, double pquantity)
    {
        Name=pname;
        Price=pprice;
        Quantity=pquantity;
    }
    public abstract void DisplayInfo();
}