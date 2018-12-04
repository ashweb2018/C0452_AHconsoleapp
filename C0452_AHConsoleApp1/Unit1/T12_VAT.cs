using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0452_AHConsoleApp1.Unit1
{
    /// <summary>
    /// This class calculates to amount of VAT on
    /// the price of an item
    /// 
    /// CO452 Unit 1: Task 1.2
    /// 02/12/2018 by Ashley Henney
    /// </summary>
    class T12_VAT
    {
        private static string input; // used to get input from the user
        private static decimal price; // the price of an item
        private static decimal vat; // the amount of vat
        private static decimal rate; // the current vat rate
        private static string name; // the name of the user

        public static void Calculate()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Ashley's VAT Calculator ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.Write("what is your name");
            name = Console.ReadLine();

            Console.Write("Enter the price of your item > " + name + " >");
            input = Console.ReadLine();
            price = Convert.ToDecimal(input);

            Console.Write("Enter the VAT rate > " + name + " >");
            input = Console.ReadLine();
            rate = Convert.ToDecimal(input);

            vat = 17.5m * price / 100;

            Console.WriteLine();
            Console.WriteLine("VAT Amount = " + vat);
            Console.WriteLine("VAT Rate = " + rate);
        }

    }
}
