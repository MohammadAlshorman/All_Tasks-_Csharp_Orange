// Folder: CSharp_tasks
// File: 16.01.2025.cs

using System;

namespace CSharp_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Read string from user and print it
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("You entered: " + userInput);

            // Task 2: Define and display variables
            double myDouble = 10.5;
            string myString = "Hello, World!";
            char myChar = 'A';
            bool myBool = true;
            int myInt = 100;
            const string myConst = "This is constant";

            Console.WriteLine($"Double: {myDouble}");
            Console.WriteLine($"String: {myString}");
            Console.WriteLine($"Char: {myChar}");
            Console.WriteLine($"Bool: {myBool}");
            Console.WriteLine($"Int: {myInt}");
            Console.WriteLine($"Const: {myConst}");

            // Task 3: Define and display car array
            string[] cars = { "Toyota", "Honda", "Ford", "BMW" };
            Console.WriteLine("Cars in the array:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine($"Array length: {cars.Length}");

            // Task 4: Read and display personal details
            Console.Write("Input your firstname: ");
            string firstName = Console.ReadLine();

            Console.Write("Input your lastname: ");
            string lastName = Console.ReadLine();

            Console.Write("Input your year of birth: ");
            string yearOfBirth = Console.ReadLine();

            Console.WriteLine($"{firstName} {lastName} {yearOfBirth}");

            // Task 5: Store and display elements in an array
            int[] elements = new int[10];

            Console.WriteLine("Input 10 elements in the array:");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"element - {i} : ");
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in the array are:");
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
        }
    }
}


//Mohammad Al-shorman