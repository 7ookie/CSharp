using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace companyStuff
{
    class companyStuff
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter company name:");
            string companyName = (Console.ReadLine());
            Console.WriteLine("Enter company address:");
            string companyAddress = (Console.ReadLine());
            Console.WriteLine("Enter company phone number:");
            uint companyPhone = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter company fax number:");
            uint companyFax = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter company web site:");
            string companyWebSite = (Console.ReadLine());
            Console.WriteLine("Enter manager first name:");
            string managerFirstName = (Console.ReadLine());
            Console.WriteLine("Enter manager last name:");
            string managerLastName = (Console.ReadLine());
            Console.WriteLine("Enter manager age:");
            byte managerAge = byte.Parse(Console.ReadLine());
            string managerName = managerFirstName + " " + managerLastName;
            Console.WriteLine("Enter manager phone number:");
            uint managerPhone = uint.Parse(Console.ReadLine());
            Console.Write("Company information. \nCompany name \"{0}\" with location {1}.\n", companyName, companyAddress);
            Console.Write("Phone number: {0}\nFax number: {1}\nWeb site: {2}\n", companyPhone, companyFax, companyWebSite);
            Console.Write("Manager {0}.\nAge - {1}.\nContacts:\nPhone number: {2}\n", managerName, managerAge, managerPhone);
        }
    }
}
