using System;

//Problem 10. Employee Data
//A marketing company wants to keep record of its employees.Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender(m or f)
//Personal ID number(e.g. 8306112507)
//Unique employee number(27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.Use descriptive names.Print the data at the console.


class MarketingFirm
{
    static void Main(string[] args)
    {
        Console.Write("First Name:");
        string inputName = Console.ReadLine();
        Console.Write("Family Name:");
        string inputFName = Console.ReadLine();
        Console.Write("Age:");
        string inputAge = Console.ReadLine();
        byte age = byte.Parse(inputAge);
        Console.Write("Gender(m or f):");
        char gender = char.Parse(Console.ReadLine());
        if (gender == 'm')
        {
            Console.WriteLine("Your gender is Male");
        }
        else if (gender == 'f')
        {
            Console.WriteLine("Your gender is Female");
        }
        else
        {
            Console.WriteLine("Wrong symbol");
        }
        Console.Write("ID number(27560000 to 27569999):");
        string inputIDNum = Console.ReadLine();
        int idNumber = int.Parse(inputIDNum);
        if (idNumber < 27560000)
        {
            Console.WriteLine("Wrong ID number");
        }
        else if (idNumber > 27569999)
        {
            Console.WriteLine("Wrong ID number");
        }
        else
        {
            Console.WriteLine("ID number: {0}", idNumber);
        }
    }
}

