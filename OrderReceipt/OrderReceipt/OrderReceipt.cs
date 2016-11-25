/* Programmer: Moses Byanyuma
 * Date: 11/24/2016
 * Application: Prompts for user information regarding a blender transaction
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderReceipt
{
   public class OrderReceipt
    {
        static void Main(string[] args)
        {
            const double BLENDER_PRICE = 39.95;
            string name, streetAddress, city, state, zipCode;
            double quantity, amountDue, salesTax, netDue;

            Console.Write("Enter your name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Street Address: ");
            streetAddress = Convert.ToString(Console.ReadLine());
            Console.Write("City: ");
            city = Convert.ToString(Console.ReadLine());
            Console.Write("State: ");
            state = Convert.ToString(Console.ReadLine());
            Console.Write("Zip code: ");
            zipCode = Convert.ToString(Console.ReadLine());
            Console.Write("How many magic blenders do you want to order? ");
            quantity = Convert.ToDouble(Console.ReadLine());

            amountDue = BLENDER_PRICE * quantity;
            salesTax = amountDue * 0.07;
            netDue = amountDue + salesTax;

            Console.WriteLine("\nReceipt for:\n {0}", name);
            Console.WriteLine(streetAddress);
            Console.WriteLine("{0}, {1} {2}", city, state, zipCode);
            Console.WriteLine("\n{0} blenders ordered @{1} each", quantity, BLENDER_PRICE.ToString("C"));
            Console.WriteLine("\nTotal:\t {0}", amountDue.ToString("C"));
            Console.WriteLine("Tax:\t {0}", salesTax.ToString("C"));
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nDue:\t {0}", netDue.ToString("C"));

            Console.WriteLine("\n\t\tPress any key to terminate application");
            Console.ReadKey();


        }
    }
}
