using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
           //A one-Dimensional array p contains four elements. the array access expressions to access each of the elements in p are :
           // Array initializer, array creation, array element access, and array members.

           
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "Feberuary";
            months[2] = "Mars";
            months[3] = "April";
            months[4] = "May";
            months[5] = "July";
            months[6] = "June";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "Novomber";
            months[11] = "December";
            for (int x = 0; x <= months.Length - 1; x++)
            {
                Console.WriteLine(months[x]);
            }
            string[] Seasons = new string[4];
            Seasons[0] = "Winter";
            Seasons[1] = "Spring";
            Seasons[2] = "Summer";
            Seasons[3] = "Fall";

            foreach (string k in Seasons)
            {
                Console.WriteLine(k);
            }


            int[] Numbers = new int[1000];

            foreach (int N in Numbers)
            {
                Random random = new Random();
                int randomNumber;
                randomNumber = random.Next(1, 1000);
                Console.WriteLine(randomNumber);
            }

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            for (int i = 0; i < names.Length; i++)
            {

                string name = names[i];

                Console.WriteLine(names[i]);
            }

            // could not feiguer out question number , still working on it though. 

            string[] nemes = { "Al Dente", "Anna Graham", "Earl Bird", "Ginger Rayle", "Iona Ford" };

            foreach (string b in nemes)
            {
                Console.WriteLine(b);


            
        }
            }


        }
    }
