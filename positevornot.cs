using System;
					
public class Program
{
	public static void Main()
	{
		 Console.WriteLine("enter number");
        int num=Convert.ToInt32(Console.ReadLine());
       	if(num>0){
			 Console.WriteLine("{0} is positive",num);
		}
		else if(num<0){
		 Console.WriteLine("{0} is negitive",num);
		}
		else{
		 Console.WriteLine("{0} is nutal",num);
		}
        Console.ReadLine();
	}
}