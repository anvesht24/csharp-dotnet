namespace InventoryManagerOpt;

public class PhysicalProd:Product, IDiscountable
{
    public double Weight{get;set;}
    
    private double _discountMultiplier=.10;
    public PhysicalProd(string pname,double pprice, double pquantity, double pweight):base (pname,pprice,pquantity)
    {
        Weight=pweight;
    } 
    public override void DisplayInfo()
        {
            double finalPrice=GetDiscountedPrice();
            Console.WriteLine($"[Physical] {Name} | Original Price: ${Price}| Discounted Price : ${finalPrice} | Weight: {Weight}kg");
        }
    public void ApplyDiscount(double percent)
    {
        if (percent>0 && percent<=100)
        {
            _discountMultiplier =1.0-(percent/100.0);
        }    
    }
    public double GetDiscountedPrice()
    {
        return Price * _discountMultiplier;
    }
}
