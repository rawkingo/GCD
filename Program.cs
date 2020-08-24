using System;
 
public class Program
{
    static int GCD(int num1, int num2)
    {
        int a;
 
        while (num2 != 0)
        {
            a = num1 % num2;
            num1 = num2;
            num2 = a;
        }
 
        return num1;
    }
 
    static int Main(string[] args)
    {
        int x, y;
 
        Console.Write("Try the first number :) : ");
        x = int.Parse(Console.ReadLine());
 
        Console.Write("And the second one?: ");
        y = int.Parse(Console.ReadLine());
 
        Console.Write("\nGCD OF ");
 
        Console.WriteLine("{0} and {1} is {2}", x, y, GCD(x, y));
 
        
        return 0;
    }
}