string merchantName;
decimal transactionAmount;
int categoryId;
bool isTaxDeductible;
Console.Write($"Merchant Name :");
merchantName = Console.ReadLine() ?? "";
Console.Write($"Transaction Amount :");
transactionAmount = decimal.Parse(Console.ReadLine() ?? "0");
Console.Write($"whats the categoryid:");
categoryId = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Is it taxable or not :True/False");
isTaxDeductible = bool.Parse(Console.ReadLine() ?? "False");
Console.WriteLine($"This Merchant Name :"+merchantName);
Console.WriteLine($"The Category ID:"+categoryId);
Console.WriteLine($"The transaction Amount:"+transactionAmount);
Console.WriteLine($"Tax Deductible:"+isTaxDeductible);

//REad the system information 
string machineName=Environment.MachineName;
string osVersion=Environment.OSVersion.ToString();
Console.WriteLine("Machine Name"+machineName);
Console.WriteLine("osVersion"+osVersion);