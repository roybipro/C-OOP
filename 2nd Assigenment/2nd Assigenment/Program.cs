//1st
/*
using System;

class Program
{
    
    static void Main(string[] args)
    {
        int inp = Int32.Parse(Console.ReadLine());
        for (int i = 0; i <= inp; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

*/


//2 no
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 1; i < 5; i++)
        {
                for (int j = 1; j <=6; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                        Console.Write("X");

                }
            Console.WriteLine();
        }
    }
    }

*/

//3
/*
using System;

class NumberPattern
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++) // Rows
        {
            for (int j = i; j < i + 5; j++) // Columns
            {
                Console.Write(j);
            }
            Console.WriteLine(); // Move to next line
        }
    }
}
*/

//4
/*
class Program
{

    static void Main(string[] args)
    { int sumEven = 0;
        int sumOdd = 0;
        for(int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sumEven += i;

            }
            else
                sumOdd += i;
        }
        Console.WriteLine("Even :"+sumEven);
        Console.WriteLine("Odd :"+sumOdd);
    }
}
*/

//5 no
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        
        for (int i = 1; i < 6; i++)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(j);
        }
    }
}
*/
//6
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Int32.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial of " + number + " is: " + factorial);
    }
}

*/
//7
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 9; i++)
        {
            int stars;
            if (i <= 5)
                stars = i;
            else
                stars = 10 - i;

            // Print stars
            for (int j = 1; j <= stars; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
*/

//8
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks for Physics: ");
        int physics = Int32.Parse(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        int chemistry = Int32.Parse(Console.ReadLine());

        Console.Write("Enter marks for Biology: ");
        int biology = Int32.Parse(Console.ReadLine());

        Console.Write("Enter marks for Mathematics: ");
        int math = Int32.Parse(Console.ReadLine());

        Console.Write("Enter marks for Computer: ");
        int computer = Int32.Parse(Console.ReadLine());


        int totalMarks = physics + chemistry + biology + math + computer;
        double percentage = totalMarks / 5.0;

        Console.WriteLine("Percentage: " + percentage + "%");

        string grade;
   
        if (percentage >= 90)
            grade = "A+";
        else if (percentage >= 85)
            grade = "A";
        else if (percentage >= 80)
            grade = "B+";
        else if (percentage >= 75)
            grade = "B";
        else if (percentage >= 50)
            grade = "C+";
        else
            grade = "F";

        Console.WriteLine("Grade: " + grade);
    }
}
