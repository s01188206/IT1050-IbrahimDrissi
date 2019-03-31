using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number1; // declare first number to multiply 
            int number2; // declare second number to multiply 
            int product; // declare sum of number1 and number2 

            Console.Write("Enter first integer:");// prompt user 
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer:"); // prompt user 
            // read second number from user 
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 * number2; // multiply numbers

            Console.WriteLine("multiplication is: "+result);
            Console.ReadKey();

            Console.WriteLine("{0}\n{1}", "Hello World!", "From Ibrahim Drissi");

            Console.WriteLine("{0}\t{1}", "Hello World!", "From Ibrahim Drissi");
        }
        // a. the starting point of C# console application is Main method
        // b. Integer Type variable: it is a valued number with no decimal point
        //    Floating point: is a decimal number that contains a decimal point or an exponent or both.
        //c. displayMessage 
        //d. To read the value of an instance variable, we create method called a get accessor.  To assign a value ton instance variable, we use a method called a set accessor.
    }
}
