using System;

namespace Methods_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: For each method call the AddSpaces() method to separate the answers!

            // TODO: Call the PrintGreeting() method

            // TODO: Call the SayHello() method

            // TODO: Call the GreetUser() method

            // TODO: Call the Exponentiate() method and store the returned value in a variable called result
            // TODO: Write result out to the console (display the result creatively)

            // TODO: Call the IsPrime() method and write out the result to the console
            // TODO: Creatively display the information to the console window

            //LDFJKLDJFLFJKLDJFKDLJFKLFJDLFJKLJfljkljd

        }

        // TODO: Create a public static method called AddSpaces() which creates 2 blank lines when called
        // and does NOT **return** anything
        public static void AddSpaces()
        {
            Console.WriteLine("                                               ");
        }


        // TODO: Create a public static method called PrintGreeting() with a return type of void that takes no parameters,
        // and writes to the console "Hello World!"
        public static void PrintGreeting()
        {
            Console.WriteLine("Hello World");
        }


        // TODO: Create a public static method called SayHello() with a return type of void which takes 2 parameters firstName & lastName,
        // and concatenates them into a sentence Ex: "Hello, John Smith!" then writes them to the console
        public static void SayHello(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}");
        }


        // TODO: Create a method called GreetUser() that asks the user for their name
        // then greets them with that name to the console (don't forget to prompt the user to enter their name!)
        public static void GreetUser(string userName)
        {
            Console.WriteLine("Hey user! What's your name?");
            userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}, welcome!");
        }


        // TODO: Create a method called Exponentiate() that asks the user for a number and a powerOF
        // and then calculates the result of raising the first to the second (don't forget to prompt the user to enter the 2 numbers!)
        public static double Exponentiate()
        {
            Console.WriteLine("Enter a number");
            var number = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power");
            var userExponent = double.Parse(Console.ReadLine());

            return Math.Pow(number, userExponent);
            
        }


        // TODO: Create a method called IsPrime() that asks the user for a number then returns true if the number is prime or false otherwise
        // (don't forget to prompt the user to enter the number!)
        public static bool IsPrime(int num)
        {
            Console.WriteLine("Enter a number to check if it is prime");

            num = int.Parse(Console.ReadLine());

            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                return false;
            }
            return true;

        }
    }
}
