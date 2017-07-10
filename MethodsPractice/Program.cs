using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods are a tool for us to create reusable pieces of code.

            //Methods are a way of us collecting a series of instructions and then call them when we need them.

            //Methods are always part of a class. Methods are ALWAYS children of classes.
            //This means a method will NEVER be created inside another method or member of the class.
            //However, methods are frequently CALLED inside of another class or method.

            Console.WriteLine("Hello. Please enter the first number to be added.");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number to be added.");
            int numberTwo = int.Parse(Console.ReadLine());

            int answer = Add(numberOne, numberTwo);
            Console.WriteLine("The Answer is: " + answer);
        }
        //Method Header
        //Access Modifier - Return Type - Method Name (in Pascal Case) - Parentheses (Sometimes with parameters)
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method Body
            //A complete method - header and body - is called a method declaration
            int sum = firstNumber + secondNumber;

            return sum;
            //The 'return' keyword takes whatever value is determined by using this method 
            //and sends that value back to where i called my method
        }
        //if you have a method that does not have a return value, you would use the keyword 'void'.
        //When we have a 'void' return type, we DON'T need to use the keyword 'return'.
    }
}
