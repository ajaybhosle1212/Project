using System;

class DemoClass
 {
    public static void Main(string[] args)
    {
        foreach(var name in args)
        {
            Console.WriteLine($"Welcome  {name}");
        }
    }

 }