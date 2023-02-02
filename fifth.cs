using System;

class Fifth
{
    public static void Main(String [] args)
    {
        Console.WriteLine("Roll Number of the Student: ");
        var rollno=int.Parse(Console.ReadLine());

        Console.WriteLine("Name of the Student: ");
        var name=Console.ReadLine();
        
        Console.WriteLine("Physics, Chemistry, Computer Application: ");
        var math=int.Parse(Console.ReadLine());
        var phys=int.Parse(Console.ReadLine());
        var comApp=int.Parse(Console.ReadLine());

        var sum=math+phys+comApp;

        var per =(sum/300)*100;
        
        if(per>=80)
        {
            Console.WriteLine("First Class");
        }
        else
        {
            Console.WriteLine("Below First Class");
        }

    }
}