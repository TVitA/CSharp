using System;

namespace AsyncMethods_async_await
{
    internal static class Program : Object
    {
        private static void Main(String[] args)
        {
            Console.WriteLine("Starting Main method...");

            Console.WriteLine("Test async method...");

            Console.WriteLine("Ending Main method...");
        }

        private static async void FactorialAsync()
        {
            Console.WriteLine("Starting FactorialAsync method...");



            Console.WriteLine("Ending FactorialAsync method...");
        }
    }
}
