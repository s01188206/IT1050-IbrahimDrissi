using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            //the three types of control structures are:
            //1. Selection structure: it instructs the program to follow a certain flow based upon whether a certain condition is true or false. we use statements such as "if", "if...else" to structure those conditions.
            //2. repetition structure : it instructs the program to repeat a certain task as long as a certain condition is fulfilled. The statements we use to perform iteration are : "for", "while", "do..while"
            //3. sequence structure : it instructs the program to perform tasks in a certain sequence (the same order they appear in the code line). 



            bool i = true;
            while (i == true)
            {
                Console.WriteLine("keeplooping");

            }




            int w = 2;
            while (w <= 128)
            {
                Console.WriteLine(" [{0}]", w++);
                w++;


                if (w == 64)
                {
                    break;
                }
              
               
            }
            Console.ReadLine();



            for (int c = 49; c > 0; c--)
                Console.Write("{0}, ", c);



            int f = 1;
            while (f <= 21)
            {
                Console.Write(" {0}", f);
                f++;
            }



            //.7.the output of the code in question 7 is: *
            //.8. if we use the while statement there would not be any output (blank) because the condition is not fullfiled.



            bool icyRain = false;
            bool tornadoWarning = false;
            if ((icyRain = false) || (tornadoWarning = false))
                Console.WriteLine("Let's go outside: {0}", icyRain);
            Console.WriteLine("Let's go outside:{0}", tornadoWarning);





            for (int n = 1; n <= 5; n++) // could not figuer out how to reverse the count in this line.

            {

                for (int s = 1; s <= (6 - n); s++) 
                {
                    Console.Write(s + " ");
                }



                Console.WriteLine();



            }




        }

    }
}





 
   



        
   