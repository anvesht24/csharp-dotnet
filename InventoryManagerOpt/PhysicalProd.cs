namespace InventoryManagerOpt;

public class PhysicalProd:Product
{
    public double Weight{get;set;}
    
    public PhysicalProd(string pname,double pprice, double pquantity, double pweight):base (pname,pprice,pquantity)
    {
        Weight=pweight;
    } 
    public override void DisplayInventory()
    {
            System.Console.WriteLine($"Item name:{Name}and {Weight}");
    }
}