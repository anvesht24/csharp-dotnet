using  InventoryManagerOpt;

Inventory OldInventory=new Inventory();
OldInventory.AddProduct(new PhysicalProd("Laptop", 50, 9,50));



System.Console.WriteLine("The Old Inventory is ");

OldInventory.DisplayInventory();
double total=OldInventory.GetTotalInventoryValue();
System.Console.WriteLine($"Total Value of the inventory is:{total}");

