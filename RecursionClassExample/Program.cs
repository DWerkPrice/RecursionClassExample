using System;

namespace RecursionClassExample
{
    class Program
    {
        static void Main(string[] args) {

            var fact = Factorial.factorial(10);
            Console.WriteLine($"10! = {fact}");

        }
    }
}
