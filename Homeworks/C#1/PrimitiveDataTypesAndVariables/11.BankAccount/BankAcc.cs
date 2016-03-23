using System;

//Problem 11. Bank Account Data

//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

class BankAcc
{
    static void Main(string[] args)
    {
        Console.Write("Your First Name:");
        string inputName = Console.ReadLine();
        Console.Write("Your Surname:");
        string inputSurname = Console.ReadLine();
        Console.Write("Last name:");
        string inputLastName = Console.ReadLine();
        decimal moneyBalance = 1934;

        Console.WriteLine("Your first name is: {0}\nYour middle name is: {1}\nYour last name is: {2}", inputName, inputSurname, inputLastName);
        string theNameOfTheBank = "PostBank";
        Console.WriteLine("Your bank is {0}", theNameOfTheBank);
        decimal balanceOfMoney = 2000;
        Console.WriteLine("Available bank balance: {0}lv", balanceOfMoney);
        string iBan = "BGN07FFUU87003456735671";
        Console.WriteLine("IBAN / {0}", iBan);
        string bicCode = "BIC43562";
        Console.WriteLine("BIC CODE / {0}", bicCode);
        ulong creditCard1 = 4346709612345976;
        Console.WriteLine("The number of your first credit card is: {0}", creditCard1);
        ulong creditCard2 = 1199886543214587;
        Console.WriteLine("The number of your second credit card is: {0}", creditCard2);
        ulong creditCard3 = 5432156789004012;
        Console.WriteLine("The number of your third credit card is: {0}", creditCard3);

    }
}

