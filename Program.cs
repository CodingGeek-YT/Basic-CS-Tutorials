using System;

class Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
    }
    static void Main()
    {
        Person p = new Person("Andy");
        Console.Write(p.Name);
    }
}