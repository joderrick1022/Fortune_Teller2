using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine().ToLower();

            Console.WriteLine("what is your Last name? + \a");
            string lastName = Console.ReadLine().ToLower();



            Console.WriteLine("What is your age? numbers only please EX(1,25,6,7,76)");
            int userAge = int.Parse(Console.ReadLine());

            int retireIn = 0;  


           
            string fullName = firstName + " " + lastName;

            if (userAge % 2 != 0)
            {
                retireIn = (userAge - 66);

            }
            else if (userAge % 2 == 0)
            {
                retireIn = (userAge - 66);
            }


            Console.WriteLine("What month were you born? EX(01, 01, 03 ,08)");
            int birthMonth = int.Parse(Console.ReadLine());
            double money = 0;


            //int jan = 01;
            //int feb = 02;
            //int mar = 03;
            //int apr = 04;
            //int may = 05;
            //int jun = 06;
            //int jul = 07;
            //int aug = 08;
            //int sep = 09;
            //int oct = 10;
            //int nov = 11;
            //int dec = 12;

            if (birthMonth <= 4 && birthMonth > 0)
            {
                money = 300000000.00;
            }
            else if (birthMonth > 4 && birthMonth < 9)
            {
                money = 600000000.00;
            }
            else if (birthMonth > 9 && birthMonth <= 12)
            {
                money = 90000000.00;
            }
            if (birthMonth < 0 && birthMonth > 12)
            {
                money = 00000.00;
            }

            string transportation = ("");
            Console.WriteLine("What is your favorite ROYGBIV color? If need help understanding what ROYGBIV colors are please enter (help)");
            string favColor = Console.ReadLine().ToLower();
            bool red = (favColor == "red");
            bool orange = (favColor == "orange");
            bool yellow = (favColor == " yellow");
            bool green = (favColor == "green");
            bool blue = (favColor == "blue");
            bool indigo = (favColor == "indigo");
            bool violet = (favColor == "violet");

            string help = ("red, orange, yellow, green, blue, indigo, violet");
            bool helper = (favColor == "help");


            if (helper)
            {
                Console.WriteLine(help);


            }


            if (red)
            {
                transportation = ("boat");
            }
            if (orange)
            {
                transportation = ("train");
            }
            if (yellow)
            {
                transportation = ("air plain");
            }
            if (green)
            {
                transportation = ("ferry");
            }
            if (blue)
            {
                transportation = ("helicopter");
            }
            else if (indigo)
            {
                transportation = ("rapid transit");
            }
            if (violet)
            {
                transportation = ("jet");
            }





            string location = (" ");
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());


            int zero = 0;
            int one = 1;
            int two = 2;
            int three = 3;
            bool four = (siblings < 0 && siblings > 4);
            bool neg = (siblings < 0);


            if (siblings == zero)
            {
                location = ("Africa");

            }

            else if (siblings == one)
            {
                location = ("Russia");

            }

            else if (siblings == two)
            {
                location = ("North Pole ");

            }
            else if (siblings == 3)
            {
                location = ("North Pole ");

            }
            else if (siblings == two)
            {
                location = ("North Pole ");

            }else if (siblings <= 0 || siblings >= 5)
            {
                location = ("North Korea");
            }



            Console.WriteLine(fullName + " will retire " + retireIn + " Years with  " + money + "  in the bank, \n a vacation home in  " + location + "   " + " \n and you will have a " + transportation + " as a means of for Transportation.");





        }
    }
}
