namespace InventoryManager;

public class Product
{
    public string Name{get;set;}
    public double Price{get;set;}
    public int StockQuantity{get;set;}
    public double Discount {get;set;}
    
    public Product(string pname,double pprice, int pstockQuantity, double pdiscount)
    {
        Name=pname;
        Price=pprice;
        StockQuantity=pstockQuantity;
        Discount=pdiscount;
    }
    public double GetTotalValue()
    {
        return  Price*StockQuantity;
    }
    public void ApplyDiscount(double percentage)
    {
        double discountAmount =Price*(percentage/100.0);
        Price= Price-discountAmount;
    }
}