
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class Patterns
    {
        public static void FirstName(string name)
        {
            string FirstName = "^[A-Z][a-zA-Z]{1,10}$";
            Regex regex = new Regex(FirstName);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            else
            {
                Console.WriteLine(name + " is invalid. Please Enter First name start with capital letter and maximum 10 charactors");
            }
        }
    }
}
