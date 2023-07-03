using System;
class ZerodiviserError
{
    public static void Main()
    {
        Console.WriteLine("Enter Number1 :");
        int number1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number2 :");
        int number2=Convert.ToInt32(Console.ReadLine());

        try
        {
            Console.WriteLine("{0} / {1} = {2}", number1, number2,( number1 / number2));
        }
        catch (DivideByZeroException e) { 
        Console.WriteLine(e.Message); 
        }
        
    }
    
}