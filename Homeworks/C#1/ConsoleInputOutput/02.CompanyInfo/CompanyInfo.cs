using System;

class CompanyInfo
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string adress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string fax = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        Console.WriteLine(name);
        Console.WriteLine("Address: {0}", adress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        if (fax == string.Empty)
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", fax);
        }
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

