
using System;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");
            Console.WriteLine("Write your Email ex : example123@gmail.com your can write yahoo and any other mail ID.");
            Console.Write("\n Enter Email : ");
            string name = Console.ReadLine();
            Patterns.Email(name);
        }
    }
}
