namespace InventoryManagerOpt;

public class Product
{
    public string Name{get;set;}
    public double Price{get;set;}
    public double Quantity{get;set;}

    public Product(string pname,double pprice, double pquantity)
    {
        Name=pname;
        Price=pprice;
        Quantity=pquantity;
    }

}