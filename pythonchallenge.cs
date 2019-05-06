using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace python
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 1.
            Console.WriteLine("enter number");
            string number = Console.ReadLine();
            int numb = int.Parse(number);

            if (numb % 2 ==0)
            {
                Console.WriteLine("This is an even number");
            }
            else
                {
                    Console.WriteLine("This number is odd");
                }
            Console.ReadLine();
            /*
             Exercise 2.
                Console.WriteLine("enter number");
                string number = Console.ReadLine();
                int numb = int.Parse(number);
            if ((numb % 4) == 0)  
            {
                Console.WriteLine("this is a multiple of 4.  " + numb);
            }
            Console.ReadLine();
            */
            /*
             Exercise 3.
            Console.WriteLine("enter first number");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            Console.WriteLine("divide by");
            string checktwo = Console.ReadLine();
            int check = int.Parse(checktwo);

            if ((num % check) == 0)
            {
                Console.WriteLine("This number divides evenly with your first number");
            }
            else
            {
                Console.WriteLine("Does not divide evenly");
            }
            Console.ReadLine();
            */
            /*
           Exercise 2 (and Solution)
Ask the user for a number. Depending on whether the number is even or odd, print out an appropriate message to the user. Hint: how does an even / odd number react differently when divided by 2?
Extras:
If the number is a multiple of 4, print out a different message.
Ask the user for two numbers: one number to check (call it num) and one number to divide by (check). If check divides evenly into num, tell that to the user. If not, print a different appropriate message.
             */
        }
    }
}
