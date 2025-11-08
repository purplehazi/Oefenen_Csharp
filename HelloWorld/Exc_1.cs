using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exc_1
    {
        /*
         * Define a variable to hold your name
         * Define a variable to hold your phone number
         * Define a variable to hold your age
         * Print variables line by line to the screen
         * Extra: Define variables using the var keyword
         */

        public static void Excercise1(string[] args)
        {
            string name = "Hazi";
            string phoneNumber = "0648771334";
            int age = 20;

            var name2 = "Hazi";
            var phoneNumber2 = "0648771334";
            var age2 = 20;

            Console.WriteLine(name);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(age);

            Console.WriteLine(name2);
            Console.WriteLine(phoneNumber2);
            Console.WriteLine(age2);

            Console.ReadLine();
        }




    }
}
