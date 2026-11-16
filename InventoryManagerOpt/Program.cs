using  InventoryManagerOpt;

Inventory OldInventory=new Inventory();
OldInventory.AddProduct(new PhysicalProd("Laptop", 50, 9,50));
PhysicalProd inventory=new PhysicalProd("Gaming Laptop", 10, 5, 60);

System.Console.WriteLine("The Old Inventory is ");

OldInventory.DisplayInventory();
double total=OldInventory.GetTotalInventoryValue();
System.Console.WriteLine($"Total Value of the inventory is:{total}");
double shipCost = inventory.GetShippingCost();
System.Console.WriteLine($"the cost for shipping this product is :{shipCost}");
List<Product> myInventory=InventoryRepository.LoadInventory();
InventoryRepository.SaveInventory(myInventory);
