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

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            {
                if (age <= 2)
                {
                    Console.WriteLine("Still in Mama's Arms");
                }
                else if (age <= 4)
                {
                    Console.WriteLine("Preschool Maniac");
                }
                else if (age <= 11)
                {
                    Console.WriteLine("Elementary School");
                }
                else if (age <= 14)
                {
                    Console.WriteLine("Middle School");
                }
                else if (age <= 18)
                {
                    Console.WriteLine("High School");
                }
                else if (age <= 22)
                {
                    Console.WriteLine("College");
                }
                else if (age <= 65)
                {
                    Console.WriteLine("Working For The Man");
                }
                else if (age <= 100)
                {
                    Console.WriteLine("Golden Years");
                }
                if (age <0 || age>100)
                {
                    Console.WriteLine("This Program is for Humans");
                }
            }





















            //double totalBill;
            //double grandTotal;

            //Console.WriteLine("How many diners are there?");
            //int peopleDining = int.Parse(Console.ReadLine());

            //Console.WriteLine("How much is each diner paying?");
            //double costPerDiner = double.Parse(Console.ReadLine());

            //totalBill = peopleDining * costPerDiner;

            //if (totalBill >= 50)
            //{
            //    double billDiscount = (totalBill * .10);
            //    grandTotal = (totalBill - billDiscount);
            //    Console.WriteLine("Congratulations, you will receive a 10% discount");
            //    Console.WriteLine("Your total bill is " + grandTotal);
            //}
            //else
            //{
            //    double billDiscount = (totalBill * .05);
            //    grandTotal = (totalBill - billDiscount);
            //    Console.WriteLine("Congratulations, you will receive a 5% discount");
            //    Console.WriteLine("Your total bill is " + grandTotal);

        //}
        }
    }

}
