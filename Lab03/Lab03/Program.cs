using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {//the if single-selection statement serves as a method to select or omitt and  an action to be performed based on a condition. The while repeition statement allows you to repeat an action while a condition remains true. the two methods shared the trait that they serve to control how an action is handled. they differ in terms of the condition
        
        static void Main(string[] args)
        {
            int speedLimit = 35;
            int speed = 42;
            if (speed > speedLimit)
                Console.WriteLine("SLOW NOW");
            bool isTrue = false;
            if (isTrue)
            {
                Console.WriteLine(isTrue = true);
            }
            else
            {
                Console.WriteLine(isTrue = false);

                int increment = 1;
                while (increment <= 10)
                {
                    Console.WriteLine("the value of x is :" + increment);
                    increment = increment + 1;
                }
                Console.ReadKey();

                int decrement = 60;
                while (decrement > 20)
                {
                    decrement = decrement - 5;

                    Console.WriteLine("the value of x is :" + decrement);
                }
                Console.ReadKey();
           
        
            }
            double celsius;
            Console.Write("Enter Faremheit temperature:");
            double farneheit = Convert.ToDouble(Console.ReadLine());
            celsius = (farneheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is" + celsius);
            Console.ReadLine();

        }
    }
    }
