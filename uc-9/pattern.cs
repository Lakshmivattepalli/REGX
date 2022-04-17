
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class Patterns
    {
        public static void FirstName(string name1)
        {
            string FirstName = "^[A-Z][a-zA-Z]{1,10}$";
            Regex regex = new Regex(FirstName);
            if (regex.IsMatch(name1))
            {
                Console.WriteLine(name1 + " is valid name");
            }
            else
            {
                Console.WriteLine(name1 + " is invalid. Please Enter First name start with capital letter and maximum 10 charactors");
            }
        }

        public static void LastName(string name2)
        {
            string LastName = "^[A-Z][a-zA-Z]{1,10}$";
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(name2))
            {
                Console.WriteLine(name2 + " is valid name");
            }
            else
            {
                Console.WriteLine(name2 + " is invalid. Please Enter First name start with capital letter and maximum 10 charactors");
            }
        }

        public static void Email(string name3)
        {
            string Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(Email);
            if (regex.IsMatch(name3))
            {
                Console.WriteLine(name3 + " is valid name");
            }
            else
            {
                Console.WriteLine(name3 + " is invalid.");
            }
        }

        public static void MobileNumber(string name4)
        {
            string MobileNumber = "(0|91)?[ ][6-9][0-9]{9}";
            Regex regex = new Regex(MobileNumber);
            if (regex.IsMatch(name4))
            {
                Console.WriteLine(name4 + " is valid name");
            }
            else
            {
                Console.WriteLine(name4 + " is invalid.");
            }
        }

        public static void Password(string name5)
        {
            string Password = "^.*(?=.{8,})(?=.*)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
            Regex regex = new Regex(Password);
            if (regex.IsMatch(name5))
            {
                Console.WriteLine(name5 + " is valid name");
            }
            else
            {
                Console.WriteLine(name5 + " is invalid.");
            }
        }
    }
}