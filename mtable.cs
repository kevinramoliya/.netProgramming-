using System;
					
public class Program
{
	public static void Main()
	{
		 Console.WriteLine("enter number");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=10;i++){
            Console.WriteLine("{0} * {1} = {2}",num,i,num*i);
        }
        Console.ReadLine();
	}
}