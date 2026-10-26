namespace StudentManager;

class Program
{
    static void  Main(string[] args)
    {
        Console.WriteLine("Object Oriented Student Manager");
        List<Student> students =new List<Student>();
        while(true)
        {
            Console.WriteLine("Enter the name of the student or type 'exit' after finishing");
            string nameInput=Console.ReadLine();
            if (nameInput?.ToLower() == "exit")break;
            Console.WriteLine($"Enter the grades of the {nameInput}");

            string studentScore=Console.ReadLine();
            if(double.TryParse(studentScore, out double score)&& score<=100 &&score>0)
            {
                students.Add(new Student(nameInput,score));
            }
            
        }
        Console.WriteLine("The List of all the students marks");
        for(int i=0; i<students.Count;i++)
            {
            Console.WriteLine($"{students[i].Name}'s score is {students[i].Score}");
            }
    }
}