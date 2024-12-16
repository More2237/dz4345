using System;

public class Program
{
    public static void Jufttoq(int A)
    {
        if (A % 2 == 0)
        {
            Console.WriteLine("Raqam " + A + " juft ast");
        }
        else
        {
            Console.WriteLine("Raqam " + A + " toq ast.");
        }
    }

    public static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        Jufttoq(k);  
        Jufttoq(l); 
        Jufttoq(m);  
        Jufttoq(a);  
        Jufttoq(b);  
    }
}