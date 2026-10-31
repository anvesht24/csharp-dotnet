namespace InventoryManager;

public class Product
{
    public string Name{get;set;}
    public double Price{get;set;}
    public int StockQuantity{get;set;}
    
    public Product(string pname,double pprice, int pstockQuantity)
    {
        Name=pname;
        Price=pprice;
        StockQuantity=pstockQuantity;
    }
}