using System;
using System.Collections.Generic;
using System.Linq;
List<double> grades = new List<double>();
Console.Write("Enter the name of the student");
string studentName = Console.ReadLine();
while (true)
{

    
    Console.Write($"Enter the grades of {studentName} and type -1 when finished");
    string input = Console.ReadLine();
    if (double.TryParse(input, out double grade))
    {
        if (grade == -1) break;
        if (grade >= 0 && grade <= 100)
        {
            grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Please Enter a valid score");
        }
        
    }
    else
    {
        Console.WriteLine("Invalid Input");
    }
    
}
Console.WriteLine("The recorded scores are:");
foreach (double g in grades)
        {
            Console.WriteLine(""+g);
        }
Console.WriteLine($"The Highest Score is:{grades.Max()}");
Console.WriteLine($"The Total Subjects are:{grades.Count()}");
Console.WriteLine($"The Lowest scores is:{grades.Min()}");