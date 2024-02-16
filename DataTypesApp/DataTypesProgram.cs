using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int pieces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the total price of the apple(s): ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of " + pieces + " is " + price);                 
            Console.WriteLine("The value of original price is " + price);
            int totalPrice = (int)price;
            Console.WriteLine("The value of converted price is " + totalPrice);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
