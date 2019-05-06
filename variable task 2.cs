using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_task
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your Surname");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Enter your user id");
            string userid = Console.ReadLine();
            Console.WriteLine("Enter your Year of birth");
            string birthyear = Console.ReadLine();
            Console.WriteLine("Enter the current year");
            string currentyear = Console.ReadLine();

            int id = int.Parse(userid);
            int Birth = int.Parse(birthyear);
            int Current = int.Parse(currentyear);
            int total = (Current - Birth);
            
            Console.WriteLine("Hello " + firstname +"\n" + Lastname + "\n" + id + "\n" +  total );
            Console.ReadLine();




            /*
                        Write a C# Console application that has the following functionality:

            Ask for and read the user's first name;
            Ask for and read the user's surname;
            Ask for and read the user's studentID;
            Ask for and read the user's year of birth;
            Ask for and read the current year;
                        Display the user's first name and surname and age;
            Example output:

            Enter first name:

                        Joe

                        Enter surname:

                        Bloggs

                        Enter StudentID:

                        12345678

            Enter year of birth:

            1950

            Enter current year:

                        2017




            Joe Bloggs

            67
            */
        }
    }
}
