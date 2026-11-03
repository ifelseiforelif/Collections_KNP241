namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Student> students = new List<Student>();
            students.Add(new Student("Alex",20));
            students.Add(new Student("Bob",18));
            students.Add(new Student("Alice",19));
            Group group = new Group("KN241",students);
            group.AddStudent(new Student("Ivan", 17));
            Console.WriteLine(group);

        }
    }
}
