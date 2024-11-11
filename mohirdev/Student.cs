namespace mohirdev;

public enum Rating : int
{
    A = 5, 
    B = 4, 
    C = 3, 
    D = 2
}

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Grade { get; set; }
    public Rating Mark { get; set; }

    public Student(string name, string surname, int grade, Rating mark)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Grade = grade;
        Mark = mark;
    }

    public override string ToString()
    {
        return $"{Name} {Surname} ({Grade}-grade), Mark: {Mark}({(int)Mark})";
    }

    public static void GetStudentWithMark(List<Student> students, int mark)
    {
        foreach (var student in students)
            if ((int)student.Mark == mark)
                Console.WriteLine(student.ToString());
    }
}