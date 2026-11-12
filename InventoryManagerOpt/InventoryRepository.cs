using System.Runtime.CompilerServices;
using System.Text.Json;

namespace InventoryManagerOpt;
public static class InventoryRepository
{
    private static readonly string FilePath="inventory_data.json";
    private static readonly JsonSerializerOptions Options =new JsonSerializerOptions
    {
        WriteIndented=true,
        PropertyNameCaseInsensitive=true

    };
    public static void SaveInventory(List<Product> products)
    {
        try
        {
            string jsonString =JsonSerializer.Serialize(products, Options);
            File.WriteAllText(FilePath,jsonString);
            System.Console.WriteLine($"[Success]Inventory Successfully saved to {FilePath}");
        }
        catch(Exception ex)
        {
            System.Console.WriteLine($"[Error] Failed to save incentory :{ex.Message}");
        }
    }
    public static List <Product> LoadInventory()
    {
        if(!File.Exists(FilePath))
        {
            System.Console.WriteLine("[Notice] no existing inventory file found ");
            return new List<Product>();
        }
        try
        {
            string jsonString =File.ReadAllText(FilePath);
            var products = JsonSerializer.Deserialize<List<Product>>(jsonString,Options);
            System.Console.WriteLine("Sucess : Inventory Loaded successfully");
            return products ?? new List<Product>();

        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error: failed to load inventory:{ex.Message}");
            return new List<Product>();
        }
    }
}