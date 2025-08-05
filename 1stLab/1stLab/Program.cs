using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 17, b = 6;
        int sum = a + b;
        double divide = a / (b + 0.0); //typle casting (double)b
        Console.WriteLine("The Sum of {0} and {1} is: {2}", a, b, sum); //{}callded place holder
        Console.WriteLine($"The Sum of {a} and {b} is: {sum}");//string interpolatition
        Console.WriteLine("divition of " + a + " and " + b + " is " + divide);


        //5
        int sum2 = a + b;
        int multiply = a * b;
        int subtract = a - b;
        int divide2 = a / b;
        Console.WriteLine(sum2);
        Console.WriteLine(multiply);
        Console.WriteLine(subtract);
        Console.WriteLine(divide2);

        //7
        double width = 5.5;
        double hight = 8.5;
        double area = a * b;
        double perameter = 2 * (width + hight);

        Console.WriteLine("The area is: " + area);
        Console.WriteLine("The Perameter: " + perameter);

        string name = Console.ReadLine();
        Console.WriteLine("Welcome :"  +name);

        //Parsing
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        int n = Int32.Parse(input1);
        int m = Int32.Parse(input2);
        Console.WriteLine(n+m);

        //
        Console.WriteLine(n*m);
    }
}



