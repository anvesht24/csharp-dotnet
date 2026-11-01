
using InventoryManager;
Console.WriteLine("Inventory Manager");
List<Product> products = new List<Product>();
while (true)
{
    System.Console.WriteLine("Ready to enter the Product details! Type 'yes' or 'no'");
    string confirmation=Console.ReadLine();
    if (confirmation =="yes")
    {
        System.Console.WriteLine("Enter the name of the Product");
        string nameinput=Console.ReadLine();

        System.Console.WriteLine($"Enter the price of{nameinput}");
        string priceinput=Console.ReadLine()??"";
        if(double.TryParse(priceinput, out double price)){}
        else{System.Console.WriteLine("Enter a valid number");}

        
        System.Console.WriteLine($"Enter the quantity of{nameinput}");
        string quantityinput=Console.ReadLine();
        if(int.TryParse(quantityinput, out int quantity)){}
        else{System.Console.WriteLine("Enter a valid number");}
        
        products.Add(new Product(nameinput,price,quantity));

    }
    
    else if (confirmation== "no")break;

    else{System.Console.WriteLine("Enter a valid input: Just 'yes'/'no'");}
    

}
double   sum = 0;
for(int i=0; i<products.Count;i++)
{
    System.Console.WriteLine($"Item:{products[i].Name} Price: {products[i].Price} Quantity:{products[i].StockQuantity} ");
    
    sum=sum+products[i].Price * products[i].StockQuantity;

}

double maxValue=products.Max(p=>p.Price);
System.Console.WriteLine("Thank you");
System.Console.WriteLine($"Total count of the items in stock:{products.Count}");
System.Console.WriteLine($"Total Value of the items in stock:{sum}");
System.Console.WriteLine($"Expensive Item Value of all the items in stock:{maxValue}");
   