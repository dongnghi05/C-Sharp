using System;

/* Understanding Data Types 
 * 
 * 1.What type would you choose for the following “numbers”? 
 * A person’s telephone number: string
 * A person’s height: double
 * A person’s age: uint
 * A person’s gender (Male, Female, Prefer Not To Answer): enum
 * A person’s salary: uint
 * A book’s ISBN: string
 * A book’s price: double
 * A book’s shipping weight: double 
 * A country’s population: uint
 * The number of stars in the universe: ulong
 * The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) 
 * 
 * 2.What are the difference between value type and reference type variables? What is boxing and unboxing?
 * Value Type:
 * - Directly hold the value
 * - Stored in Stack memory
 * - Not be collected by garbage collector
 * - Can be created by Enum, Stuct
 * - Not accepted NULL value
 * 
 * Reference Type:
 * - Hold the memory address or reference for the value
 * - Stored in Heap memory
 * - Can be collected by garbage collector
 * - Can ve created by Inferface, Class, Delegate, Array
 * - Can accept NULL value
 * 
 * Boxing: convert value type to reference type
 * Unboxing: convert reference type to value
 * 
 * 
 * 3.What is meant by the terms managed resource and unmanaged resource in .NET
 * - Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. 
 * - Unmanaged resources are those that are not. 
 * 
 * 
 * 4.Whats the purpose of Garbage Collector in .NET? 
 * Garbage Collector: automatic memory manager
 * Benefits:
 * - Don’t need to manually release memory
 * - Allocates objects on managed heap efficiently
 * 
 */


/* Controlling Flow and Converting Types 
 * 
 * 1. What happens when you divide an int variable by 0? 
 * - Throw a DivideByZeroException exception
 * 
 * 2. What happens when you divide a double variable by 0? 
 * - Does not throw the exception, it results in positive infinity, negative infinity, or not a number (NaN),
 * 
 * 3. What happens when you overflow an int variable, that is, set it to a value beyond its range? 
 * - Throw the out of bound exception
 * 
 * 4. What is the difference between x = y++; and x = ++y;? 
 * 
 * x = y++
 * - x = y
 * - y = y + 1
 * 
 * x = ++y
 * - y = y + 1
 * - x = y
 * 
 * 
 * 5. What is the difference between break, continue, and return when used inside a loop statement? 
 * - The break statement results in the termination of the loop, it will come out of the loop and stops further iterations. 
 * - The continue statement stops the current execution of the iteration and proceeds to the next iteration. 
 * - The return statement takes you out of the method. 
 * 
 *
 * 6. What are the three parts of a for statement and which of them are required? 
 * - The initializtion: a counter variable to start
 * - The condition to evaluate for the next iteration
 * - Iteration: increase or descrease counter
 * 
 * 7. What is the difference between the = and == operators?
 * - = Assign the value
 * - == Equal operation (to compare)
 * 
 * 8. Does the following statement compile? for ( ; true; ) ; 
 * 
 * 
 * 9. What does the underscore _ represent in a switch expression? 
 * Same with default case in switch.
 *  1 => "Case 1",  
 *  2 => "Case 2",  
 *  3 => "Case 3",  
 *  4 => "Case 4",  
 *  _ => "No case availabe" ( _ or default)
 * 
 * 10. What interface must an object implement to be enumerated over by using the foreach statement?
 * 
 * 
 */


namespace Assignment_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Practice loops and operators");
            Console.WriteLine("---- FizzBuzz ----");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            /*
             * int max = 500;
             * for (byte i = 0; i < max; i++) {
             *    Console.WriteLine(i);
             * }
             * 
             * Infinite loop because the range of Byte is from 0 to 255
             */

            Console.WriteLine("---- Guess Number ----");
            Console.WriteLine("Guess number from 1 to 3");
            int guessedNumber = int.Parse(Console.ReadLine());
            int correctNumber = new Random().Next(3) + 1;
            while (true)
            {
                if (guessedNumber == correctNumber)
                {
                    Console.WriteLine("Correct");
                    break;
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("Too High");
                }
                else
                {
                    Console.WriteLine("Too Low");
                }

                Console.WriteLine("Guess number from 1 to 3");
                guessedNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("---- Print-a-Pyramid -----");
            int n = 5;
            int start = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < start; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                start += 2;
            }

            Console.WriteLine("---- Representing a Birthday ----");


            Console.WriteLine("---- Greeting Message ----");
            Console.WriteLine(DateTime.Now);
            int hour = DateTime.Now.Hour;
            if (hour >= 5 && hour < 12)
                Console.WriteLine("Good Morning!");
            if (hour >= 12 && hour < 17)
                Console.WriteLine("Good Afternoon!");
            if (hour >= 17 && hour < 21)
                Console.WriteLine("Good Evening!");
            if (hour >= 21 || hour < 5)
                Console.WriteLine("Good Night!");


            Console.WriteLine("---- Counting up to 24 ----");
            for (int line = 1; line <= 4; line++)
            {
                for (int count = 0; count <= 24; count= count + line)
                {
                    Console.Write(count + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
