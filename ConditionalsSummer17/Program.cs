using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsSummer17
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalBill;
            double grandTotal;

            Console.WriteLine("How many diners are there?");
            int peopleDining = int.Parse(Console.ReadLine());

            Console.WriteLine("How much is each diner paying?");
            double costPerDiner = double.Parse(Console.ReadLine());

            totalBill = peopleDining * costPerDiner;

            if (totalBill >= 50)
            {
                double billDiscount = (totalBill * .10);
                grandTotal = (totalBill - billDiscount);
                Console.WriteLine("Congratulations, you will receive a 10% discount");
                Console.WriteLine("Your total bill is " + grandTotal);
            }
            else
            {
                double billDiscount = (totalBill * .05);
                grandTotal = (totalBill - billDiscount);
                Console.WriteLine("Congratulations, you will receive a 5% discount");
                Console.WriteLine("Your total bill is " + grandTotal);
                
            }
        }
    }
}
