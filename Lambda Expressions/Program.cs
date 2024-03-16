using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

       
        Func<double, double, double> add = (x, y) => x + y;

       
        Func<double, double, double> multiply = (x, y) => x * y;

       
        Func<double, double, double> smaller = (x, y) => x < y ? x : y;

      
        Console.WriteLine($"The sum of {num1} and {num2} is: {add(num1, num2)}");
        Console.WriteLine($"The product of {num1} and {num2} is: {multiply(num1, num2)}");
        Console.WriteLine($"The smaller number between {num1} and {num2} is: {smaller(num1, num2)}");
    }
}
