using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace c_training
{
    internal class Program
    {  
        //method overloading
        public float MethodLearn(float x, float y)
        {
            return x * y;
        }
        //method
        public int MethodLearn(int a=2,int b = 3)
        {
            Console.WriteLine("inside function:"+a);
            return a + b; 
        }
        //ARRAY operations
        public void ArrayOperation()
        {
            string[] name = { "ann", "mary", "babu", "rose" };
            Array.Sort(name);
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
            int[,] arr = { { 1, 2,5 }, { 3, 4,8} };
            Console.WriteLine(arr[0,1]);
            Console.WriteLine(arr.GetLength(1));
        }
        //exception handling
        public void ExeptionHandling()
        {
            try {
                int n = 6;
                int m=n / 0;
                Console.WriteLine(m);
            }
            catch {
                Console.WriteLine("cannot divided by 0");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            int age = 9;
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
        //while loop
        public void WhileLoop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

        }
        // forloop
        public void ForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);
                }
            }
            //for each loops execute only in array
            string[] name = { "ann", "mary", "babu", "rose" };
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
        }
        // switch
        public void SwitchLearn()
        {
            int x = 2;
            switch(x)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
            }
        }
        //condition
        public void Condition()
        {
            int x = 5;
            int y=6;
            if (x > y) Console.WriteLine(x + " is greater");
            else if (y > x) Console.WriteLine(y + " is greater");
            else Console.WriteLine("both are same");
            string ans = (x > y) ? x + " is greater" : y + " is greater";
            Console.WriteLine(ans);
        }
        //basic operations
        public void Variable()
        {
            const int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            double doubleNum = myNum;
            int myInt = (int)myDoubleNum;
            string myText = "Hello";
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);
            Console.WriteLine(Convert.ToString(myNum));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myNum));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubleNum));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));
            String name=Console.ReadLine();
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("my name is "+name+" and age is "+age);
            int x = 5;
            int y = 3;
            Console.WriteLine(x > y);
            Console.WriteLine(Math.Round(9.99));
            Console.WriteLine(Math.Max(4,5));
            Console.WriteLine(Math.Min(2,3));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(myText.Length);
            Console.WriteLine(myText.ToUpper());
            Console.WriteLine(myText.ToLower());
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.Variable();
            //obj.Condition();
            //obj.SwitchLearn();
            //obj.WhileLoop();
            //obj.ForLoop();
            //obj.ExeptionHandling();
            obj.ArrayOperation();
            int answer =obj.MethodLearn(5, 6);
            Console.WriteLine(answer);
            //int namingAnswer = obj.MethodLearn(a:7,b:9);
            //Console.WriteLine(namingAnswer);
            float overloadingAnswer = obj.MethodLearn(5.9f, 1.9f);
            Console.WriteLine(overloadingAnswer);
        }
    }
}
