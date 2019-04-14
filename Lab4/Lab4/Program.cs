using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //A.the basic elements of the counter-controlled repetition 
            //1. control variable (or loop counter): determines the number of executions of the repetition.
            //2. Initial value of counter variable: the starting point of the counter value
            //3. increment or decrement (iteration of the loop): which increases or decreases the value of counter variable, without it we get an infinite loop.
            //3. loop-continuation condition: that determines the limit of the repetition. there should be a limit or we get a infinite loop as well.
            //B. the FOR vs WHILE repetition statements: 
            //while loop is used when we need to repeat something until a certain condition is rendered false.
            //(so we do not know beforehand how many times the repetition will take place)
            //For loop is used we simply need to repeat a value, the loop control statements are kept together and in plain view at the top of the loop.
            //C. it is better to use Do... While in cases where we want the loop to execute at least once.
            // for instance when we try to access a resource that would need a retry, because do...while will excute the loop at least once before it checks the condition. 

            for (int i = 1; i <= 100; ++i)
            {
                Console.WriteLine("{0} ", i);
                if ((i % 2) == 0)
                {
                    Console.WriteLine(" i is even");
                }
                else
                {
                    Console.WriteLine("counter i is odd");
                }
            }
            {
                Console.WriteLine("Enter a temperature as int value: ");
                int intTemp = Convert.ToInt32(Console.ReadLine());
                if (intTemp < 10)
                    Console.WriteLine("Polar Bear");
                if (intTemp < 20)
                    Console.WriteLine("Penguin");
                if (intTemp < 40)
                    Console.WriteLine("Moose");
                if (intTemp < 50)
                    Console.WriteLine("Reindeer");
                if (intTemp < 60)
                    Console.WriteLine("Deer");
                if (intTemp < 70)
                    Console.WriteLine("Turtle");
                if (intTemp < 80)
                    Console.WriteLine("Lion");
                if (intTemp < 90)
                    Console.WriteLine("Fish");
            }
            {
                int a = 10;
                while (a <= 20)
                {
                    Console.WriteLine("value of a: {0}", a);
                    a++;
                }
                {
                    for (int i = 0; i < 101; i++)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine("********");
                    }
                }
            }
        }
    }
}
        
    

