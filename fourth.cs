using System;

class Fourth
{
    public static void Main(String [] args)
    {
        Console.WriteLine("Maths: ");
        var maths=int.Parse(Console.ReadLine());

        Console.WriteLine("Physics: ");
        var phys=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Chemistry: ");
        var chem=int.Parse(Console.ReadLine());

        if(maths>=65 && phys>=55 && chem>=50 && (maths+phys+chem)>=180)
              Console.WriteLine("Your Admission Is Confirm...!!");
        else
        {
             Console.WriteLine("You are not Eligible");
        }
    }
}
