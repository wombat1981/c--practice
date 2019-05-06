using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers");

            string word_1;
            string word_2;

            word_1 = Console.ReadLine();
            word_2 = Console.ReadLine();

            int num_1;
            int num_2;

            //these two lines convert word_1 and word_2 into ints and assign to num_1 and num_2 respectively
            num_1 = int.Parse(word_1);
            num_2 = int.Parse(word_2);

            Console.WriteLine(num_1 + num_2);
            Console.ReadLine();

        }
    }
}
