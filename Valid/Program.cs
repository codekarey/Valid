using System;
using System.Text.RegularExpressions;

namespace Valid
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop on request
            bool yes = true;
            while (yes)
            {
            Console.WriteLine("Please enter your information below to be validated.");
                string name = Name();
                string email = Email();
                string phone = Phone();
                string dob = Dob();
                string time = Time();
                Console.WriteLine("Thank you " + name + ", for entering vaild information.\nEmail: " + email + "\nPhone: " + phone + "\nDOB: " + dob + "\nTime: " + time);
                yes = Loop();
            }
        }
        public static bool Loop()
        {
            Console.WriteLine("Enter y if you'd like to validate information again.");
            if (Console.ReadLine().ToLower() != "y")
            {
                return false;
            }
            return true;
        }
        public static string Name()
        {
            string name = "";
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("First and Last name:");
                name = Console.ReadLine();
                if (Regex.IsMatch(name, @"^([A-Z]{1})([a-z]{1,30})\s([A-Z]{1}[a-z]{1,30})$"))
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Make sure you have a space and capitalize your 'First Last' name.");
                    loop = Loop();
                }
            }
            return name;
        }
        public static string Email()
        {
            string email = "";
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("A valid email:");
                email = Console.ReadLine();
                if (Regex.IsMatch(email, @"^(([A-Z]|[a-z]|\d){5,30}@([A-Z]|[a-z]|\d){5,10}.([A-Z]|[a-z]|\d){2,3})$"))
                {
                    return email;
                }
                else
                {
                    Console.WriteLine("Make sure you include @ and . like so: _____@__.___");
                    loop = Loop();
                }
            }
            return email;

        }
        public static string Phone()
        {
            string phone = "";
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("A valid phone number:");
                phone = Console.ReadLine();
                if (Regex.IsMatch(phone, @"^(\d?[-]?[(]\d{3}[)][-][(]?[0-9]{3}[)]?-[(]?[0-9]{4}[)]?)$"))
                {
                    return phone;
                }
                else
                {
                    Console.WriteLine("Make sure you seperate the number with () or - like so: 1(999)999-9999");
                    loop = Loop();
                }
            }
            return phone;

        }
        public static string Dob()
        {
            string dob = "";
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Your date of birth:");
                dob = Console.ReadLine();
                if (Regex.IsMatch(dob, @"^([0-9]{2}[/][0-9]{2}[/][0-9]{4})$"))
                {
                    return dob;
                }
                else
                {
                    Console.WriteLine("Make sure its in the form MM-DD-YYYY.");
                    loop = Loop();
                }
            }
            return dob;

        }
        public static string Time()
        {
            string time = "";
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("The current time in the form HH:MM :");
                time = Console.ReadLine();
                if (Regex.IsMatch(time, @"^([0-9]{2}[:][0-9]{2})$"))
                {
                    return time;
                }
                else
                {
                    Console.WriteLine("Make sure ");
                    loop = Loop();
                }
            }
            return time;

        }
    }
}
