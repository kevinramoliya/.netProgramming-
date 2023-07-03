using System;
					
public class Program
{
	public static void Main()
	{
		 
			Console.WriteLine("enter first num");
		int num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter second num");
		int num2=Convert.ToInt32(Console.ReadLine());
		string odd="";
		string even="";
		for(int i=num1;i<=num2;i++){
			if(i%2==0){
			even+=i.ToString()+",";
			}
			else{
			odd+=i.ToString()+",";
			}
		}
		Console.WriteLine(odd);
		Console.WriteLine(even);
        Console.ReadLine();
	}
}