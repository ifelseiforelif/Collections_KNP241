using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7;

internal class Student
{
    public string Name { get; set; }
    public ushort Age { get; set; }
    public Student()
    {
        Name = string.Empty;
        Age = 18;
    }
    public Student(string name, ushort age)
    {
        Name = name;
        Age = age;
    }
    public override string ToString()
    {
        return $"{Name} {Age}";
    }
}
