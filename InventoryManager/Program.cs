
using InventoryManager;
Console.WriteLine("Inventory Manager");
List<Product> products = new List<Product>();
double TotalValue;

while (true)
{
    System.Console.WriteLine("Ready to enter the Product details! Type 'yes' or 'no'");
    string confirmation=Console.ReadLine()??"";
    if (confirmation =="yes")
    {
        System.Console.WriteLine("Enter the name of the Product");
        string nameinput=Console.ReadLine()??"";

        System.Console.WriteLine($"Enter the price of{nameinput}");
        string priceinput=Console.ReadLine()??"";
        if(double.TryParse(priceinput, out double price)){}
        else{System.Console.WriteLine("Enter a valid number");}

        
        System.Console.WriteLine($"Enter the quantity of{nameinput}");
        string quantityinput=Console.ReadLine()??"";
        if(int.TryParse(quantityinput, out int quantity)){}
        else{System.Console.WriteLine("Enter a valid number");}
        
        System.Console.WriteLine("Enter the discount percentage");
        string discountinput=Console.ReadLine()??"";
        if (double.TryParse(discountinput, out double discount)&& discount>0 && discount<=100){}
        else{System.Console.WriteLine("Enter the valid discount percentage");}


        products.Add(new Product(nameinput,price,quantity,discount));
        
    }

    
    else if (confirmation== "no")break;

    else{System.Console.WriteLine("Enter a valid input: Just 'yes'/'no'");}
    

}
double   sum = 0;
for(int i=0; i<products.Count;i++)
{
    System.Console.WriteLine($"Item:{products[i].Name} Price: {products[i].Price} Quantity:{products[i].StockQuantity} ");
    
    sum=sum+products[i].Price * products[i].StockQuantity;

    TotalValue=products[i].GetTotalValue();
    System.Console.WriteLine($"Total Value of the items is:{TotalValue}");
    products[i].ApplyDiscount(products[i].Discount);
    System.Console.WriteLine($"Value after the discount:{products[i].Price}");
}
double maxValue=products.Max(p=>p.Price);
System.Console.WriteLine("Thank you");
System.Console.WriteLine($"Total count of the items in stock:{products.Count}");
System.Console.WriteLine($"Total Value of the items in stock:{sum}");
System.Console.WriteLine($"Expensive Item Value of all the items in stock:{maxValue}");
