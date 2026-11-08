namespace InventoryManagerOpt;
public class Inventory
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public virtual void DisplayInventory()
    {
        foreach(var product in _products)
        {
            product.DisplayInfo();
        }
    }
    public  double GetTotalInventoryValue()
    {
        double sum= 0;
        foreach(var product in _products){
           sum += product.Price;
           
        }
        return sum;
    }
    

}