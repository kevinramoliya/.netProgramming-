using System;
class CustomException
{
    public static void Main()
    {
        Console.WriteLine("Enter Any one Number:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        try {
            if (number1 % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else {
                throw new OddNumberException("Number is odd");
            }
        } catch(OddNumberException e ) {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
    }
    public class OddNumberException:Exception {
        public OddNumberException() { }
        public OddNumberException(string message) : base(message) { 
        }

    }
}