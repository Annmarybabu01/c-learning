using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static advancec_.Program;

namespace advancec_
{ 
    internal class Program
    {
        //event handler
        public delegate void ClickEventHandler(object sender, EventArgs e);
        // Define the Button class with an event
        public class Button
        {
            // Declare the handler
            public event ClickEventHandler ClickEvent;
            // Method to raise the ClickEvent
            protected virtual void OnClick(EventArgs e)
            {
                ClickEvent?.Invoke(this, e);
            }
            public void SimulateClick()
            {
                OnClick(EventArgs.Empty);// It represents an empty set of event arguments.
            }
        }
        //delegate
        public delegate void MyDelegate(string message);
        public static void MyMethod(string message)
        {
            Console.WriteLine("MyMethod: " + message);
        }
        static void Main(string[] args)
        {
            //MyDelegate del = new MyDelegate(MyMethod); //del acts as a reference to MyMethod.
            //del("Hello, Delegates!");
            Console.WriteLine("Press A to simulate a button click");
            var key=Console.ReadLine();
            if (key == "a") {
                keyPressed();
            }
        }
        static void keyPressed()
        {
           // Create a Button instance
            Button button = new Button();
            // Subscribe to the ClickEvent
            button.ClickEvent += (s, args) => //delegates subscribed using += will be invoked.=> means inline event handler, s=>sender,args is event arguments
            {
                Console.WriteLine("Clicked a button");
            };

            // Simulate a button click
            button.SimulateClick();
            //linq
            Console.WriteLine("using linq");
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;

            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            //lamba expression
            Console.WriteLine("using lambda");
            var evenNumbersLambda = numbers.Where(n => n % 2 == 0);
            foreach (var number in evenNumbersLambda)
            {
                Console.WriteLine(number);
            }
        }
    }
}

