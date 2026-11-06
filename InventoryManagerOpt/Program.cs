using  InventoryManagerOpt;

Inventory OldInventory=new Inventory();
OldInventory.AddProduct(new Product("Laptop", 50, 9));
OldInventory.AddProduct(new Product("Mouse", 40, 4));
OldInventory.AddProduct(new Product("Laptop", 50, 8));



System.Console.WriteLine("The Old Inventory is ");

OldInventory.DisplayInventory();
double total=OldInventory.GetTotalInventoryValue();
System.Console.WriteLine($"Total Value of the inventory is:{total}");

