using System;
class CommonStringMethods
{
    public static void Main(string[] args)
    {
        string a = "Kevin";
        string b = "Ramoliya";
        string c;
        Console.WriteLine(a + b);
        Console.WriteLine(string.Concat(a,b));
        Console.WriteLine(a.Contains(b));
        Console.WriteLine(c=string.Copy(a));
        Console.WriteLine(a.Equals(c));
        Console.WriteLine(a.IndexOf("v"));
        Console.WriteLine(a.Replace("vin","VIN"));
        Console.WriteLine(a.Substring(1));
        Console.WriteLine(a.Insert(5,"Ramoliya"));
    }
}