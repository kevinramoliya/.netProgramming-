using System;
					
public class Program
{
	public static void Main()
	{
		 Console.WriteLine("enter number");
        int num=Convert.ToInt32(Console.ReadLine());
       	int temp=0,sum=0;
		while(num>0){
			temp=num%10;
			sum=sum+temp;
			num=num/10;
		}
		 Console.WriteLine("sum of digite = {0}",sum);
        Console.ReadLine();
	}
}