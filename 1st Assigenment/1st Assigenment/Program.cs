using System;

class Program
{
    static void Main(string[] args)
    {
        //1
        Console.WriteLine("Hello");
        Console.WriteLine("Bipro");
        //2
        int x = 30;
        int y = 55;
        int sum = x+y;
        Console.WriteLine(sum);
        //3
        double devition = (double)x / y;
        Console.WriteLine(devition);
        //4
        Console.WriteLine(-5 + 8 * 6);
        Console.WriteLine((55 + 9) % 9);
        Console.WriteLine(20 + -3 * 5 / 8);
        Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);
        //5
        int a = 11;
        int b = 5;
        int sum2 = a + b;
        int multiply = a * b;
        int subtract = a - b;
        double divide2 = (double)a / b;
        double remainder = (double)a % b;
        Console.WriteLine(sum2);
        Console.WriteLine(multiply);
        Console.WriteLine(subtract);
        Console.WriteLine(divide2);
        Console.WriteLine(remainder);
        //6
        double result = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
        Console.WriteLine(result);

        //7
        double width = 5.5;
        double hight = 8.5;
        double area = a * b;
        double perimeter = 2 * (width + hight);
        Console.WriteLine("Area :"+area);
        Console.WriteLine("Perimeter :"+perimeter);

        //8
        int c = 25;
        int d = 39;
        if (c != d)
        {
            Console.WriteLine(c +" != " + d);

        }
        else if (c < d)
        {
            Console.WriteLine(c + " < " + d);

        }
        else (c > d)
        {
            Console.WriteLine(c + " > " + d);

        }

        //9
        string name = "BIPRO";
        string revarsed = "";
        for(int i =name.Length-1; i>=0; i--)
        {
            revarsed += name[i];
        }
        Console.WriteLine(revarsed);


        //10
        Console.Write("Enter first number: ");
        double e = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double f = double.Parse(Console.ReadLine());

        bool results = (e > 0 && e < 1) && (f > 0 && f < 1);

        Console.WriteLine("Both numbers strictly between 0 and 1: " + results);
    }
}



