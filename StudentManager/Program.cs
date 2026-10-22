namespace StudentManager;
class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Object-Oriented Student Manager");
        List<Student> students=new List<Student>();

        while(true)
        {
            Console.Write("Enter student name :");
            string nameInput = Console.ReadLine();
            if (nameInput?.ToLower()=="exit")break;
            Console.Write($"Enter the grades of {nameInput}:");
            string scoreInput =Console.ReadLine();
            if (double.TryParse(scoreInput, out double score)&& score>=0&&score<= 100)
            {
                students.Add(new Student(nameInput,score));

            }
            else
            {
                Console.WriteLine("Invalid score");
            }

        }
        if (students.Count>0)
        {
            double average= students.Average(s => s.Score);
            double min= students.Min(s=>s.Score);
            double max = students.Max(s=>s.Score);
            Console.WriteLine($"The Average score of the students is:{average}");
            Console.WriteLine($"The Lowest Score from the total is:{min}");
            Console.WriteLine($"The Highest score from the total is: {max}");

        }
        else
        {
            Console.WriteLine("No records found.");
        }

    }
}