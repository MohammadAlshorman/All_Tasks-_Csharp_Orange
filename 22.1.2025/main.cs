using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        public class Vechils
        {
            public string Brand { get; set; }
            public int model { get; set; }

            public void start()
            {
                Console.WriteLine($"Vehicle is starting.{Brand } { model}");
            }
        }
        public class Derived : Vechils
        {

            public int NumberOfDoors { get; set; }



        }
        static void Main(string[] args)
        {
            Derived s = new Derived();
            s.model = 2025;
            s.Brand = " BMW";
            s.start();
        }
    }
}


//What is constructor ? when i want to give the property value 

//What are the basic concepts of OOPs ? 1. Encapsulation 2. Inheritance 3.    Polymorphism 4.    Abstraction

//What is the Encapsulation ? get the privet value and edit it and shaer it 

//What is the sealed class ? class cant shaer thier informtion

//What is the Inheritance concept ? share th informain in classes