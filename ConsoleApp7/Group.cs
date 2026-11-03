using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7;

internal class Group
{
    public string Title { get; set; }
    public List<Student> Students = new List<Student>();
    public Group()
    {
        Title = string.Empty;
    }
    public Group(string title, List<Student> students )
    {
        Students = students;
        Title = title;
    }
    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Group: {Title}.\n");
        foreach (Student student in Students)
        {
            sb.Append(student +"\n");
        }
        return sb.ToString();
    }
}
