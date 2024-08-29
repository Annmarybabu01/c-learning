using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asynandwait
{
    internal class Program
    {
        public static async Task<string> GetGreetingAsync()
        {
            // Simulate a delay
            await Task.Delay(1000); // Waits for 1 second asynchronously
            // Return a greeting message
            return "Hello, world!";
        }
        // An asynchronous method that calls another async method
        public static async Task ShowGreetingAsync()
        {
            // Call the async method and await its result
            string greeting = await GetGreetingAsync();
            // Print the result to the console
            Console.WriteLine(greeting);
        }
        // Main method to run the application
        public static async Task Main(string[] args)
        {
            // Call the async method to show the greeting
            await ShowGreetingAsync();
        }
    }
}
