using System;
using System.Security.Cryptography;

class MethodOverloading
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number a1:");
       int  a1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number a2:");
        int a2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number b1:");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Number b2:");
        double b2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Addtion of Integer Value :" + add(a1,a2));
        Console.WriteLine("Addtion of Double Value :" + add(b1,b2));
        Console.ReadKey();
    }
   
    public static int add(int a1, int a2) { 
        int  c = a1 + a2;
        return c;

    }
    public static double add(double b1,double b2) { 
        double c = b1 + b2;
        return c;
    }
}