using System;
					
public class Program
{
	public static void Main()
	{
		 Console.WriteLine("enter number1");
        int num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter number2");
       	int num2=Convert.ToInt32(Console.ReadLine());
		int temp=num1;
		num1=num2;
		num2=temp;
		Console.WriteLine("number1 ={0} and number2 = {1}",num1,num2);
        Console.ReadLine();
	}
}