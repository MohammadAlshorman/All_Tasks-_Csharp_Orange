using System;

// Calculator class demonstrating method overloading
class Calculator
{
    // Add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Add two double values
    public double Add(double a, double b)
    {
        return a + b;
    }
}

// Main program to demonstrate overloading
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Calculator class
        Calculator calculator = new Calculator();

        // Demonstrate adding two integers
        int sum1 = calculator.Add(10, 20);
        Console.WriteLine($"Sum of two integers (10, 20): {sum1}");

        // Demonstrate adding three integers
        int sum2 = calculator.Add(5, 15, 25);
        Console.WriteLine($"Sum of three integers (5, 15, 25): {sum2}");

        // Demonstrate adding two double values
        double sum3 = calculator.Add(10.5, 20.7);
        Console.WriteLine($"Sum of two doubles (10.5, 20.7): {sum3}");
    }
}
