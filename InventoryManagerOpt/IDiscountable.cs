namespace InventoryManagerOpt;
public interface IDiscountable
{
    void ApplyDiscount(double percent);
    double GetDiscountedPrice();
}