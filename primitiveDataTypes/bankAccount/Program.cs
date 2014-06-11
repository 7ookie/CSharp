using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Tsvetoslav";
            string middleName = "Borislavov";
            string lastName = "Yovchev";
            string holder = firstName + " " + middleName + " " + lastName;
            Console.WriteLine(holder);
            decimal balance = 14.4m;
            string bankName = "Free Cash";
            string IBAN = "BB99 IZZF 9656 78858";
            string BIC = "BUINBGSF";
            ulong firstCard = 638545375685858;
            ulong secondCard = 475796894563678;
            ulong thirdCard = 747797856880000;
            Console.WriteLine("Hi {0} your balance is {1} decillion \n(U need BigInteger :D) in Bank {2} with IBAN {3}",
                holder, balance, bankName, IBAN);
            Console.WriteLine("BIC {0} and three credit cards: \n{1} \n{2} \n{3}", BIC, firstCard, secondCard, thirdCard);
        }
    }
}
