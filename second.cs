using System;

class MyClass
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a Name: ");
        var name = Console.ReadLine();
        Console.WriteLine($"Welcome {name}");
    }

}