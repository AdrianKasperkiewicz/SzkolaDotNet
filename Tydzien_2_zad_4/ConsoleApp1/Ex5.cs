using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Ex5
    {
        public string Name;
        public string LastName;
        public string TelephoneNumber;
        public string Growth;
        public string Email;
        public string Weight;
        public string ShoeSize;
        public string City;
        public string Street;
        public string StreetNumber;
        public string PersonalId;
        public void PersonalData()
        {
            Console.WriteLine("Enter your name");
            Name = Console.ReadLine();
            NameIsValid();

            Console.WriteLine("Enter your last name");
            LastName = Console.ReadLine();
            LastNameIsValid();

            Console.WriteLine("Enter your telephone number");
            TelephoneNumber = Console.ReadLine();
            TelephoneNumberIsValid();

            Console.WriteLine("Enter your growth");
            Growth = Console.ReadLine();
            GrowthIsValid();

            Console.WriteLine("Enter your emai");
            Email = Console.ReadLine();
            EmailIdValid();

            Console.WriteLine("Enter your weight");
            Weight = Console.ReadLine();
            WeightIsValid();

            Console.WriteLine("Enter your shoe size");
            ShoeSize = Console.ReadLine();
            ShoeSizeIsValid();

            Console.WriteLine("Enter your city");
            City = Console.ReadLine();
            Console.WriteLine($"OK!! You live in {City}");
            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();

            Console.WriteLine("Enter your street");
            Street = Console.ReadLine();
            Console.WriteLine($"OK!! You live in {Street} street");
            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();

            Console.WriteLine("Enter your street number");
            StreetNumber = Console.ReadLine();
            StreetNumberIsValid();

            Console.WriteLine("Enter your personal id");
            PersonalId = Console.ReadLine();
            PersonalIdIsValid();
        }
        public void NameIsValid()
        {
            if (!Regex.Match(Name, "^[A-Z][a-zA-Z]*$").Success)
                Console.WriteLine("Wrong name");
            else
                Console.WriteLine($"Your name is: '{Name}'");
            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();
        }

        public void LastNameIsValid()
        {
            if (!Regex.Match(LastName, "^[A-Z][a-zA-Z]*$").Success)
                Console.WriteLine("Wrong name");
            else
                Console.WriteLine($"Your name is: '{LastName}'");
            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();
        }
        public void TelephoneNumberIsValid()
        {
            int number;
            bool parse = Int32.TryParse(TelephoneNumber, out number);
            if (parse)
                Console.WriteLine($"Your telephone number : {number}");
            else
                Console.WriteLine($"Cannot parse {TelephoneNumber}");

            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();
        }
        public void EmailIdValid()
        {
            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            bool isValid = Regex.IsMatch(Email, regex, RegexOptions.Compiled);

            if (isValid == true)
                Console.WriteLine("Email address is correct");
            else if (isValid == false)
                Console.WriteLine("Email address is incorrect");

            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();
        }
        public void GrowthIsValid()
        {
            int number;
            bool parse = Int32.TryParse(Growth, out number);
            if (parse)
                Console.WriteLine($"Your growth : {number}");
            else
                Console.WriteLine($"Cannot parse {Growth}");

            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();
        }
        public void WeightIsValid()
        {

            int number;
            bool parse = Int32.TryParse(Weight, out number);
            if (parse)
                Console.WriteLine($"Your weight : {number}");
            else
                Console.WriteLine($"Cannot parse {Weight}");
            
            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();
        }
        public void ShoeSizeIsValid()
        {
            int number;
            bool parse = Int32.TryParse(ShoeSize, out number);
                if (number <= 60 & number >= 5)
                    Console.WriteLine($"All OK. Your Shoe size is : {number}");
                else
                    Console.WriteLine("Wrong shoe size");
           
            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();
        }
        public void StreetNumberIsValid()
        {
            int number;
            bool parse = Int32.TryParse(StreetNumber, out number);
            if (parse)
                Console.WriteLine($"Your street number : {number}");
            else
                Console.WriteLine($"Cannot parse {StreetNumber}");

            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();
        }
        public void PersonalIdIsValid()
        {
            int number;
            bool parse = Int32.TryParse(PersonalId, out number);
            if (parse)
                Console.WriteLine($"Your personal id : {number}");
            else
                Console.WriteLine($"Cannot parse {PersonalId}");
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}
