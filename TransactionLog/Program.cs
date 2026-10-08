using System;
using System.Collections.Generic;
List<decimal> expenses = new List<decimal>();
Console.WriteLine("Expense Tracker ");
Console.WriteLine("Enter the Expenses");
while(true)
{

    Console.Write("Enter the first one:");
    string input =Console.ReadLine()??"";
    if (input.Equals("exit")||input=="0")
    {
        break;
    }
    if (decimal.TryParse(input, out decimal amount)&& amount > 0)
    {
        expenses.Add(amount);
        Console.WriteLine($"Added amount:{amount}");
        Console.WriteLine("These are your expenses:"); 
        foreach(decimal expense in expenses)
        {
            Console.WriteLine(""+expense); 
        }
    }
    else
    {
        Console.WriteLine("Invalid Input");
    }

    if (expenses.Count==0)
    {
        Console.WriteLine("No expense is recorded");
    }
    else
    {
        decimal totalSpent=0;
        foreach (decimal expense in expenses)
        {
            totalSpent+=expense;
    
        }
        Console.WriteLine("Total:"+totalSpent);
    }
}