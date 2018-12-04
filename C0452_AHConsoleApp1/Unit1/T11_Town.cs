using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0452_AHConsoleApp1.Unit1
{
    /// <summary>
    /// This class prompts the user to enter their
    /// name and town, and then comments on their entries
    /// 
    /// CO452 Unit 1: Task 1.1
    /// 02/12/2018 by Derek Peacock
    /// </summary>
    class T11_Town
    {
        private static string town;
        private static string name;

        public static void Check()
        {
            Console.Clear();

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Ashley's Town Checker     ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.Write("what is your name");
            name = Console.ReadLine();

            Console.WriteLine("Task 1: Hello there " + name + " !");
            Console.Write("Enter the town you live in >");

            town = Console.ReadLine();
            Console.WriteLine(town + " is a nice town!");
        }
    }
}
